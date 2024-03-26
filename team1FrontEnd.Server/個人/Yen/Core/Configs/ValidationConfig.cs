namespace team1FrontEnd.Server.個人.Yen.Core.Configs
{
	public static class ValidationConfig
	{

		public const int DialCodeMaxLength = 6; // 國際區碼最大長度

		public const int PhoneNumberMaxLength = 15; // 電話號碼最大長度

		public const int EmailMaxLength = 50; // Email最大長度

		public const int NameMaxLength = 50; // 名字最大長度

		public const int PasswordMinLength = 6; // 密碼最小長度

		public const int PasswordMaxLength = 20; // 密碼最大長度

		public const int PasswordMinUppercaseCount = 1; // 密碼最小大寫字母數量

		public const int PasswordMinLowercaseCount = 1; // 密碼最小小寫字母數量

		public const int PasswordMinDigitCount = 1; // 密碼最小數字數量

		public const int PasswordMinSpecialCharCount = 0; // 密碼最小特殊字元數量

		public const string PasswordSpecialChars = "!@#$%^&*"; // 密碼特殊字元

	}

}
