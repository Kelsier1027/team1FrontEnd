using System.ComponentModel.DataAnnotations;
using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Interface.IValidateRules;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra.ValidationRules
{
	public class ConsecutiveCharactersValidationRule : IValidationRule
	{
		private readonly int _maxConsecutiveCount;

		public ConsecutiveCharactersValidationRule(int maxConsecutiveCount)
		{
			_maxConsecutiveCount = maxConsecutiveCount;
		}

		public ValidationResult Validate(string input, Dictionary<string, object>? additionalParameters = null)
		{
			int currentCount = 1;

			for (int i = 1; i < input.Length; i++)
			{
				if (input[i] == input[i - 1])
				{
					currentCount++;
					if (currentCount > _maxConsecutiveCount)
					{
						return new ValidationResult(string.Format(ValidationMessages.NotMatchEmailPrefix));
					}
				}
				else
				{
					currentCount = 1; // 重置計數器
				}
			}

			return ValidationResult.Success!;
		}
	}
}
