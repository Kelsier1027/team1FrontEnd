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
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member;
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
		//[Authorize] // 確保僅授權用戶可以訪問此端點 
		public async Task<IActionResult> Logout([FromBody] object empty)
		{
			if (empty != null)
			{
				await _signInManager.SignOutAsync();
				return Ok();
			}
			return Unauthorized();
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
		[HttpGet("getMemberInfo")]
		[Authorize]
		public async Task<IActionResult> GetMemberInfo([FromBody] MemberInfoForFrontEndVm vm)
		{
			// 比對傳入的帳號是否與登入者帳號相同
			if (vm.Account != User.Identity!.Name)
			{
				return Unauthorized();
			}

			// 將 ViewModel 轉換成 DTO
			var memberDto = vm.ToMemberDto();

			// 取得會員詳細資訊
			var memberFromDb = await _memberService.GetMemberAsync(memberDto);

			// 將 DTO 轉換成 ViewModel
			var memberVm = memberFromDb.ToMemberProfileVm();

			return Ok(memberVm);
		}




		// 叫用 IdentityUser 發送 sameSite設定為 none 的 cookie
		//[HttpGet("sendSameSiteNoneCookie")]
		//public async Task<IActionResult> SendSameSiteNoneCookie()
		//{
		//	var user = await _signInManager.UserManager.GetUserAsync(User);

		//	// 檢查user是否為null
		//	if (user == null)
		//	{
		//		return Unauthorized();
		//	}

		//	var cookie = await _signInManager.UserManager.GenerateUserTokenAsync(user, "Default", "SameSiteNone");
		//	// 將 cookie 設定為 .AspNetCore.Identity.Application
		//	Response.Cookies.Append(".AspNetCore.Identity.Application", cookie, new CookieOptions
		//	{
		//		SameSite = SameSiteMode.None,
		//		HttpOnly = true,
		//		Secure = true,
		//		Expires = DateTimeOffset.Now.AddMinutes(30),
		//	});


		//	return Ok();
		//}


	}
}
