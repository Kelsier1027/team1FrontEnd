using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	/// <summary>
	/// 驗證輸入字串不包含空白字元
	/// </summary>
	public class NotContainWhiteSpaceValidationRule : IValidationRule
	{
		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{
			if (input.Any(char.IsWhiteSpace))
			{
				return new ValidationResult(ValidationMessages.NoWhiteSpaceAllowed);
			}

			return ValidationResult.Success!;
		}
	}


}
