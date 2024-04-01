namespace team1FrontEnd.Server.個人.Yen.Models.ViewModels.Members
{
	public class UpdatePasswordVm
	{
		public string? Account { get; set; }
		public string? OldPassword { get; set; }
		public string? NewPassword { get; set; }
		public string? ConfirmPassword { get; set; }
	}
}
