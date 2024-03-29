using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	public static class MemberVmExts
	{
		// 將  MemberVm 轉換成MemberDto
		public static MemberDto ToDto(this MemberRegisterVm memberVm)
		{
			return new MemberDto
			{
				Account = memberVm.Account,
				OriginalPassword = memberVm.Password,
			};
		}
	}
}
