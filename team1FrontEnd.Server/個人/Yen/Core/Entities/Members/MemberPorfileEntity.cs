namespace team1FrontEnd.Server.個人.Yen.Core.Entities.Members
{
	public class MemberProfileEntity
	{
#nullable enable
		public int Id { get; set; }

		public int MemberId { get; set; }

		public string? Email { get; set; }

		public string? ProfileImage { get; set; }

		public string? Country { get; set; }

		public DateTime? DateOfBirth { get; set; }

		public bool? Gender { get; set; }

		public string? PhoneNumber { get; set; }

		public string? DialCode { get; set; }
#nullable disable
	}
}
