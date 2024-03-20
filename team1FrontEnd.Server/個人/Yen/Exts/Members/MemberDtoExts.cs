using team1FrontEnd.Server.個人.Yen.Core.Entities;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Member;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	/// <summary>
	/// MemberDto的擴充方法
	/// </summary>
	public static class MemberDtoExts
	{
		// 將  MemberDto 轉換成MemberEentity
		public static MemberEntity ToEntity(this MemberDto memberDto)
		{
			return new MemberEntity
			{
				Id = memberDto.Id,
				Account = memberDto.Account,
				EncryptedPassword = memberDto.EncryptedPassword,
				RegistrationDate = memberDto.RegistrationDate,
				ActiveStatus = memberDto.ActiveStatus
			};
		}
	}
}
