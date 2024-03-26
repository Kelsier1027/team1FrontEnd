using System.ComponentModel.DataAnnotations;

namespace team1FrontEnd.Server.個人.Yen.Interface.IValidateRules
{
	public interface IValidationRule
	{
		/// <summary>
		/// 驗證傳入的值是否符合規則，並回傳 ValidationResult。
		/// </summary>
		/// <param name="input">需驗證的值</param>
		/// <param name="additionalParameters">額外的驗證參數，允許傳入多個參數</param>
		/// <returns>ValidationResult</returns>
		ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null);
	}
}
