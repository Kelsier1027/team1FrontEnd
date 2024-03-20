using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Core.Entities;
using team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member;

namespace team1FrontEnd.Server.個人.Yen.Repositories.Members
{
	public class MemberEFRepository : IMemberRepository
	{
		DbContextOptions<dbTeam1Context> options = new DbContextOptionsBuilder<dbTeam1Context>()
			.UseSqlServer("Server= sparkle206-sparkle.myftp.biz;Initial Catalog=dbTeam1;Persist Security Info=True;User ID=team1;Password=team1;Integrated Security=True;TrustServerCertificate=true")
			.Options;

		/// <summary>
		/// 創建會員
		/// </summary>
		/// <param name="memberEntity">memberEntity</param>
		/// <returns>新增的會員的ID</returns>
		/// <exception cref="NotImplementedException"></exception>
		/// <exception cref="ArgumentNullException">傳入值為Null</exception>
		public async Task<int> CreateMember(MemberEntity memberEntity)
		{
			// 檢查 memberEntity 是否為 null
			if (memberEntity == null)
			{
				throw new ArgumentNullException(nameof(memberEntity));
			}

			// new 出一個Entity Framework的資料模型
			using (var db = new dbTeam1Context(options))
			{

				// 將Entity類別的資料轉換成Entity Framework的資料模型
				var member = new Member
				{
					Account = memberEntity.Account,
					EncryptedPassword = memberEntity.EncryptedPassword,
					RegistrationDate = memberEntity.RegistrationDate ?? DateTime.Now,
					ActiveStatus = memberEntity.ActiveStatus
				};

				// 新增資料
				db.Members.Add(member);
				await db.SaveChangesAsync();

				// 取得新增的會員ID
				var id = member.Id;

				return id;
			}
		}

		public void DeleteMember(int id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 透過ID取得會員資料
		/// </summary>
		/// <param name="id">會員ID</param>
		/// <returns>回傳MemberEntity</returns>
		/// <exception cref="ArgumentNullException">傳入值為Null</exception>
		public async Task<MemberEntity> GetMember(int id)
		{
			// new 出一個Entity Framework的資料模型
			using (var db = new dbTeam1Context(options))
			{
				// 透過ID取得資料
				var member = await db.Members.FindAsync(id);
				// 檢查是否有資料
				if (member == null)
				{
					// 若無資料則傳出錯誤
					throw new ArgumentNullException(nameof(id));
				}
				// 將Entity Framework的資料模型轉換成Entity類別的資料
				var memberEntity = new MemberEntity
				{
					Id = member.Id,
					Account = member.Account,
					EncryptedPassword = member.EncryptedPassword,
					RegistrationDate = member.RegistrationDate,
					ActiveStatus = member.ActiveStatus
				};

				// 回傳Entity類別的資料
				return memberEntity;
			}
		}

		/// <summary>
		/// 透過帳號取得會員資料
		/// </summary>
		/// <param name="account">會員帳號</param>
		/// <returns>回傳MemberEntity</returns>
		public async Task<MemberEntity> GetMember(string account)
		{
			// new 出一個Entity Framework的資料模型
			using (var db = new dbTeam1Context(options))
			{
				// 透過帳號取得資料
				var member = await db.Members.Where(x => x.Account == account).FirstOrDefaultAsync();
				// 檢查是否有資料
				if (member == null)
				{
					// 若無資料則傳出錯誤
					throw new ArgumentNullException(nameof(account));
				}
				// 將Entity Framework的資料模型轉換成Entity類別的資料
				var memberEntity = new MemberEntity
				{
					Id = member.Id,
					Account = member.Account,
					EncryptedPassword = member.EncryptedPassword,
					RegistrationDate = member.RegistrationDate,
					ActiveStatus = member.ActiveStatus
				};
				// 回傳Entity類別的資料
				return memberEntity;
			}
		}

		/// <summary>
		/// 更新會員資料，限制只能更新密碼和帳號狀態
		/// </summary>
		/// <param name="memberEntity"></param>
		/// <exception cref="ArgumentNullException">傳入值為Null</exception>
		/// <exception cref="Exception">更新失敗</exception>"
		public void UpdateMember(MemberEntity memberEntity)
		{
			// 檢查 memberEntity 是否為 null
			if (memberEntity == null)
			{
				throw new ArgumentNullException(nameof(memberEntity));
			}
			// new 出一個Entity Framework的資料模型
			using (var db = new dbTeam1Context(options))
			{
				// 透過ID取得資料
				var member = db.Members.Find(memberEntity.Id);
				// 檢查是否有資料
				if (member == null)
				{
					// 若無資料則傳出錯誤
					throw new ArgumentNullException(nameof(memberEntity.Id));
				}
				// 更新資料
				member.EncryptedPassword = memberEntity.EncryptedPassword;
				member.ActiveStatus = memberEntity.ActiveStatus;
				db.SaveChanges();

				// 檢查是否成功更新
				if (member.EncryptedPassword != memberEntity.EncryptedPassword || member.ActiveStatus != memberEntity.ActiveStatus)
				{
					// 若無資料則傳出錯誤
					throw new Exception("更新失敗，資料未變更");
				}
			}
		}

	}
}
