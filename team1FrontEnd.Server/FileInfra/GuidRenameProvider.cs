namespace team1FrontEnd.Server.FileInfra
{
	public class GuidRenameProvider : IRenameProvider
	{
		public string Rename(string oldName, string newName = null)
		{
			var extension = Path.GetExtension(oldName);

			return $"{Guid.NewGuid():N}{extension}";
		}
	}
}
