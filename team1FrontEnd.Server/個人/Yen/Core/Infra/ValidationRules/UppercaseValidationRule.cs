using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	/// <summary>
	/// 驗證輸入字串是否包含大於指定數量的大寫字母
	/// </summary>
	public class UppercaseValidationRule : IValidationRule
	{
		private readonly int _minUppercaseCount; // 最小大寫字母數量

		/// <summary>
		/// 預設最小大寫字母數量為1
		/// </summary>
		public UppercaseValidationRule()
		{
			// 至少包含一個大寫字母
			_minUppercaseCount = 1;
		}


		/// <summary>
		/// 從建構子接收最小大寫字母數量		
		/// /// </summary>
		/// <param name="minUppercaseCount">最小大寫字母數量</param>
		public UppercaseValidationRule(int minUppercaseCount)
		{
			_minUppercaseCount = minUppercaseCount;
		}

		// 驗證輸入字串是否包含大於指定數量的大寫字母
		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{

			// 建立一個錯誤訊息list
			List<string> errorMessages = new List<string>();

			// 驗證輸入字串是否包含大於指定數量的大寫字母
			string? errorMessage = ValidateUppercase(input);

			if (errorMessage != null)
			{
				errorMessages.Add(errorMessage);
				return new ValidationResult(string.Join(", ", errorMessages));
			}

			return ValidationResult.Success!;
		}

		// 驗證輸入字串是否包含大於指定數量的大寫字母，並回傳錯誤訊息字串
		private string? ValidateUppercase(string input)
		{
			// 建立一個錯誤訊息list
			List<string> errorMessages = new List<string>();

			// 計算輸入字串中的大寫字母數量
			int uppercaseCount = input.Count(char.IsUpper);

			// 驗證輸入字串是否包含大於指定數量的大寫字母
			if (uppercaseCount < _minUppercaseCount)
			{
				errorMessages.Add(string.Format(ValidationMessages.MinUppercase, _minUppercaseCount));
				return string.Join(", ", errorMessages);
			}

			return null;
		}
	}
}
