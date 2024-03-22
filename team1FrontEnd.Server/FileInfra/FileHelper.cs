namespace team1FrontEnd.Server.FileInfra
{
	public class FileHelper
	{
		public const string FileRequiredExMessage = "請上傳檔案";
		public const string FileExtensionExMessage = "請上傳以\".jpg\", \".jpeg\", \".png\", \".gif\"為副檔名之檔案";
		public const int FileMaxSize = 1024 * 1024;
		public const string FileSizeExMessage = "檔案大小請勿超過1MB";
		public const string CarModelImagesFolderPath = "~/個人/Huang/Images/";
		public const int PageSize = 9;
		public const string RepoDllName = "DAL.EFModel";
		public const string ServiceDllName = "BLL";
		public const string RequiredErrorMessage = "{0} 必填";
		public const string NameRepeatErrorMessage = "名稱重複無法新增";
		public const string FKErrorMessage = "因資料關聯性無法修改或刪除";
	}
}
