using team1FrontEnd.Server.個人.Yen.Core.Entities;

namespace team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member
{
	public interface IMemberRepository
	{
		// 創建會員
		Task<int> CreateMember(MemberEntity memberEntity);
		// 取得會員資料
		Task<MemberEntity> GetMember(int id);
		// 取得會員資料
		Task<MemberEntity> GetMember(string account);
		// 更新會員資料
		void UpdateMember(MemberEntity memberEntity);
		// 刪除會員資料
		void DeleteMember(int id);
	}
}
