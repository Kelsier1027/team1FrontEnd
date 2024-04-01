using Microsoft.EntityFrameworkCore;
using myapi._01_BLL.IDAL;
using myapi._03_Infrastructure.DTOs;
using myapi._03_Infrastructure.Utilities.Exts;
using myapi.Models;
using myapi.Models.DTO;
using team1FrontEnd.Server.Models;

namespace myapi._02_DAL
{
    public class AttractionRepository : IAttractionRepository
    {
        private readonly dbTeam1Context _context;   
        public AttractionRepository(dbTeam1Context context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<AttractionContentDTO>> GetAttractionContent(int id)
        {
            var attractionContentDTO = await _context.Attractions.AsTracking()
                                                        .Where(c => c.Id == id)
                                                        .Include(c => c.AttractionContentContexts)
                                                        .Include(c => c.AttractionContentImages)
                                                        .Include(c => c.AttractionTickets)
                                                        .Select(c => c.ToAttractionContentDTO())
                                                        .ToListAsync();
            return attractionContentDTO;
        }

        public async Task<IEnumerable<AttractionDTO>> GetList(AttractionSearchDTO search)
        {
            //景點類型篩選
            var attractions = search.CategoryId == 0 ? _context.Attractions : _context.Attractions.Where(a => a.AttractionCategoryId == search.CategoryId);

            attractions = attractions.Include(a => a.AttractionCategory).Include(a => a.AttractionTickets);

            //關鍵字搜尋
            if (!string.IsNullOrEmpty(search.Keyword))
            {
                attractions = attractions.Where(a => a.Name.Contains(search.Keyword) || a.Description.Contains(search.Keyword) || a.AttractionCategory.Name.Contains(search.Keyword));
            }

            //篩選後資料轉為DTO
            var attractionsDTO = await attractions.AsNoTracking()
                                                  .Select(a => a.ToAttractionDTO())
                                                  .ToListAsync();

            return attractionsDTO;










            //var attractions = await _context.Attractions.AsNoTracking().Include(x=>x.AttractionCategory)
            //                                       .Select(x => new AttractionDTO
            //                                       {
            //                                           Id = x.Id,
            //                                           Name = x.Name,
            //                                           Address = x.Address,
            //                                           AttractionCategoryId = x.AttractionCategoryId,
            //                                           CityId = x.CityId,
            //                                           Description = x.Description,
            //                                           MainImage = x.MainImage,
            //                                           AttractionCategoryDTO = new AttractionCategoryDTO
            //                                           {
            //                                               Id = x.AttractionCategory.Id,
            //                                               Name = x.AttractionCategory.Name
            //                                           }
            //                                       }).ToListAsync();


        }
    }
}
