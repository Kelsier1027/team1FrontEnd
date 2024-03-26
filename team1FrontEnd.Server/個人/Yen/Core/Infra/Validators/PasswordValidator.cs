using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.Validators
{
	public class PasswordValidator : BaseValidator
	{
		public PasswordValidator() : base()
		{
			// 使用全局常量替代硬編碼的字串
			_rules.Add(new LengthValidationRule(ValidationConfig.PasswordMinLength, ValidationConfig.PasswordMaxLength)); // 加入長度驗證規則

			_rules.Add(new UppercaseValidationRule(ValidationConfig.PasswordMinUppercaseCount)); // 加入大寫字母驗證規則

			_rules.Add(new LowercaseValidationRule(ValidationConfig.PasswordMinLowercaseCount)); // 加入小寫字母驗證規則

			_rules.Add(new DigitValidationRule(ValidationConfig.PasswordMinDigitCount)); // 加入數字驗證規則

			_rules.Add(new SpecialCharacterValidationRule(ValidationConfig.PasswordMinSpecialCharCount, ValidationConfig.PasswordSpecialChars)); // 加入特殊字元驗證規則

			_rules.Add(new CommonWeakPasswordsValidationRule()); // 加入常見弱密碼驗證規則

			_rules.Add(new NotContainWhiteSpaceValidationRule()); // 加入不包含空白字元驗證規則

			_rules.Add(new NotContainChineseValidationRule()); // 加入不包含中文驗證規則

		}

		public PasswordValidator(IEnumerable<IValidationRule> rules) : base(rules) { }
	}
}
