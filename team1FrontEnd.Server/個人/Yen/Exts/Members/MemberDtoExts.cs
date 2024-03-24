using team1FrontEnd.Server.個人.Yen.Core.Entities;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Member;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member;

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
				ActiveStatus = memberDto.ActiveStatus,
				FirstName = memberDto.FirstName,
				LastName = memberDto.LastName,
				IsEmailVerified = memberDto.IsEmailVerified
			};
		}

		// 將 MemberDto 轉換成 ToMemberInfoForFrontEndVm
		public static MemberInfoForFrontEndVm ToMemberInfoForFrontEndVm(this MemberDto memberDto)
		{
			return new MemberInfoForFrontEndVm
			{
				Id = memberDto.Id,
				FirstName = memberDto.FirstName,
				LastName = memberDto.LastName,
				Account = memberDto.Account
			};
		}
	}
}
