
namespace team1FrontEnd.Server.FileInfra
{
	public class MaxSizeValidator : IUploadValidator
	{
		public void CheckValid(IFormFile file)
		{
			if (file.Length > FileHelper.FileMaxSize) throw new Exception(FileHelper.FileSizeExMessage);
		}
	}
}
