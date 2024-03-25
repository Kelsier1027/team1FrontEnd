using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Core.Entities.Members;
using team1FrontEnd.Server.個人.Yen.Exts.Members;
using team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member;
using team1FrontEnd.Server.個人.Yen.Models.DTO.Members;

namespace team1FrontEnd.Server.個人.Yen.Repositories.Members
{
	public class MemberProfileEFRepository : IMemberProfileRepository
	{
		private dbTeam1Context _context;

		public MemberProfileEFRepository(dbTeam1Context context)
		{
			_context = context;
		}

		/// <summary>
		/// 取得會員資料
		/// </summary>
		/// <param name="memberId"></param>
		/// <returns></returns>
		public async Task<MemberProfileDto> GetMemberProfilesAsync(int memberId)
		{
			// 根據 memberId 取得 MemberProfileEntity
			var memberProfileDb = await _context.MemberProfiles.FirstOrDefaultAsync(x => x.MemberId == memberId);

			// 檢查 memberProfileDb 是否為 null
			if (memberProfileDb == null)
			{
				throw new Exception("無此會員資料");
			}
			//將 memberProfileDb 轉換成 MemberProfileEntity
			var MemberProfileEntity = memberProfileDb.ToMemberProfileEntity();

			// 將 MemberProfileEntity 轉換成 MemberProfileDto
			var memberProfileDto = MemberProfileEntity.ToMemberPorfileDto();

			return memberProfileDto;

		}

		// 更新會員資料
		public async Task<MemberProfileDto> UpdateMemberProfileAsync(MemberProfileEntity memberProfileEntity)
		{
			// 根據 memberId 取得 MemberProfileEntity
			var memberProfileEFModel = await _context.MemberProfiles.FirstOrDefaultAsync(x => x.MemberId == memberProfileEntity.MemberId);

			// 檢查 memberProfileEFModel 是否為 null， 若為 null 則傳出錯誤
			if (memberProfileEFModel == null)
			{
				throw new Exception("無此會員資料");
			}

			// 更新資料
			memberProfileEFModel.MemberId = memberProfileEntity.MemberId;
			memberProfileEFModel.Email = memberProfileEntity.Email;
			memberProfileEFModel.ProfileImage = memberProfileEntity.ProfileImage;
			memberProfileEFModel.Country = memberProfileEntity.Country;
			memberProfileEFModel.DateOfBirth = memberProfileEntity.DateOfBirth;
			memberProfileEFModel.Gender = memberProfileEntity.Gender;
			memberProfileEFModel.PhoneNumber = memberProfileEntity.PhoneNumber;
			memberProfileEFModel.DialCode = memberProfileEntity.DialCode;

			// 儲存資料
			await _context.SaveChangesAsync();

			// 將 memberProfileEFModel 轉換成 MemberProfileEntity
			var memberProfileEntityFromDb = memberProfileEFModel.ToMemberProfileEntity();

			// 將 MemberProfileEntity 轉換成 MemberProfileDto
			var memberProfileDto = memberProfileEntity.ToMemberPorfileDto();

			// 回傳 MemberProfileDto
			return memberProfileDto;
		}


	}
}