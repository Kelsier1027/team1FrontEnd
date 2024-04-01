using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Members;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	public static class MemberProfileVmExts
	{
		// 將 MemberPorfileVm  轉換成   MemberPorfileDto
		public static MemberProfileDto ToMemberPorfileDto(this MemberProfileVm vm)
		{
			return new MemberProfileDto
			{
				MemberPorfileId = vm.MemberProfileId,
				MemberId = vm.MemberId,
				Email = vm.Email,
				ProfileImage = vm.ProfileImage,
				Country = vm.Country,
				DateOfBirth = vm.DateOfBirth,


			};

		}

		// 判斷兩個 MemberPorfileVm 中相同屬性中是否都有值，有則報錯誤，無則合併並回傳
		public static MemberProfileVm Merge(this MemberProfileVm vm, MemberProfileVm vm2)
		{
			if (vm == null)
			{
				throw new Exception("MemberProfileVm 本身為空值");
			}
			if (vm2 == null)
			{
				throw new Exception("參數為空值");
			}
			if (vm.MemberProfileId != 0 && vm2.MemberProfileId != 0)
			{
				throw new Exception("MemberProfileId 重複");
			}
			if (vm.MemberId != 0 && vm2.MemberId != 0)
			{
				throw new Exception("MemberId 重複");
			}
			if (!string.IsNullOrEmpty(vm.Email) && !string.IsNullOrEmpty(vm2.Email))
			{
				throw new Exception("Email 重複");
			}
			if (!string.IsNullOrEmpty(vm.ProfileImage) && !string.IsNullOrEmpty(vm2.ProfileImage))
			{
				throw new Exception("ProfileImage 重複");
			}
			if (!string.IsNullOrEmpty(vm.Country) && !string.IsNullOrEmpty(vm2.Country))
			{
				throw new Exception("Country 重複");
			}
			if (vm.DateOfBirth != null && vm2.DateOfBirth != null)
			{
				throw new Exception("DateOfBirth 重複");
			}

			return new MemberProfileVm
			{
				MemberProfileId = vm.MemberProfileId == 0 ? vm2.MemberProfileId : vm.MemberProfileId,
				MemberId = vm.MemberId == 0 ? vm2.MemberId : vm.MemberId,
				Email = string.IsNullOrEmpty(vm.Email) ? vm2.Email : vm.Email,
				ProfileImage = string.IsNullOrEmpty(vm.ProfileImage) ? vm2.ProfileImage : vm.ProfileImage,
				Country = string.IsNullOrEmpty(vm.Country) ? vm2.Country : vm.Country,
				DateOfBirth = vm.DateOfBirth == null ? vm2.DateOfBirth : vm.DateOfBirth,
			};
		}

		// 將 MemberPorfileVm 轉換成 ToMemberDto
		public static MemberDto ToMemberDto(this MemberProfileVm vm)
		{
			return new MemberDto
			{
				Id = vm.MemberId,
				Account = vm.Account,
				Email = vm.Email,
				Country = vm.Country,
				DateOfBirth = vm.DateOfBirth,
				DialCode = vm.DialCode,
				FirstName = vm.FirstName,
				LastName = vm.LastName,
				PhoneNumber = vm.PhoneNumber,
				Gender = vm.Gender,

			};
		}
	}
}
