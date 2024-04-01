namespace team1FrontEnd.Server.個人.Yen.Models.DTO.Members
{
	public class MemberDto
	{
		public int Id { get; set; }

		public string? Account { get; set; }

		public string? OriginalPassword { get; set; }

		public string? OldPassword { get; set; }

		public string? NewPassword { get; set; }

		public string? ConfirmPassword { get; set; }

		public string? EncryptedPassword { get; set; }

		public DateTime? RegistrationDate { get; set; }

		public bool ActiveStatus { get; set; }

		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public bool IsEmailVerified { get; set; }

		public string? Email { get; set; }

		public string? Country { get; set; }

		public DateTime? DateOfBirth { get; set; }

		public bool? Gender { get; set; }

		public string? PhoneNumber { get; set; }

		public string? DialCode { get; set; }

		public string? ProfileImage { get; set; }

	}
}
