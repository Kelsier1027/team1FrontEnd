using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	public class LengthValidationRule : IValidationRule
	{
		private readonly int _minLength;
		private readonly int _maxLength;

		// 在構造函數中接收最小和最大長度
		public LengthValidationRule(int minLength, int maxLength)
		{
			_minLength = minLength;
			_maxLength = maxLength;
		}

		/// <summary>
		/// 驗證輸入的長度是否在指定範圍內，並回傳bool，若不符合規則則拋出例外
		/// </summary>
		/// <param name="input"></param>
		/// <returns>回傳bool</returns>
		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{
			// 建立一個錯誤訊息list
			// 使用全局訊息常量替代硬編碼的字串
			List<string> errorMessages = new List<string>
	{

		$"輸入值的長度為 {input.Length}",
		string.Format(ValidationMessages.LengthRange, _minLength, _maxLength)
	};


			// 驗證輸入的長度是否在指定範圍內
			string? errorMessage = ValidateLength(input);
			if (errorMessage != null)
			{
				errorMessages.Add(errorMessage);
				return new ValidationResult(string.Join(", ", errorMessages));
			}

			return ValidationResult.Success!;
		}

		//  驗證輸入的長度是否在指定範圍內，回傳錯誤訊息字串
		private string? ValidateLength(string input)
		{
			// 驗證輸入的長度是否在指定範圍內，並且使用全局變數儲存錯誤訊息
			string? errorMessage = input.Length switch
			{
				_ when input.Length == 0 => ValidationMessages.EmptyInput,
				_ when input.Length < _minLength => ValidationMessages.LengthTooShort,
				_ when input.Length > _maxLength => ValidationMessages.LengthTooLong,
				_ => null
			};

			return errorMessage;
		}


	}

}
