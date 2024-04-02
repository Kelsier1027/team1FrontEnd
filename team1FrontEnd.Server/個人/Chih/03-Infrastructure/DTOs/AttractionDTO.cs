using Microsoft.AspNetCore.Http.HttpResults;
using myapi._03_Infrastructure.DTOs;

namespace myapi.Models.DTO
{
    public class AttractionDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int AttractionCategoryId { get; set; }

        public int CityId { get; set; }

        public string Description { get; set; }

        public string MainImage { get; set; }
        public decimal LowPrice { get; set; }   
        public AttractionCategoryDTO AttractionCategoryDTO { get; set; }
    }
}
