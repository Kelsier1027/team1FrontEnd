using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	public class EmailPrefixValidationRule : IValidationRule
	{
		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{
			if (additionalParameters == null || !additionalParameters.ContainsKey(ValidationParameterKeys.Email))
			{
				return new ValidationResult("額外參數（電子信箱）未提供。");
			}

			// 判斷 additionalParameters 中的 email 參數是否有值
			var email = additionalParameters[ValidationParameterKeys.Email].ToString();

			if (email == null)
			{
				return new ValidationResult("額外參數（電子信箱）為空值。");
			}

			var emailPrefix = email.Split('@')[0];

			if (input == emailPrefix)
			{
				return new ValidationResult(ValidationMessages.NotMatchEmailPrefix);
			}

			return ValidationResult.Success!;
		}
	}

}
