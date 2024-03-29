using Microsoft.AspNetCore.Identity;
using team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member;

namespace team1FrontEnd.Server.個人.Yen.Exts.IdentityUsers
{
	public static class IdentityUserExts
	{
		public static MemberRegisterVm ToMemberRegisterVm(this IdentityUser user)
		{
			// 將 IdentityUser 轉換為 MemberInfoForFrontEndVm
			return new MemberRegisterVm
			{
				Account = user.UserName,
				// 從PasswordHash取出前20字元，存入Password
				Password = user.PasswordHash!.Substring(0, 20)
			};
		}
	}
}
