using Microsoft.AspNetCore.Mvc;
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member;
using team1FrontEnd.Server.個人.Yen.Interface.IServices.Member;
using team1FrontEnd.Server.個人.Yen.Repositories.Members;
using team1FrontEnd.Server.個人.Yen.Services.Menber;

namespace team1FrontEnd.Server.Controllers.Yen.Members
{
	[Route("api/[controller]")]
	[ApiController]
	public class MemberProfilesController : ControllerBase
	{
		//private readonly dbTeam1Context _context;

		// Service 透過 DI 注入
		private readonly IMemberProfileService _memberProfileService;
		private readonly IMemberService _memberService;

		// Repository 透過 DI 注入
		private IMemberProfileRepository _memberProfileRepository;
		private IMemberRepository _memberRepository;


		public MemberProfilesController(dbTeam1Context context)
		{
			_memberProfileRepository = new MemberProfileEFRepository(context);
			_memberRepository = new MemberEFRepository(context);
			_memberProfileService = new MemberProfileService(_memberProfileRepository, _memberRepository);
			_memberService = new MemberService(_memberRepository);
		}


		// GET: api/MemberProfiles/5
		[HttpGet]
		[Route("{id}")]
		public async Task<IActionResult> GetMemberProfile(int id)
		{
			var memberProfile = await _memberProfileService.GetMemberProfileAsync(id);
			return Ok(memberProfile);
		}


	}
}
