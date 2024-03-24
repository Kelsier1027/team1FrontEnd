using team1FrontEnd.Server.個人.Yen.Core.Configs;
using team1FrontEnd.Server.個人.Yen.Core.Entities;
using team1FrontEnd.Server.個人.Yen.Core.Infra.Validators;
using team1FrontEnd.Server.個人.Yen.Exts.Members;
using team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member;
using team1FrontEnd.Server.個人.Yen.Interface.IServices.Member;
using team1FrontEnd.Server.個人.Yen.Interface.IValidators;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Member;

namespace team1FrontEnd.Server.個人.Yen.Services.Menber
{
	public class MemberService : IMemberService
	{
		// 建立一個私有的 IMemberRepository 變數
		private IMemberRepository _repo;
		// 建立一個私有的 IValidator 變數 用來驗證 帳號
		private IValidator _accountValidator;
		// 建立一個私有的 IValidator 變數 用來驗證 Email
		private IValidator _emailValidator;
		// 建立一個私有的 IValidator 變數 用來驗證 密碼
		private IValidator _passwordValidator;

		// 建構子
		//public MemberService()
		//{
		//	_repo = new MemberEFRepository(new dbTeam1Context());
		//	_accountValidator = new AccountValidator();
		//	_emailValidator = new EmailValidator();
		//	_passwordValidator = new PasswordValidator();
		//}

		//public MemberService(IEnumerable<IValidator> validators)
		//{
		//	_repo = new MemberEFRepository(new dbTeam1Context());

		//	_emailValidator = validators.FirstOrDefault(v => v.GetType() == typeof(EmailValidator)) ?? new EmailValidator();

		//	_accountValidator = validators.FirstOrDefault(v => v.GetType() == typeof(AccountValidator)) ?? new AccountValidator();

		//	_passwordValidator = validators.FirstOrDefault(v => v.GetType() == typeof(PasswordValidator)) ?? new PasswordValidator();
		//}

		public MemberService(IMemberRepository repo)
		{
			_repo = repo;
			_accountValidator = new AccountValidator();
			_emailValidator = new EmailValidator();
			_passwordValidator = new PasswordValidator();
		}

		public MemberService(IMemberRepository repo, IEnumerable<IValidator> validators)
		{
			_repo = repo;

			_emailValidator = validators.FirstOrDefault(v => v.GetType() == typeof(EmailValidator)) ?? new EmailValidator();

			_accountValidator = validators.FirstOrDefault(v => v.GetType() == typeof(AccountValidator)) ?? new AccountValidator();

			_passwordValidator = validators.FirstOrDefault(v => v.GetType() == typeof(PasswordValidator)) ?? new PasswordValidator();
		}

		/// <summary>
		/// 註冊會員
		/// </summary>
		/// <param name="memberDto">存放會員註冊資料的DTO</param>
		/// <returns>回傳memberDto</returns>
		public async Task<MemberDto> RegisterMemberAsync(MemberDto memberDto)
		{
			// 檢查帳號密碼是否為空值
			if (memberDto.Account == null || memberDto.OriginalPassword == null) throw new ArgumentException(ValidationMessages.EmptyAccountAndPassword);

			// 檢查帳號是否已存在
			if (await IsAccountExistsAsync(memberDto.Account)) throw new ArgumentException("帳號已存在");

			// 驗證帳號、密碼
			ValidateMember(memberDto);

			// 將雜湊後的密碼存入 dto
			memberDto.EncryptedPassword = GenerateHashPassword(memberDto.OriginalPassword);

			// 加入註冊日期
			memberDto.RegistrationDate = DateTime.Now;

			// 將 ActiveStatus 設為 true 表示帳號已啟用
			memberDto.ActiveStatus = true;

			// 將 IsEmailVerified 設為 false 表示 Email 未驗證
			memberDto.IsEmailVerified = false;

			// 將 FirstName 設為 "Guest"
			memberDto.FirstName = "Guest";

			return await CreateMemberAsync(memberDto);
		}

		private string GenerateHashPassword(string password)
		{
			var salt = BCrypt.Net.BCrypt.GenerateSalt(BCryptConfig.SaltFactor);
			var hashPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
			return hashPassword;
		}

		/// <summary>
		/// 驗證會員資料
		/// </summary>
		/// <param name="memberDto">存放會員註冊資料的DTO</param>
		private void ValidateMember(MemberDto memberDto)
		{
			// 建立一個空的錯誤訊息字串
			var errorMessage = string.Empty;

			// 驗證帳號是否為空值
			if (memberDto.Account == null) throw new ArgumentException(ValidationMessages.EmptyAccount);

			// 驗證密碼是否為空值
			if (memberDto.OriginalPassword == null) throw new ArgumentException(ValidationMessages.EmptyPassword);

			// 驗證帳號
			errorMessage += _accountValidator.Validate(memberDto.Account);

			// 驗證密碼，將帳號當作額外參數傳入
			errorMessage += _passwordValidator.Validate(memberDto.OriginalPassword, new Dictionary<string, object> { { "account", memberDto.Account } });


			// 如果錯誤訊息不為空，拋出錯誤
			if (!string.IsNullOrWhiteSpace(errorMessage)) throw new ArgumentException(errorMessage);
		}

		/// <summary>
		/// 在資料庫中建立會員
		/// </summary>
		/// <param name="memberDto">存放會員註冊資料的DTO</param>
		/// <returns>回傳memberDto</returns>
		private async Task<MemberDto> CreateMemberAsync(MemberDto memberDto)
		{
			// 檢查除了 ID 以外的欄位是否為空值
			if (string.IsNullOrWhiteSpace(memberDto.Account) || string.IsNullOrWhiteSpace(memberDto.EncryptedPassword) || memberDto.RegistrationDate == null) throw new ArgumentException("會員資料不完整");

			// 創建 memberEntity
			var memberEntity = memberDto.ToEntity();

			// 呼叫 MemberRepository 創建會員
			var memberId = await _repo.CreateMember(memberEntity);

			// 取得創建的會員
			var entity = await _repo.GetMember(memberId);

			// 將會員轉換成 Dto
			return entity.ToDto();
		}

		public void DeleteMember(MemberDto memberDto)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///  取得會員資料
		/// </summary>
		/// <param name="memberDto"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<MemberDto> GetMember(MemberDto memberDto)
		{
			// 檢查帳號是否為空值
			if (memberDto.Account == null)
			{
				throw new ArgumentException(ValidationMessages.EmptyAccount);
			}

			// 根據傳入的帳號查詢會員，如果查詢不到會員，拋出錯誤
			var member = await _repo.GetMember(memberDto.Account) ?? throw new ArgumentException("帳號不存在");

			// 將會員轉換成 Dto 回傳
			return member.ToDto();
		}

		/// <summary>
		/// 檢查帳號是否存在
		/// </summary>
		/// <param name="account"></param>
		/// <returns></returns>
		public async Task<bool> IsAccountExistsAsync(string account)
		{
			MemberEntity member;
			try
			{
				// 根據傳入的帳號查詢會員
				member = await _repo.GetMember(account);
			}
			catch (Exception)
			{
				// 如果查詢不到會員，回傳 false
				return await Task.FromResult(false);
			}
			// 如果查詢到會員，回傳 true
			if (member != null) return await Task.FromResult(true);
			return await Task.FromResult(false);

		}

		/// <summary>
		///  更新會員密碼
		/// </summary>
		/// <param name="memberDto"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void UpdatePassword(MemberDto memberDto)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 會員登入
		/// </summary>
		/// <param name="memberDto"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public async Task<MemberDto> LoginMemberAsync(MemberDto memberDto)
		{
			// 檢查帳號密碼是否為空值
			if (memberDto.Account == null || memberDto.OriginalPassword == null) throw new ArgumentException(ValidationMessages.EmptyAccountOrPassword);

			// 根據帳號查詢會員
			var entity = await _repo.GetMember(memberDto.Account) ?? throw new ArgumentException(MemberApiMessages.AccountNotExist);

			if (string.IsNullOrWhiteSpace(memberDto.OriginalPassword) || string.IsNullOrWhiteSpace(entity.EncryptedPassword))
			{
				throw new ArgumentException(ValidationMessages.EmptyPassword);
			}

			// 驗證密碼
			VerifyPassword(memberDto.OriginalPassword, entity.EncryptedPassword);

			// 將會員轉換成 Dto
			return entity.ToDto();

		}

		/// <summary>
		/// 驗證帳號及密碼是否為空值
		/// </summary>
		/// <param name="account">帳號</param>
		/// <param name="password">密碼</param>
		private void IsAccountOrPasswordIsNull(MemberDto memberDto)
		{
			if (string.IsNullOrWhiteSpace(memberDto.Account) || string.IsNullOrWhiteSpace(memberDto.OriginalPassword))
			{
				throw new ArgumentException(ValidationMessages.EmptyAccountAndPassword);
			}
		}

		/// <summary>
		/// 檢查帳號是否為空值
		/// </summary>
		/// <param name="account"></param>
		/// <exception cref="ArgumentException"></exception>
		public void IsAccountIsNull(string account)
		{
			if (string.IsNullOrWhiteSpace(account)) throw new ArgumentException(ValidationMessages.EmptyAccount);
		}

		/// <summary>
		/// 檢查密碼是否為空值
		/// </summary>
		/// <param name="password"></param>
		/// <exception cref="ArgumentException"></exception>
		public void IsPasswordIsNull(string password)
		{
			if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException(ValidationMessages.EmptyPassword);
		}

		/// <summary>
		/// 驗證密碼是否正確
		/// </summary>
		/// <param name="password">輸入的密碼</param>
		/// <param name="hashedPassword">雜湊後的密碼</param>
		/// <exception cref="ArgumentException">密碼錯誤</exception>
		private void VerifyPassword(string password, string hashedPassword)
		{
			if (!BCrypt.Net.BCrypt.Verify(password, hashedPassword)) throw new ArgumentException(ValidationMessages.IncorrectPassword);
		}


	}
}
