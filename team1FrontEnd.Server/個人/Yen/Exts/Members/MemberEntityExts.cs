using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Core.Entities.Members;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	public static class MemberEntityExts
	{
		// 將  MemberEntity 轉換成 MemberDto
		public static MemberDto ToMemberDto(this MemberEntity memberEntity)
		{
			return new MemberDto
			{
				Id = memberEntity.Id,
				Account = memberEntity.Account,
				EncryptedPassword = memberEntity.EncryptedPassword,
				RegistrationDate = memberEntity.RegistrationDate,
				ActiveStatus = memberEntity.ActiveStatus,
				FirstName = memberEntity.FirstName,
				LastName = memberEntity.LastName,
				IsEmailVerified = memberEntity.IsEmailVerified,
				Email = memberEntity.Email,
				PhoneNumber = memberEntity.PhoneNumber,
				DateOfBirth = memberEntity.DateOfBirth,
				DialCode = memberEntity.DialCode,
				Country = memberEntity.Country,
				ProfileImage = memberEntity.ProfileImage,
				Gender = memberEntity.Gender


			};
		}

		// 將 MemberEntity 轉換成 Member
		public static Member ToModel(this MemberEntity memberEntity)
		{
			return new Member
			{
				Id = memberEntity.Id,
				Account = memberEntity.Account,
				EncryptedPassword = memberEntity.EncryptedPassword,
				RegistrationDate = memberEntity.RegistrationDate ?? DateTime.Now,
				ActiveStatus = memberEntity.ActiveStatus,
				FirstName = memberEntity.FirstName,
				LastName = memberEntity.LastName,
				EmailConfirmed = memberEntity.IsEmailVerified
			};
		}

		// 將 MemberEntity 轉換成 MemberPorfileDto
		public static MemberProfileDto ToMemberPorfileDto(this MemberEntity entity)
		{
			return new MemberProfileDto
			{
				MemberPorfileId = entity.Id,
				MemberId = entity.Id,
				Account = entity.Account,
				FirstName = entity.FirstName,
				LastName = entity.LastName,
			};
		}


	}
}
