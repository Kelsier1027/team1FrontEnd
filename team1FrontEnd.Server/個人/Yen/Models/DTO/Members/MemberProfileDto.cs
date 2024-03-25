namespace team1FrontEnd.Server.個人.Yen.Models.DTO.Members
{
	public class MemberProfileDto
	{
#nullable enable
		public string? Account { get; set; }

		public int MemberPorfileId { get; set; }

		public int MemberId { get; set; }

		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public string? Email { get; set; }


		public string? Country { get; set; }

		public DateTime? DateOfBirth { get; set; }

		public bool? Gender { get; set; }

		public string? PhoneNumber { get; set; }

		public string? DialCode { get; set; }

		public string? ProfileImage { get; set; }
#nullable disable
	}
}