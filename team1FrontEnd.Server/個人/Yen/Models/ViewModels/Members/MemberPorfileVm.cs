using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;

namespace team1FrontEnd.Server.個人.Yen.Models.ViewModels.Members
{
	/// <summary>
	/// 用於顯示完整 MemberProfile 的 ViewModel
	/// 一共十個欄位，分別是 MemberPorfileId, MemberId, FirstName, LastName, Email, PhoneNumber, DialCode, Country, DateOfBirth, ProfileImage
	/// </summary>
	public class MemberProfileVm
	{
#nullable disable
		public string Account { get; set; }

		public int MemberProfileId { get; set; }

		[Required(ErrorMessage = ValidationMessages.EmptyMemberId)]
		public int MemberId { get; set; }

		[Required(ErrorMessage = ValidationMessages.EmptyFirstName)]
		[StringLength(ValidationConfig.NameMaxLength, ErrorMessage = ValidationMessages.LengthTooLong)]
		public string FirstName { get; set; }

		[Required(ErrorMessage = ValidationMessages.EmptyLastName)]
		[StringLength(ValidationConfig.NameMaxLength, ErrorMessage = ValidationMessages.LengthTooLong)]
		public string LastName { get; set; }

		[Required(ErrorMessage = ValidationMessages.EmptyEmail)]
		[EmailAddress(ErrorMessage = ValidationMessages.InvalidEmail)]
		[StringLength(ValidationConfig.EmailMaxLength, ErrorMessage = ValidationMessages.LengthTooLong)]
		public string Email { get; set; }

		[Required(ErrorMessage = ValidationMessages.EmptyPhoneNumber)]
		[Phone]
		[StringLength(ValidationConfig.PhoneNumberMaxLength, ErrorMessage = ValidationMessages.LengthTooLong)]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = ValidationMessages.EmptyDialCode)]
		[StringLength(ValidationConfig.DialCodeMaxLength, ErrorMessage = ValidationMessages.LengthTooLong)]
		public string DialCode { get; set; }

		public string Country { get; set; }

		public DateTime? DateOfBirth { get; set; }

		public string ProfileImage { get; set; }

		public bool? Gender { get; set; }

#nullable disable
	}
}
