using team1FrontEnd.Server.個人.Yen.Models.DTO.Member;

namespace team1FrontEnd.Server.個人.Yen.Interface.IServices.Member
{
	public interface IMemberService
	{
		// 註冊會員
		Task<MemberDto> RegisterMemberAsync(MemberDto memberDto);

		// 會員登入
		Task<MemberDto> LoginMemberAsync(MemberDto memberDto);

		// 取得會員資料
		Task<MemberDto> GetMember(MemberDto memberDto);


		// 更新會員資料
		void UpdatePassword(MemberDto memberDto);

		// 刪除會員
		void DeleteMember(MemberDto memberDto);

		// 驗證帳號是否存在
		Task<bool> IsAccountExistsAsync(string account);

	}
}
