using myapi._03_Infrastructure.DTOs;
using myapi.Models;

namespace myapi._01_BLL.IDAL
{
    public interface IAttractionTicketRepository
    {
        Task<IEnumerable<AttractionTicket>> GetAll();
        Task<IEnumerable<AttractionTicketDTO>> GetById(int id);
    }
}
