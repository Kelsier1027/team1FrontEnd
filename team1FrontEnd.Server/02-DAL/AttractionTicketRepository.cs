using Microsoft.EntityFrameworkCore;
using myapi._01_BLL.IDAL;
using myapi._03_Infrastructure.DTOs;
using myapi.Models;

namespace myapi._02_DAL
{
    
    public class AttractionTicketRepository : IAttractionTicketRepository
    {
        private readonly dbTeam1Context _dbTeam1Context;
        public AttractionTicketRepository(dbTeam1Context dbTeam1Context)
        {
            _dbTeam1Context = dbTeam1Context;
        }

        public Task<IEnumerable<AttractionTicket>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AttractionTicketDTO>> GetById(int id)
        {
             var result =await _dbTeam1Context.AttractionTickets
                                        .AsNoTracking()
                                        .Where(x=>x.AttractionId == id)
                                        .Include(x=>x.AttractionTicketStocks)
                                        .Select(x => new AttractionTicketDTO
                                        {
                                            Id=x.Id,
                                            AttractionId=x.AttractionId,
                                            Price = x.Price,
                                            Discount = x.Discount,
                                            AttractionTicketTypeId=x.AttractionTicketTypeId,
                                            TicketStatus = x.TicketStatus,
                                            TicketTitle = x.TicketTitle,
                                            TicketDetail = x.TicketDetail,
                                            TicketType = x.AttractionTicketType.Name,
                                            AttractionTicketStock=x.AttractionTicketStocks.Select(s=>new AttractionTicketStock { Stock=s.Stock,ReserveDate=s.ReserveDate}).ToList(),

                                                             
                                        }).ToListAsync();

            return result;
        }
    }
}
