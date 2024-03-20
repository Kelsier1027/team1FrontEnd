namespace team1FrontEnd.Server.個人.Yen.Models.DTO.Member
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

	}
}
