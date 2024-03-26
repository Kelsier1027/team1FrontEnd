using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Core.Entities.Members;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	public static class MemberProfileEFModelExts
	{
		// 將   MemberPorfileEFModel 轉換成  MemberPorfileEntity
		public static MemberProfileEntity ToMemberProfileEntity(this MemberProfile model)
		{
			return new MemberProfileEntity
			{
				Id = model.Id,
				MemberId = model.MemberId,
				Email = model.Email,
				ProfileImage = model.ProfileImage,
				Country = model.Country,
				DateOfBirth = model.DateOfBirth,
				Gender = model.Gender,
				PhoneNumber = model.PhoneNumber,
				DialCode = model.DialCode
			};
		}
	}
}
