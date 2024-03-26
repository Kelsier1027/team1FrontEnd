using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	public class SpecialCharacterValidationRule : IValidationRule
	{
		private readonly int _minSpecialCharCount;
		private readonly string _specialChars;

		public SpecialCharacterValidationRule(int minSpecialCharCount, string specialChars = "!@#$%^&*")
		{
			_minSpecialCharCount = minSpecialCharCount;
			_specialChars = specialChars;
		}

		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{
			int specialCharCount = input.Count(c => _specialChars.Contains(c));
			if (specialCharCount < _minSpecialCharCount)
			{
				return new ValidationResult(string.Format(ValidationMessages.MinSpecialCharacter, _minSpecialCharCount));
			}

			return ValidationResult.Success!;
		}
	}
}
