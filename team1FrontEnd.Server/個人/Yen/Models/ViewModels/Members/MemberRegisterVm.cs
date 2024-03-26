using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;

namespace team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member
{
	public class MemberRegisterAndLoginVm
	{
#nullable disable
		[Required(ErrorMessage = ValidationMessages.EmptyAccount)]
		[EmailAddress(ErrorMessage = ValidationMessages.InvalidEmail)]
		public string Account { get; set; } // 帳號

		[Required(ErrorMessage = ValidationMessages.EmptyPassword)]
		[StringLength(ValidationConfig.PasswordMaxLength, MinimumLength = ValidationConfig.PasswordMinLength, ErrorMessage = ValidationMessages.LengthRange)]
		public string Password { get; set; } // 密碼
#nullable restore
	}
}
