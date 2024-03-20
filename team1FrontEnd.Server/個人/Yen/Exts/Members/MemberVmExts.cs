using team1FrontEnd.Server.個人.Yen.Models.DTO.Member;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member;

namespace team1FrontEnd.Server.個人.Yen.Exts.Members
{
	public static class MemberVmExts
	{
		// 將  MemberVm 轉換成MemberDto
		public static MemberDto ToDto(this MemberRegisterAndLoginVm memberVm)
		{
			return new MemberDto
			{
				Account = memberVm.Account,
				EncryptedPassword = memberVm.Password,
			};
		}
	}
}
