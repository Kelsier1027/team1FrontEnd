using System.Web;

namespace team1FrontEnd.Server.FileInfra
{
	public interface IUploadValidator
	{
		void CheckValid(IFormFile file);
	}
}
