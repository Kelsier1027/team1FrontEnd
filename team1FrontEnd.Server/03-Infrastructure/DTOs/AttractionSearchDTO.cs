using System.ComponentModel.DataAnnotations;

namespace myapi._03_Infrastructure.DTOs
{
    public class AttractionSearchDTO
    {
       
        public string? Keyword { get; set; }
        public int CategoryId { get; set; } 


    }
}
