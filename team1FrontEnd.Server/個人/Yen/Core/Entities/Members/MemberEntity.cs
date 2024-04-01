namespace team1FrontEnd.Server.個人.Yen.Core.Entities.Members
{
	public class MemberEntity
	{
		public int Id { get; set; }

		public string? Account { get; set; }

		public string? EncryptedPassword { get; set; }

		public DateTime? RegistrationDate { get; set; }

		public bool ActiveStatus { get; set; }

		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public bool IsEmailVerified { get; set; }

		public string? Email { get; set; }

		public string? Salt { get; set; }

		public bool? EmailConfirmed { get; set; }

		public string? PhoneNumber { get; set; }

		public string? AspNetUserId { get; set; }

		public DateTime? DateOfBirth { get; set; }

		public string? DialCode { get; set; }

		public string? Country { get; set; }

		public string? ProfileImage { get; set; }

		public bool? Gender { get; set; }




	}
}
