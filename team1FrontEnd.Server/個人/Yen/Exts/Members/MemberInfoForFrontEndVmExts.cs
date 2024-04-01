using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	public static class MemberInfoForFrontEndVmExts
	{
		// 將 MemberInfoForFrontEndVm 轉換為 MemberDto
		public static MemberDto ToMemberDto(this MemberInfoForFrontEndVm vm)
		{
			return new MemberDto
			{
				Id = vm.Id,
				Account = vm.Account,
				FirstName = vm.FirstName,
				LastName = vm.LastName,
			};
		}
	}
}
