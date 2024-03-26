using team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.Validators
{
	public class EmailValidator : BaseValidator
	{
		public EmailValidator() : base()
		{
			_rules.Add(new EmailValidationRule());
		}

		public EmailValidator(IEnumerable<IValidationRule> rules) : base(rules) { }
	}
}
