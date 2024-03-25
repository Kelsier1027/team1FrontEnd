using team1FrontEnd.Server.個人.Yen.Core.Entities.Members;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;

namespace team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member
{
	public interface IMemberRepository
	{
		// 創建會員
		Task<int> CreateMemberAsync(MemberEntity memberEntity);
		// 取得會員資料
		Task<MemberDto> GetMembersAsync(int id);
		// 取得會員資料
		Task<MemberDto> GetMembersAsync(string account);
		// 更新會員密碼
		void UpdateMember(MemberEntity memberEntity);
		// 刪除會員資料
		void DeleteMember(int id);
		// 更新會員資料
		Task<MemberDto> UpdateMemberInfoAsync(MemberEntity memberEntity);
	}
}
