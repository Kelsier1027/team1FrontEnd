using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;
using team1FrontEnd.Server.個人.Yen.Interface.IValidators;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.Validators
{
	public abstract class BaseValidator : IValidator
	{
		protected readonly List<IValidationRule> _rules = new List<IValidationRule>();

		protected BaseValidator() { }

		protected BaseValidator(IEnumerable<IValidationRule> rules)
		{
			_rules.AddRange(rules);
		}

		public ValidationResult Validate(string value, Dictionary<string, object>? additionalParameters = null)
		{
			List<string> errorMessages = new List<string>();
			List<string> errorRules = new List<string>();

			foreach (var rule in _rules)
			{
				var result = rule.Validate(value, additionalParameters);
				if (result != ValidationResult.Success && result.ErrorMessage != null)
				{
					errorMessages.Add(result.ErrorMessage);
					errorRules.Add(rule.GetType().Name);
				}
			}

			return errorMessages.Count == 0 ? ValidationResult.Success! : new ValidationResult(string.Join(", ", errorMessages), errorRules);
		}

	}

}
