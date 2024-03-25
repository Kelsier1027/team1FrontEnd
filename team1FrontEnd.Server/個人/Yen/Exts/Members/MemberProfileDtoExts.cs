using team1FrontEnd.Server.個人.Yen.Core.Entities.Members;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Members;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	public static class MemberProfileDtoExts
	{
		// 將 MemberProfileDto 轉換成 MemberProfileEntity
		public static MemberProfileEntity ToMemberProfileEntity(this MemberProfileDto dto)
		{
			return new MemberProfileEntity
			{
				Id = dto.MemberPorfileId,
				MemberId = dto.MemberId,
				Email = dto.Email,
				ProfileImage = dto.ProfileImage,
				Country = dto.Country,
				DateOfBirth = dto.DateOfBirth,
			};
		}

		// 將 MemberProfileDto 轉換成 MemberProfileVm
		public static MemberProfileVm ToMemberProfileVm(this MemberProfileDto dto)
		{
			return new MemberProfileVm
			{
				MemberProfileId = dto.MemberPorfileId,
				MemberId = dto.MemberId,
				Email = dto.Email,
				ProfileImage = dto.ProfileImage,
				Country = dto.Country,
				DateOfBirth = dto.DateOfBirth,
				Gender = dto.Gender,
				PhoneNumber = dto.PhoneNumber,
				DialCode = dto.DialCode,
				FirstName = dto.FirstName,
				LastName = dto.LastName

			};
		}

		// 判斷兩個 MemberProfileDto 中相同屬性中是否都有值，有則報錯誤，無則合併並回傳
		public static MemberProfileDto Merge(this MemberProfileDto dto, MemberProfileDto dto2)
		{
			if (dto == null)
			{
				throw new Exception("MemberProfileDto 本身為空值");
			}
			if (dto2 == null)
			{
				throw new Exception("參數為空值");
			}
			if (!string.IsNullOrEmpty(dto.Account) && !string.IsNullOrEmpty(dto2.Account))
			{
				throw new Exception("Account 重複");
			}
			if (dto.MemberPorfileId != 0 && dto2.MemberPorfileId != 0)
			{
				throw new Exception("MemberProfileId 重複");
			}
			if (dto.MemberId != 0 && dto2.MemberId != 0)
			{
				throw new Exception("MemberId 重複");
			}
			if (!string.IsNullOrEmpty(dto.FirstName) && !string.IsNullOrEmpty(dto2.FirstName))
			{
				throw new Exception("FirstName 重複");
			}
			if (!string.IsNullOrEmpty(dto.LastName) && !string.IsNullOrEmpty(dto2.LastName))
			{
				throw new Exception("LastName 重複");
			}
			if (!string.IsNullOrEmpty(dto.Email) && !string.IsNullOrEmpty(dto2.Email))
			{
				throw new Exception("Email 重複");
			}
			if (!string.IsNullOrEmpty(dto.Country) && !string.IsNullOrEmpty(dto2.Country))
			{
				throw new Exception("Country 重複");
			}
			if (dto.DateOfBirth != null && dto2.DateOfBirth != null)
			{
				throw new Exception("DateOfBirth 重複");
			}
			if (dto.Gender != null && dto2.Gender != null)
			{
				throw new Exception("Gender 重複");
			}
			if (!string.IsNullOrEmpty(dto.PhoneNumber) && !string.IsNullOrEmpty(dto2.PhoneNumber))
			{
				throw new Exception("PhoneNumber 重複");
			}
			if (!string.IsNullOrEmpty(dto.DialCode) && !string.IsNullOrEmpty(dto2.DialCode))
			{
				throw new Exception("DialCode 重複");
			}
			if (!string.IsNullOrEmpty(dto.ProfileImage) && !string.IsNullOrEmpty(dto2.ProfileImage))
			{
				throw new Exception("ProfileImage 重複");
			}

			// 合併兩個 MemberProfileDto
			return new MemberProfileDto
			{
				Account = string.IsNullOrEmpty(dto.Account) ? dto2.Account : dto.Account,
				MemberPorfileId = dto.MemberPorfileId == 0 ? dto2.MemberPorfileId : dto.MemberPorfileId,
				MemberId = dto.MemberId == 0 ? dto2.MemberId : dto.MemberId,
				FirstName = string.IsNullOrEmpty(dto.FirstName) ? dto2.FirstName : dto.FirstName,
				LastName = string.IsNullOrEmpty(dto.LastName) ? dto2.LastName : dto.LastName,
				Email = string.IsNullOrEmpty(dto.Email) ? dto2.Email : dto.Email,
				Country = string.IsNullOrEmpty(dto.Country) ? dto2.Country : dto.Country,
				DateOfBirth = dto.DateOfBirth == null ? dto2.DateOfBirth : dto.DateOfBirth,
			};

		}
	}
}
