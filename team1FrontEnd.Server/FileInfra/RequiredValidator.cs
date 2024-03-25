
namespace team1FrontEnd.Server.FileInfra
{
	public class RequiredValidator : IUploadValidator
	{
		public void CheckValid(IFormFile file)
		{
			if (file == null || file.Length < 0) throw new Exception(FileHelper.FileRequiredExMessage);
		}
	}
}
