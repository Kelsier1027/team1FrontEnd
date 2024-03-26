using myapi._03_Infrastructure.DTOs;
using myapi.Models.DTO;

namespace myapi._01_BLL.IBILL
{
    public interface IAttractionService
    {
        Task<IEnumerable<AttractionDTO>> Search(AttractionSearchDTO search);
        Task<IEnumerable<AttractionContentDTO>> GetAttractionContent(int id);
    }
}
