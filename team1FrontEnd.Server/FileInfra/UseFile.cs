namespace team1FrontEnd.Server.FileInfra
{
	public class UseFile
	{
		private IRenameProvider _renameProvider;
		private IUploadValidator[] _uploadValidators;

		public UseFile(IRenameProvider renameProvider, params IUploadValidator[] validators)
		{
			_renameProvider = renameProvider;
			_uploadValidators = validators;
		}

		public string Save(string path, IFormFile file)
		{
			// 确保文件不为null
			if (file == null || file.Length == 0)
			{
				throw new ArgumentException("File is required.", nameof(file));
			}

			IsValid(file); // 验证文件

			string newName = _renameProvider.Rename(file.FileName);
			string fullPath = Path.Combine(path, newName);

			using (var stream = new FileStream(fullPath, FileMode.Create))
			{
				file.CopyTo(stream);
			}

			return newName;
		}

		public void Delete(string path, params string[] fileNames)
		{
			foreach (var fileName in fileNames)
			{
				var fullName = Path.Combine(path, fileName);

				if (File.Exists(fullName))
				{
					File.Delete(fullName);
				}
			}
		}

		private void IsValid(IFormFile file)
		{
			if (_uploadValidators == null) return;

			foreach (var validator in _uploadValidators)
			{
				validator.CheckValid(file);
			}
		}
	}
}
