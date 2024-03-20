using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Exts.Members;
using team1FrontEnd.Server.個人.Yen.Interface.IServices.Member;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member;
using team1FrontEnd.Server.個人.Yen.Services.Menber;

namespace team1FrontEnd.Server.Controllers.Yen
{
	[Route("api/[controller]")]
	[ApiController]
	public class MembersController : ControllerBase
	{
		private readonly IMemberService _memberService;

		public MembersController()
		{
			_memberService = new MemberService();
		}

		public MembersController(IMemberService memberService)
		{
			_memberService = memberService;
		}

		// 註冊
		// POST: api/Members/register
		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] MemberRegisterAndLoginVm vm)
		{
			// 驗證 ModelState 是否通過
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			// 將 ViewModel 轉換成 DTO
			var memberDto = vm.ToDto();

			try
			{
				var registeredMember = await _memberService.RegisterMemberAsync(memberDto);
				return Ok(registeredMember);
			}
			catch (ArgumentException ex)
			{
				return BadRequest(ex.Message);
			}
		}

		// 登入
		// POST: api/Members/login
		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] MemberRegisterAndLoginVm vm)
		{
			// 驗證 ModelState 是否通過
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var memberDto = vm.ToDto();

			var member = await _memberService.LoginMemberAsync(memberDto);

			if (member == null)
			{
				return Unauthorized(MemberApiMessages.AccountOrPasswordError);
			}

			// 驗證 member.Account 是否為空值
			if (string.IsNullOrWhiteSpace(member.Account))
			{
				return Unauthorized(MemberApiMessages.EmptyAccount);
			}
			var claims = new List<Claim>
		{
			new Claim(ClaimTypes.Name, member.Account),
            // 這裡可以根據實際情況添加更多的聲明
        };

			var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
			var authProperties = new AuthenticationProperties();
			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

			return Ok(MemberApiMessages.LoginSuccess);
		}

		// 登出
		// POST: api/Members/logout
		[HttpPost("logout")]
		[Authorize]
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return Ok("登出成功");
		}
	}
}
