using myapi._03_Infrastructure.DTOs;
using myapi.Models.DTO;

namespace myapi._01_BLL.IDAL
{
    public interface IAttractionRepository
    {
        Task<IEnumerable<AttractionDTO>> GetList(AttractionSearchDTO search);
        Task<IEnumerable<AttractionContentDTO>> GetAttractionContent(int id);

    }
}
