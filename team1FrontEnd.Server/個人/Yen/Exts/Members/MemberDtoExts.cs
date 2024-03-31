using team1FrontEnd.Server.個人.Yen.Core.Entities.Members;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Members;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	/// <summary>
	/// MemberDto的擴充方法
	/// </summary>
	public static class MemberDtoExts
	{
		// 將  MemberDto 轉換成MemberEentity
		public static MemberEntity TomMemberEntity(this MemberDto memberDto)
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

		// 將 MemberDto 轉換成 ToMemberProfileDto
		public static MemberProfileDto ToMemberProfileDto(this MemberDto memberDto)
		{
			return new MemberProfileDto
			{
				MemberId = memberDto.Id,
				FirstName = memberDto.FirstName,
				LastName = memberDto.LastName,
				Account = memberDto.Account,
				Email = memberDto.Email,
				Country = memberDto.Country,
				DateOfBirth = memberDto.DateOfBirth,
			};
		}

		// 將 MemberDto 轉換成 MemberProfileVm
		public static MemberProfileVm ToMemberProfileVm(this MemberDto memberDto)
		{
			return new MemberProfileVm
			{
				MemberId = memberDto.Id,
				FirstName = memberDto.FirstName,
				LastName = memberDto.LastName,
				Account = memberDto.Account,
				Email = memberDto.Email,
				Country = memberDto.Country,
				DateOfBirth = memberDto.DateOfBirth,
				DialCode = memberDto.DialCode,
				PhoneNumber = memberDto.PhoneNumber,
				Gender = memberDto.Gender,
				ProfileImage = memberDto.ProfileImage
			};
		}
	}
}
