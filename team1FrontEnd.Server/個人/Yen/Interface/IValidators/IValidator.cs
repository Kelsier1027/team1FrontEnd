using System.ComponentModel.DataAnnotations;

namespace team1FrontEnd.Server.個人.Yen.Interface.IValidators
{
	public interface IValidator
	{
		public ValidationResult Validate(string value, Dictionary<string, object>? additionalParameters = null);
	}
}
