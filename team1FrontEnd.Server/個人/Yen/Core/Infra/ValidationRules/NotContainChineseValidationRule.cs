using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	/// <summary>
	/// 驗證輸入字串不包含中文字符
	/// </summary>
	public class NotContainChineseValidationRule : IValidationRule
	{
		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{
			if (input.Any(c => c >= 0x4E00 && c <= 0x9FFF)) // 檢查是否包含在中文字符範圍內
			{
				return new ValidationResult(ValidationMessages.NoChineseCharactersAllowed);
			}

			return ValidationResult.Success!;
		}
	}
}
