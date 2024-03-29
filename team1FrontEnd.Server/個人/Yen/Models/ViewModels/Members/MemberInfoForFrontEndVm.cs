namespace team1FrontEnd.Server.個人.Yen.Models.ViewModels.Member
{
	public class MemberInfoForFrontEndVm
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; } = "Guest";
		public string? Account { get; set; }

	}
}
