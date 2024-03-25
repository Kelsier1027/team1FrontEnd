using myapi._01_BLL.IBILL;
using myapi._01_BLL.IDAL;
using myapi._03_Infrastructure.DTOs;
using myapi.Models.DTO;

namespace myapi._01_BLL.BLL
{
    public class AttractionService : IAttractionService
    {
        private readonly IAttractionRepository _repo;
        public AttractionService(IAttractionRepository repo) {  _repo = repo; }

        public Task<IEnumerable<AttractionContentDTO>> GetAttractionContent(int id)
        {
            return _repo.GetAttractionContent(id);
        }

        public Task<IEnumerable<AttractionDTO>> Search(AttractionSearchDTO search)
        {
            return _repo.GetList(search);
        }
    }
}
