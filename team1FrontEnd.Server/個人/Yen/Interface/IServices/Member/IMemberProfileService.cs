
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;

namespace team1FrontEnd.Server.個人.Yen.Interface.IServices.Member
{
	internal interface IMemberProfileService
	{
		Task<MemberProfileDto> GetMemberProfileAsync(int id);

		Task<MemberProfileDto> UpdateMemberProfileAsync(MemberProfileDto memberProfileDto);
	}
}