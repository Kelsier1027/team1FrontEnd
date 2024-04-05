using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util.Store;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Core.Infra;
using team1FrontEnd.Server.個人.Yen.Data;
using team1FrontEnd.Server.個人.Yen.Exts.IdentityUsers;
using team1FrontEnd.Server.個人.Yen.Exts.Members;
using team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member;
using team1FrontEnd.Server.個人.Yen.Interface.IServices.Member;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Members;
using team1FrontEnd.Server.個人.Yen.Repositories.Members;
using team1FrontEnd.Server.個人.Yen.Services.Menber;

namespace team1FrontEnd.Server.Controllers.Yen.Members
{
    [Route("api/[controller]")]
    [Authorize] // 確保僅授權用戶可以訪問此端點
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _memberService;

        private readonly IConfiguration _configuration;

        // Repository 透過 DI 注入
        private IMemberRepository _memberRepository;

        private readonly DataContext _userContext;

        private readonly dbTeam1Context _context; // 資料庫內容

        private readonly SignInManager<IdentityUser> _signInManager; // 登入管理員，用於登入、登出

        public MembersController(dbTeam1Context context, SignInManager<IdentityUser> signInManager, DataContext userContext, IConfiguration configuration)
        {
            _signInManager = signInManager;
            _memberRepository = new MemberEFRepository(context);
            _memberService = new MemberService(_memberRepository);
            _context = context;
            _userContext = userContext;
            _configuration = configuration;
        }


        // 登出，清除登入的 Cookie，在這裡使用了 SignInManager.SignOutAsync 方法，來自於 Microsoft.AspNetCore.Identity 命名空間，其為登入管理員，用於登入、登出，能夠做到登入、登出的功能以及其他一些與登入相關的操作。
        [HttpPost("logout")]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            if (User != null)
            {
                await _signInManager.SignOutAsync();
                return Ok();
            }
            else
            {
                // 清除登入的 Cookie
                await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
                return Unauthorized();
            }

        }


        // 透過 cookie 取得登入者資訊
        [HttpGet("getLoginInfo")]
        //[Authorize] // 確保僅授權用戶可以訪問此端點
        public async Task<IActionResult> GetLoginInfo()
        {
            //檢查 User 是否為 null，以及Identity是否為null
            if (User == null || User.Identity == null)
            {
                return Unauthorized();
            }
            // 透過 Identity 取得登入者username來索取客製化會員資訊
            var username = User.Identity.Name;

            // 以Dto類別傳遞
            MemberDto memberDto = new MemberDto();
            memberDto.Account = username;

            // 透過username取得客製化會員資訊
            var memberFromDb = await _memberService.GetMemberAsync(memberDto);

            // 將客製化會員資訊轉換成MemberInfoForFrontEndVm
            var memberVm = memberFromDb.ToMemberInfoForFrontEndVm();

            return Ok(memberVm);
        }

        // 將通過Identity註冊的用戶資訊轉換成MemberInfoForFrontEndVm，並註冊到客製化的MemberRepository中
        [HttpGet("registerToMember")]
        public async Task<IActionResult> registerToMember()
        {
            var user = await _signInManager.UserManager.GetUserAsync(User);

            // 檢查user是否為null
            if (user == null)
            {
                return Unauthorized();
            }
            // 將 IdentityUser 轉換成 RegisterAndLoginVm
            var memberRegisterVm = user.ToMemberRegisterVm();

            // 將 ViewModel 轉換成 DTO
            var memberDto = memberRegisterVm.ToDto();

            try
            {
                var registeredMember = await _memberService.RegisterMemberAsync(memberDto);
                // 將 DTO 轉換成 ViewModel
                var registeredMemberVm = registeredMember.ToMemberInfoForFrontEndVm();

                var member = _context.Members.FirstOrDefault(m => m.Account == registeredMemberVm.Account);

                // 產生 validationCode 並存入 Members 資料表中
                string verificationCode = Guid.NewGuid().ToString();
                // 將 validationCode 存入 Members 資料表中
                member.VerificationCode = verificationCode;
                _context.SaveChanges();

                // 發送確認註冊的郵件
                SendConfirmRegisterMail(member.Account, verificationCode);

                return Ok(registeredMemberVm);
            }
            catch (ArgumentException ex)
            {
                // 如果該帳戶註冊失敗，將 IdentityUser 中相應的帳戶刪除，以供用戶再次註冊
                await _signInManager.UserManager.DeleteAsync(user);
                return BadRequest(ex.Message);
            }

        }

        // 驗證信箱
        [HttpGet("ConfirmEmail")]
        [AllowAnonymous]
        public IActionResult ConfirmEmail(string memberAccount, string verificationCode)
        {
            // 檢查 memberAccount 是否為空值
            if (memberAccount == null)
            {
                return BadRequest("memberAccount cannot be empty.");
            }

            // 檢查 verificationCode 是否為空值
            if (verificationCode == null)
            {
                return BadRequest("verificationCode cannot be empty.");
            }

            // 檢查 Members 資料表中是否有 memberAccount
            var member = _context.Members.FirstOrDefault(m => m.Account == memberAccount);
            if (member == null)
            {
                return NotFound("Account does not exist.");
            }

            // 檢查 Members 資料表中的 verificationCode 是否與傳入的 verificationCode 相同
            if (member.VerificationCode != verificationCode)
            {
                return BadRequest("Verification code is incorrect.");
            }

            // 將 Members 資料表中的 IsEmailConfirmed 設為 true
            member.EmailConfirmed = true;
            _context.SaveChanges();

            // 驗證成功後，將 IdentityUser 中的 EmailConfirmed 設為 true
            var user = _userContext.Users.FirstOrDefault(u => u.UserName == memberAccount);
            if (user != null)
            {
                user.EmailConfirmed = true;
                _userContext.SaveChanges();
            }

            // 驗證成功後，將 Members 資料表中的 verificationCode 設為空值
            member.VerificationCode = null;
            _context.SaveChanges();

            // 將使用者導向至驗證成功頁面
            return Redirect("https://127.0.0.1:5173/confirmEmailSuccessed");
        }

        // 取得會員詳細資訊
        [HttpPost("getMemberInfo")]
        public async Task<IActionResult> GetMemberInfo([FromBody] string account)
        {
            // 比對傳入的帳號是否與登入者帳號相同
            if (account != User.Identity!.Name)
            {
                return Unauthorized();
            }

            // 將 ViewModel 轉換成 DTO
            var memberDto = new MemberDto
            {
                Account = account
            };

            // 取得會員詳細資訊
            var memberFromDb = await _memberService.GetMemberAsync(memberDto);

            // 如果會員不存在，返回 NotFound
            if (memberFromDb == null)
            {
                return NotFound();
            }

            // 將 DTO 轉換成 ViewModel
            var memberVm = memberFromDb.ToMemberProfileVm();

            // 將 MemberProfileVm 轉換成 MemberProfileVmString
            var memberVmString = new MemberProfileVmString
            {
                MemberId = memberVm.MemberId,
                Account = memberVm.Account,
                FirstName = memberVm.FirstName,
                LastName = memberVm.LastName,
                PhoneNumber = memberVm.PhoneNumber,
                DialCode = memberVm.DialCode,
                Country = memberVm.Country,
                Email = memberVm.Email,
                Gender = memberVm.Gender,
                // 將 DateOfBirth 轉換成字串
                DateOfBirth = memberVm.DateOfBirth?.ToString("yyyy-MM-dd")
            };

            return Ok(memberVmString);
        }

        // 檢查 cookie 是否通過驗證
        [HttpGet("checkCookie")]
        [AllowAnonymous]
        public IActionResult CheckCookie()
        {
            // 確認 cookie 是否通過驗證，回傳 true 或 false
            return Ok(User.Identity!.IsAuthenticated);
        }

        // 更新會員資訊
        [HttpPost("updateMemberInfo")]
        [Authorize]
        public async Task<IActionResult> UpdateMemberInfo([FromBody] MemberProfileVmString memberProfileVmString)
        {
            // 比對傳入的帳號是否與登入者帳號相同
            // 將傳入的Account去除空格
            memberProfileVmString.Account = memberProfileVmString.Account.Trim();
            if (memberProfileVmString.Account != User.Identity!.Name)
            {
                return Unauthorized();
            }
            // 取出傳入的 MemberProfileVmString，並轉換成 MemberProfileVm
            var memberProfileVm = new MemberProfileVm
            {
                MemberId = memberProfileVmString.MemberId,
                Account = memberProfileVmString.Account,
                FirstName = memberProfileVmString.FirstName,
                LastName = memberProfileVmString.LastName,
                PhoneNumber = memberProfileVmString.PhoneNumber,
                DialCode = memberProfileVmString.DialCode,
                Gender = memberProfileVmString.Gender,
                Email = memberProfileVmString.Email,
                Country = memberProfileVmString.Country,
                // 將 string 型別的 memberProfileVmString.DateOfBirth 轉換成 DateTime 型別
                DateOfBirth = DateTime.TryParse(memberProfileVmString.DateOfBirth, out var dateOfBirth) ? dateOfBirth : (DateTime?)null,
            };


            // 將 ViewModel 轉換成 DTO
            var memberDto = memberProfileVm.ToMemberDto();

            // 更新會員資訊
            var updatedMember = await _memberService.UpdateMemberInfoAsync(memberDto);

            // 如果會員不存在，返回 NotFound
            if (updatedMember == null)
            {
                return NotFound();
            }

            // 將 DTO 轉換成 ViewModel
            var updatedMemberVm = updatedMember.ToMemberProfileVm();

            return Ok(updatedMemberVm);
        }

        // 更新會員密碼
        [HttpPost("updatePassword")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] UpdatePasswordVm updatePasswordVm)
        {
            // 比對傳入的帳號是否與登入者帳號相同
            if (updatePasswordVm.Account != User.Identity!.Name)
            {
                return Unauthorized();
            }

            // 使用 _signInManager.UserManager 更新 AspNetUser 密碼
            var user = await _signInManager.UserManager.FindByNameAsync(updatePasswordVm.Account!);
            if (user == null)
            {
                return NotFound();
            }
            // 驗證舊密碼 新密碼 確認密碼是否為空值
            if (updatePasswordVm.OldPassword == null || updatePasswordVm.NewPassword == null || updatePasswordVm.ConfirmPassword == null)
            {
                return BadRequest("Old password, new password, and confirm password cannot be empty.");
            }

            // 驗證舊密碼是否正確
            var result = await _signInManager.UserManager.CheckPasswordAsync(user, updatePasswordVm.OldPassword);
            if (!result)
            {
                return BadRequest("Old password is incorrect.");
            }


            // 驗證新舊密碼是否相同
            if (updatePasswordVm.OldPassword == updatePasswordVm.NewPassword)
            {
                return BadRequest("New password cannot be the same as the old password.");
            }

            // 驗證新密碼是否與確認密碼相同
            if (updatePasswordVm.NewPassword != updatePasswordVm.ConfirmPassword)
            {
                return BadRequest("New password and confirm password do not match.");
            }

            // 使用 _signInManager.UserManager 更新 AspNetUser 密碼
            var updateResult = await _signInManager.UserManager.ChangePasswordAsync(user, updatePasswordVm.OldPassword, updatePasswordVm.NewPassword);

            // 如果更新失敗，返回 BadRequest
            if (!updateResult.Succeeded)
            {
                return BadRequest("Failed to update password.");
            }

            return Ok("密碼成功更新");
        }

        // 接收 email 以發送重設密碼的郵件
        [HttpPost("GetResetPasswordEmail")]
        [AllowAnonymous]
        public IActionResult GetResetPasswordEmail([FromBody] string username)
        {
            // 檢查 email 是否為空值
            if (username == null)
            {
                // 回傳 false 表示 email 為空值
                return Ok(false);
            }

            // 檢查 username 是否存在
            var user = _signInManager.UserManager.FindByNameAsync(username).Result;
            if (user == null)
            {
                // 回傳 false 表示 email 不存在
                return Ok(false);
            }
            // 檢查 Members 資料表中 Account 是否存在
            var member = _context.Members.FirstOrDefault(m => m.Account == username);
            if (member == null)
            {
                // 回傳 false 表示 Account 不存在
                return Ok(false);
            }


            // 使用 _signInManager.UserManager 產生重設密碼的 token ， _signInManager.UserManager.GeneratePasswordResetTokenAsync 的機制是透過使用者的 Id 來產生 token，並將 token 存入 AspNetUserTokens 資料表中，並回傳 token
            var token = _signInManager.UserManager.GeneratePasswordResetTokenAsync(user).Result;

            // _signInManager.UserManager 產生的 token 會包含特殊字元，需進行 UrlEncode ， 若要解碼則使用 UrlDecode
            token = System.Web.HttpUtility.UrlEncode(token);

            // 發送重設密碼的郵件
            SendResetPasswordMail(username, token);

            // 回傳 true 代表信件已寄出
            return Ok(true);
        }

        // 發送驗證信的方法
        [HttpPost("GetConfirmRegisterMail")]
        [AllowAnonymous]
        public IActionResult getConfirmRegisterMail([FromBody] string account)
        {
            // 檢查 account 是否為空值
            if (account == null)
            {
                // 回傳 false 表示 account 為空值
                return Ok(false);
            }

            // 透過 account 取得Members中的會員資訊
            var member = _context.Members.FirstOrDefault(m => m.Account == account);
            if (member == null)
            {
                // 回傳 false 不透露帳號是否存在
                return Ok(false);
            }

            // 產生 validationCode 並存入 Members 資料表中
            string verificationCode = Guid.NewGuid().ToString();
            // 將 validationCode 存入 Members 資料表中
            member.VerificationCode = verificationCode;
            _context.SaveChanges();

            // 發送確認信
            SendConfirmRegisterMail(account, verificationCode);

            // 回傳true 代表信件已寄出
            return Ok(true);
        }

        // 發送驗證信的郵件
        private void SendConfirmRegisterMail(string account, string validationCode)
        {
            // 透過 account 取得Members中的會員資訊
            var member = _context.Members.FirstOrDefault(m => m.Account == account);
            if (member == null)
            {
                return;
            }
            // 將 account 後的空格去除
            account = account.ToString().Trim();

            // 寄送確認信
            var urlTemplate = "https" + "://" +                                     // 生成 http:// 或 https://
                              "localhost:7113" + "/" +                              // 生成網域名稱或 ip
                              "api/Members/ConfirmEmail?memberAccount={0}&verificationCode={1}";   // 生成網頁 url
            var url = string.Format(urlTemplate, account, validationCode);
            string name = member.FirstName + " " + member.LastName;
            string email = account;
            new MemberEmailHelper().SendConfirmRegisterMail(url, name, email);

        }

        // 重設密碼的方法
        [HttpPost("ResetPassword")]
        [AllowAnonymous]
        public IActionResult ResetPassword([FromBody] ResetPasswordVm vm)
        {
            // 檢查 memberAccount 是否為空值
            if (vm.Account == null)
            {
                return BadRequest("memberAccount cannot be empty.");
            }
            // 使用 identityUser 內建的方法重設密碼
            var user = _signInManager.UserManager.FindByNameAsync(vm.Account).Result;
            if (user == null)
            {
                return NotFound("Account does not exist.");
            }

            // 檢查 password confirmedPassword 是否為空值
            if (vm.Password == null || vm.ConfirmPassword == null)
            {
                return BadRequest("Password and confirmed password cannot be empty.");
            }

            // 檢查 password 是否與 confirmedPassword 相同
            if (vm.Password != vm.ConfirmPassword)
            {
                return BadRequest("Password and confirmed password do not match.");
            }
            // 檢查 vm.Token 是否為空值
            if (vm.Token == null)
            {
                return BadRequest("Token cannot be empty.");
            }
            // 將 token 進行 UrlDecode
            //vm.Token = System.Web.HttpUtility.UrlDecode(vm.Token);

            // 使用 _signInManager.UserManager 更新 AspNetUser 密碼,
            var updateResult = _signInManager.UserManager.ResetPasswordAsync(user, vm.Token, vm.Password).Result;

            // 重設成功回傳 true
            return Ok(updateResult.Succeeded);

        }


        // 取得目前帳號登入信箱使否已經驗證
        [HttpGet("GetEmailVerificationInfo")]
        public async Task<IActionResult> GetEmailVerificationInfo()
        {
            // 取得目前帳號登入信箱
            var account = User.Identity!.Name;

            // 檢查 account 是否為空值
            if (account == null)
            {
                return BadRequest("Account cannot be empty.");
            }

            // 檢查 Members 資料表中是否有 account
            var member = _context.Members.FirstOrDefault(m => m.Account == account);
            if (member == null)
            {
                return NotFound("Account does not exist.");
            }

            // 回傳 Members 資料表中的 EmailConfirmed
            // 如果 EmailConfirmed 為 true，代表信箱已經驗證，如果為空值，代表信箱尚未驗證
            bool isEmailConfirmed = member.EmailConfirmed == true ? true : false;
            return Ok(isEmailConfirmed);
        }


        // 發送重設密碼的郵件
        private void SendResetPasswordMail(string account, string validationCode)
        {
            // 透過 account 取得Members中的會員資訊
            var member = _context.Members.FirstOrDefault(m => m.Account == account);
            if (member == null)
            {
                return;
            }
            // 將 account 後的空格去除
            account = account.ToString().Trim();
            // 寄送確認信
            var urlTemplate = "https" + "://" +                                     // 生成 http:// 或 https://
                              "127.0.0.1:5173" + "/" +                              // 生成網域名稱或 ip
                              "ResetPassword?memberAccount={0}&token={1}";   // 生成網頁 url
            var url = string.Format(urlTemplate, account, validationCode);
            string name = member.FirstName + " " + member.LastName;
            string email = member.Account;
            new MemberEmailHelper().SendForgetPasswordEmail(url, name, email);
        }

        [HttpGet("SendEmail")]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            #region OAuth驗證
            const string GMailAccount = "kelsieryen24@gmail.com";

            var clientSecrets = new ClientSecrets
            {
                ClientId = "866390391430-h9igit241k2m1s1fe5ecg1vgaint5h2q.apps.googleusercontent.com",
                ClientSecret = "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"
            };

            var codeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                DataStore = new FileDataStore("CredentialCacheFolder", false),
                Scopes = new[] { "https://mail.google.com/" },
                ClientSecrets = clientSecrets
            });

            var codeReceiver = new LocalServerCodeReceiver();
            var authCode = new AuthorizationCodeInstalledApp(codeFlow, codeReceiver);

            var credential = await authCode.AuthorizeAsync(GMailAccount, CancellationToken.None);

            if (credential.Token.IsExpired(Google.Apis.Util.SystemClock.Default))
                await credential.RefreshTokenAsync(CancellationToken.None);

            var oauth2 = new SaslMechanismOAuth2(credential.UserId, credential.Token.AccessToken);
            #endregion

            #region 信件內容
            var message = new MimeMessage();
            //寄件者名稱及信箱(信箱是測試帳號)
            message.From.Add(new MailboxAddress("kelsieryen24", "kelsieryen24@gmail.com"));
            //收件者名稱，收件者信箱
            message.To.Add(new MailboxAddress("w6886423e", "w6886423e@gmail.com"));
            //信件標題
            message.Subject = "How you doing'?";
            //信件內容
            message.Body = new TextPart("plain")
            {
                Text = @"This is test"
            };
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587);
                await client.AuthenticateAsync(oauth2);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
            #endregion

            return Ok("OK");
        }

        // 測試 _signInManager.UserManager.GeneratePasswordResetTokenAsync 產生的 token 是否正確
        [HttpGet("GenerateToken")]
        [AllowAnonymous]
        public async Task<IActionResult> GenerateToken(string username)
        {
            // 檢查 username 是否為空值
            if (username == null)
            {
                return BadRequest("username cannot be empty.");
            }

            // 檢查 username 是否存在
            var user = await _signInManager.UserManager.FindByNameAsync(username);
            if (user == null)
            {
                return NotFound("Account does not exist.");
            }

            // 產生重設密碼的 token
            var token = await _signInManager.UserManager.GeneratePasswordResetTokenAsync(user);

            return Ok(token);
        }

        // 測試用API
        [HttpPost("TestDataForm")]
        [AllowAnonymous]
        public IActionResult TestDataForm([FromBody] Object input)
        {
            return Ok(input);
        }

        // google 登入
        [HttpPost("valid-google-login")]
        [AllowAnonymous]
        public async Task<IActionResult> ValidGoogleLogin()
        {
            string? formCredential = Request.Form["credential"];
            string? formToken = Request.Form["g_csrf_token"];
            //string? cookiesToken = Request.Cookies["g_csrf_token"];
            string? cookiesToken = Request.Form["g_csrf_token"];


            var payload = await VerifyGoogleToken(formCredential, formToken, cookiesToken);

            if (payload == null)
            {
                return BadRequest("驗證 Google 授權失敗");
            }
            else
            {
                var userInfo = new
                {
                    Message = "驗證 Google 授權成功",
                    Email = payload.Email,
                    Name = payload.Name,
                    Picture = payload.Picture
                };
                /*return Ok(userInfo);*/

                //使用 IdentityUser 檢查是否有此帳號
                var user = await _signInManager.UserManager.FindByNameAsync(payload.Email);

                //如果沒有此帳號，則註冊新帳號
                if (user == null)
                {
                    //註冊新帳號
                    var newUser = new IdentityUser
                    {
                        UserName = userInfo.Email,
                        Email = userInfo.Email,
                        EmailConfirmed = true
                    };
                    var result = await _signInManager.UserManager.CreateAsync(newUser);

                    // 將新帳號加入 Members 資料表
                    var member = new Member // 新增會員資料
                    {
                        Account = userInfo.Email,
                        Email = userInfo.Email,
                        FirstName = userInfo.Name,
                        RegistrationDate = DateTime.Now,
                        EncryptedPassword = "GoogleLogin",
                        EmailConfirmed = true
                    };
                    _context.Members.Add(member); // 新增會員資料 
                    _context.SaveChanges(); // 儲存變更

                    if (result.Succeeded)
                    {
                        //註冊成功，將新帳號登入
                        await _signInManager.SignInAsync(newUser, true);
                        // 轉跳到首頁
                        return Redirect("https://127.0.0.1:5173");

                    }
                    else
                    {
                        return BadRequest("註冊失敗");
                    }
                }
                else
                {
                    //如果有此帳號，則登入
                    await _signInManager.SignInAsync(user, true);
                    return Redirect("https://127.0.0.1:5173");
                }

            }

        }

        private async Task<GoogleJsonWebSignature.Payload?> VerifyGoogleToken(string? formCredential, string? formToken, string? cookiesToken)
        {
            if (formCredential == null || formToken == null || cookiesToken == null || formToken != cookiesToken)
            {
                return null;
            }

            try
            {
                string GoogleApiClientId = _configuration.GetValue<string>("GoogleApiClientId");
                var settings = new GoogleJsonWebSignature.ValidationSettings
                {
                    Audience = new List<string> { GoogleApiClientId }
                };
                var payload = await GoogleJsonWebSignature.ValidateAsync(formCredential, settings);

                if (!payload.Issuer.Equals("accounts.google.com") && !payload.Issuer.Equals("https://accounts.google.com"))
                {
                    return null;
                }

                if (payload.ExpirationTimeSeconds == null)
                {
                    return null;
                }
                else
                {
                    DateTime now = DateTime.UtcNow;
                    DateTime expiration = DateTimeOffset.FromUnixTimeSeconds((long)payload.ExpirationTimeSeconds).UtcDateTime;
                    if (now > expiration)
                    {
                        return null;
                    }
                }
                return payload;
            }
            catch
            {
                return null;
            }
        }


    }
}
