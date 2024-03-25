using myapi._03_Infrastructure.DTOs;

namespace myapi._01_BLL.IBILL
{
    public interface IAttractionTicketService
    {
        Task<IEnumerable<AttractionTicketDTO>> GetTicketContent(int id);


    }
}
