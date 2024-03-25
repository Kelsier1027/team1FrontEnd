
namespace team1FrontEnd.Server.FileInfra
{
	public class ExtensionValidator : IUploadValidator
	{
		public void CheckValid(IFormFile file)
		{
			var extension = Path.GetExtension(file.FileName);

			var imageExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };

			if (!imageExtensions.Any(e => e.Equals(extension, StringComparison.OrdinalIgnoreCase)))

				throw new Exception(FileHelper.FileExtensionExMessage);
		}
	}
}
