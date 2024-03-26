using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	public class DigitValidationRule : IValidationRule
	{
		private readonly int _minDigitCount;

		/// <summary>
		/// 預設最小數字數量為1
		/// </summary>
		public DigitValidationRule()
		{
			_minDigitCount = 1;
		}

		/// <summary>
		/// 從建構子接收最小數字數量
		/// </summary>
		/// <param name="minDigitCount">最小數字數量</param>
		public DigitValidationRule(int minDigitCount)
		{
			_minDigitCount = minDigitCount;
		}

		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{
			// 計算字串中的數字數量
			int digitCount = input.Count(char.IsDigit);

			if (digitCount < _minDigitCount)
			{
				return new ValidationResult(string.Format(ValidationMessages.MinNumeric));
			}

			return ValidationResult.Success!;
		}
	}
}
