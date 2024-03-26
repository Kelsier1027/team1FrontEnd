using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	public class EmailValidationRule : IValidationRule
	{
		/// <summary>
		/// 驗證email格式是否正確
		/// </summary>
		/// <param name="email"></param>
		/// <returns>返回ValidationResult</returns>
		public ValidationResult Validate(string email, Dictionary<string, object>? additionalParameters = null)
		{
			if (string.IsNullOrWhiteSpace(email)) // 驗證是否為空
				return new ValidationResult(ValidationMessages.EmptyEmail);

			try
			{
				// 正規化域名
				email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
									  RegexOptions.None, TimeSpan.FromMilliseconds(200));

				// 驗證域名部分並進行正規化
				string DomainMapper(Match match)
				{
					var idn = new IdnMapping(); // 使用IdnMapping類別轉換Unicode域名
					string domainName = idn.GetAscii(match.Groups[2].Value);
					return match.Groups[1].Value + domainName;
				}
			}
			catch (RegexMatchTimeoutException)
			{
				return new ValidationResult("驗證Email超時");
			}
			catch (ArgumentException)
			{
				return new ValidationResult("Email域名不正確");
			}

			try
			{
				bool isValid = Regex.IsMatch(email,
					@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
					RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

				if (isValid)
				{
					return ValidationResult.Success!; // 如果驗證通過，則返回Success
				}
				else
				{
					return new ValidationResult("Email格式不正確");
				}
			}
			catch (RegexMatchTimeoutException)
			{
				return new ValidationResult("驗證Email超時");
			}
		}
	}

}
