namespace team1FrontEnd.Server.個人.Yen.Core.Configs
{
	public static class ValidationMessages
	{



		public const string EmptyDialCode = "國際區碼為空值";

		public const string EmptyFirstName = "名字為空值";

		public const string EmptyLastName = "姓氏為空值";

		public const string EmptyPhoneNumber = "電話號碼為空值";

		public const string EmptyMemberId = "會員編號為空值";

		public const string EmptyAccount = "帳號為空值";

		public const string EmptyPassword = "密碼為空值";

		public const string EmptyAccountOrPassword = "帳號或密碼為空值";

		public const string EmptyAccountAndPassword = "帳號與密碼為空值";

		public const string EmptyConfirmPassword = "確認密碼為空值";

		public const string PasswordNotMatch = "密碼與確認密碼不符";

		public const string IncorrectPassword = "密碼錯誤";

		public const string EmptyEmail = "Email為空值";

		public const string EmptyInput = "輸入值為空值";

		public const string LengthTooShort = "輸入值的長度不足";

		public const string LengthTooLong = "輸入值的長度過長";

		public const string LengthRange = "輸入值的長度需介於 {0} 到 {1} 之間";

		public const string InvalidEmail = "無效的電子郵件格式";

		public const string MinUppercase = "需至少包含 {0} 個大寫字母";

		public const string MinLowercase = "需至少包含 {0} 個小寫字母";

		public const string MinNumeric = "需至少包含 {0} 個數字";

		public const string MinSpecialCharacter = "需至少包含 {0} 個特殊字符";

		public const string NoSequentialCharacters = "不允許連續相同的字符超過 {0} 次";

		public const string NotMatchEmailPrefix = "密碼不允許與電子信箱@之前的字串相同";

		public const string CommonWeakPasswordsDisallowed = "不允許使用常見的弱密碼";

		public const string NoWhiteSpaceAllowed = "輸入值不允許包含空白字元";

		public const string NoChineseCharactersAllowed = "輸入值不允許包含中文字符";

	}
}
