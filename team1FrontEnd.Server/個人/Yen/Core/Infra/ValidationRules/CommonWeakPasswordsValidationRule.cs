using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	public class CommonWeakPasswordsValidationRule : IValidationRule
	{
		private readonly HashSet<string> _weakPasswords = new HashSet<string> { "password", "12345678", "qwerty" };

		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{
			if (_weakPasswords.Contains(input))
			{
				return new ValidationResult(ValidationMessages.CommonWeakPasswordsDisallowed);
			}

			return ValidationResult.Success!;
		}

	}
}
