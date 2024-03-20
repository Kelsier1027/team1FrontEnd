using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Core.Entities;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Member;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	public static class MemberEntityExts
	{
		// 將  MemberEntity 轉換成 MemberDto
		public static MemberDto ToDto(this MemberEntity memberEntity)
		{
			return new MemberDto
			{
				Id = memberEntity.Id,
				Account = memberEntity.Account,
				EncryptedPassword = memberEntity.EncryptedPassword,
				RegistrationDate = memberEntity.RegistrationDate,
				ActiveStatus = memberEntity.ActiveStatus
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
				ActiveStatus = memberEntity.ActiveStatus
			};
		}

	}
}
