using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using team1FrontEnd.Server.Models;
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

		// Repository 透過 DI 注入
		private IMemberRepository _memberRepository;

		private readonly DataContext _userContext;

		private readonly dbTeam1Context _context; // 資料庫內容

		private readonly SignInManager<IdentityUser> _signInManager; // 登入管理員，用於登入、登出

		public MembersController(dbTeam1Context context, SignInManager<IdentityUser> signInManager, DataContext userContext)
		{
			_signInManager = signInManager;
			_memberRepository = new MemberEFRepository(context);
			_memberService = new MemberService(_memberRepository);
			_context = context;
			_userContext = userContext;
		}


		// 登出，清除登入的 Cookie，在這裡使用了 SignInManager.SignOutAsync 方法，來自於 Microsoft.AspNetCore.Identity 命名空間，其為登入管理員，用於登入、登出，能夠做到登入、登出的功能以及其他一些與登入相關的操作。
		[HttpPost("logout")]
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
		//[Authorize]
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

			// 註冊客製化會員，先使用帳號嘗試取得會員，檢查是否已經註冊過
			var memberFromDb = await _memberService.GetMemberAsync(memberDto);

			// 如果已經註冊過，則返回 BadRequest
			if (memberFromDb != null)
			{
				return BadRequest("Member already exists.");
			}

			try
			{
				var registeredMember = await _memberService.RegisterMemberAsync(memberDto);
				// 將 DTO 轉換成 ViewModel
				var registeredMemberVm = registeredMember.ToMemberInfoForFrontEndVm();
				return Ok(registeredMemberVm);
			}
			catch (ArgumentException ex)
			{
				// 如果該帳戶註冊失敗，將 IdentityUser 中相應的帳戶刪除，以供用戶再次註冊
				await _signInManager.UserManager.DeleteAsync(user);
				return BadRequest(ex.Message);
			}
		}

		// 取得會員詳細資訊
		[HttpPost("getMemberInfo")]
		//[Authorize]
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
		[Authorize]
		public IActionResult CheckCookie()
		{
			return Ok();
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
		public async Task<IActionResult> changePassword([FromBody] UpdatePasswordVm updatePasswordVm)
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
	}
}
