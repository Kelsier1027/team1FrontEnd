namespace team1FrontEnd.Server.個人.Yen.Models.DTO.Members
{
	public class MemberDto
	{
		public int Id { get; set; }

		public string? Account { get; set; }

		public string? OriginalPassword { get; set; }

		public string? ConfirmPassword { get; set; }

		public string? EncryptedPassword { get; set; }

		public DateTime? RegistrationDate { get; set; }

		public bool ActiveStatus { get; set; }

		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public bool IsEmailVerified { get; set; }

	}
}
