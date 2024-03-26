using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Core.Entities.Members;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
    public static class MemberEFModelExts
	{
		// Member 轉換成 MemberEntity
		public static MemberEntity ToEntity(this Member member)
		{
			return new MemberEntity
			{
				Id = member.Id,
				Account = member.Account,
				EncryptedPassword = member.EncryptedPassword,
				RegistrationDate = member.RegistrationDate,
				ActiveStatus = member.ActiveStatus
			};
		}
	}
}
