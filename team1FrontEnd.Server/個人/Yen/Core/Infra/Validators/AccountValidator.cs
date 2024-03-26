using team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.Validators
{
	public class AccountValidator : BaseValidator
	{
		public AccountValidator() : base()
		{
			_rules.Add(new EmailValidationRule());
		}

		public AccountValidator(IEnumerable<IValidationRule> rules) : base(rules) { }
	}

}
