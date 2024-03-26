using team1FrontEnd.Server.個人.Yen.Exts.Members;
using team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member;
using team1FrontEnd.Server.個人.Yen.Interface.IServices.Member;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;

namespace team1FrontEnd.Server.個人.Yen.Services.Menber
{
	internal class MemberProfileService : IMemberProfileService
	{
		private IMemberProfileRepository _memberProfileRepository;
		private IMemberRepository _memberRepository;



		public MemberProfileService(IMemberProfileRepository memberProfileRepository, IMemberRepository memberRepository)
		{
			_memberProfileRepository = memberProfileRepository;
			_memberRepository = memberRepository;
		}

		/// <summary>
		/// 取得會員資料
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public async Task<MemberProfileDto> GetMemberProfileAsync(int id)
		{
			// 取出資料庫中的 MemberProfiles 資料
			var memberProfileDto = await _memberProfileRepository.GetMemberProfilesAsync(id);

			// 取出資料庫中的 Members 資料
			var memberDto = await _memberRepository.GetMembersAsync(id);

			var memberProfileDtoFromMember = memberDto.ToMemberProfileDto();

			// 將兩個 MemberProfileDto 合併
			memberProfileDto = memberProfileDto.Merge(memberProfileDtoFromMember);

			return memberProfileDto;
		}

		public async Task<MemberProfileDto> UpdateMemberProfileAsync(MemberProfileDto memberProfileDto)
		{
			// 檢查是否有此會員
			var memberDto = await _memberRepository.GetMembersAsync(memberProfileDto.MemberId);

			if (memberDto == null)
			{
				throw new Exception("無此會員");
			}

			// 檢查是否有此會員資料
			var memberProfileDtoFromDb = await _memberProfileRepository.GetMemberProfilesAsync(memberProfileDto.MemberId);

			if (memberProfileDtoFromDb == null)
			{
				throw new Exception("無此會員資料");
			}

			// 只取出 MemberId FirstName LastName ， 並存入 MemberDto
			var memberDtoFromMemberProfile = new MemberDto
			{
				Id = memberProfileDto.MemberId,
				FirstName = memberProfileDto.FirstName,
				LastName = memberProfileDto.LastName
			};

			// 將 MemberProfileDto 轉為 MemberProfileEntity
			var memberProfileEntity = memberProfileDto.ToMemberProfileEntity();

			// 將 memberDtoFromMemberProfile 轉為 MemberEntity
			var memberEntity = memberDtoFromMemberProfile.TomMemberEntity();

			// 更新 MemberProfile 中的會員資料
			var updatedMemberProfileDto = await _memberProfileRepository.UpdateMemberProfileAsync(memberProfileEntity);

			// 更新 Members 中的會員資料
			var updatedMemberDto = await _memberRepository.UpdateMemberInfoAsync(memberEntity);

			// 將 updatedMemberProfileDto 轉為 MemberProfileDto
			var updatedMemberProfileDtoFromMember = updatedMemberDto.ToMemberProfileDto();

			// 將 updatedMemberProfileDto 及 updatedMemberProfileDtoFromMember 合併
			updatedMemberProfileDto = updatedMemberProfileDto.Merge(updatedMemberProfileDtoFromMember);

			return updatedMemberProfileDto;
		}
	}
}