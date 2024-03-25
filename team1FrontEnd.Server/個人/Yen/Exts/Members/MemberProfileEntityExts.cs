using team1FrontEnd.Server.個人.Yen.Core.Entities.Members;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	public static class MemberProfileEntityExts
	{
		// 將 MemberPorfileEntity 轉換成 MemberPorfileDto
		public static MemberProfileDto ToMemberPorfileDto(this MemberProfileEntity entity)
		{
			return new MemberProfileDto
			{
				MemberPorfileId = entity.Id,
				MemberId = entity.MemberId,
				Email = entity.Email,
				ProfileImage = entity.ProfileImage,
				Country = entity.Country,
				DateOfBirth = entity.DateOfBirth,
				Gender = entity.Gender,
				PhoneNumber = entity.PhoneNumber,
				DialCode = entity.DialCode

			};
		}
	}
}
