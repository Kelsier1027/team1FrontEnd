namespace team1FrontEnd.Server.FileInfra
{
	public interface IRenameProvider
	{
		string Rename(string oldName, string newName = null);
	}
}
