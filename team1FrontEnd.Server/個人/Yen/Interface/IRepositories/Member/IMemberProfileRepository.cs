using team1FrontEnd.Server.個人.Yen.Core.Entities.Members;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;

namespace team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member
{
	internal interface IMemberProfileRepository
	{
		Task<MemberProfileDto> GetMemberProfilesAsync(int id);

		Task<MemberProfileDto> UpdateMemberProfileAsync(MemberProfileEntity memberProfileEntity);
	}
}