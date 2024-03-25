using myapi._01_BLL.IBILL;
using myapi._01_BLL.IDAL;
using myapi._03_Infrastructure.DTOs;

namespace myapi._01_BLL.BLL
{
    public class AttractionTicketService : IAttractionTicketService
    {
        private readonly IAttractionTicketRepository _repo;

        public AttractionTicketService(IAttractionTicketRepository repo)
        {
            _repo = repo;   
        }
        public Task<IEnumerable<AttractionTicketDTO>> GetTicketContent(int id)
        {
            return _repo.GetById(id);
        }

    }
}
