using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	/// <summary>
	/// 驗證輸入字串是否包含大於或等於指定數量的小寫字母
	/// </summary>
	public class LowercaseValidationRule : IValidationRule
	{
		private readonly int _minLowercaseCount; // 最小小寫字母數量

		/// <summary>
		/// 預設最小小寫字母數量為1
		/// </summary>
		public LowercaseValidationRule()
		{
			// 至少包含一個小寫字母
			_minLowercaseCount = 1;
		}

		/// <summary>
		/// 從建構子接收最小小寫字母數量
		/// </summary>
		/// <param name="minLowercaseCount">最小小寫字母數量</param>
		public LowercaseValidationRule(int minLowercaseCount)
		{
			_minLowercaseCount = minLowercaseCount;
		}

		// 驗證輸入字串是否包含大於或等於指定數量的小寫字母
		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{
			// 建立一個錯誤訊息list
			List<string> errorMessages = new List<string>();

			// 驗證輸入字串是否包含大於指定數量的小寫字母
			string? errorMessage = ValidateUppercase(input);

			// 驗證輸入字串是否包含大於或等於指定數量的小寫字母
			if (errorMessage != null)
			{
				errorMessages.Add(errorMessage);
				return new ValidationResult(string.Join(", ", errorMessages));
			}

			return ValidationResult.Success!;
		}

		// 驗證輸入字串是否包含大於指定數量的小寫字母，並回傳錯誤訊息字串
		private string? ValidateUppercase(string input)
		{
			// 建立一個錯誤訊息list
			List<string> errorMessages = new List<string>();

			// 計算小寫字母數量
			int lowercaseCount = input.Count(char.IsLower);

			// 驗證輸入字串是否包含大於指定數量的小寫字母
			if (lowercaseCount < _minLowercaseCount)
			{
				errorMessages.Add(string.Format(ValidationMessages.MinLowercase, _minLowercaseCount));
				return string.Join(", ", errorMessages);
			}

			return null;
		}
	}

}
