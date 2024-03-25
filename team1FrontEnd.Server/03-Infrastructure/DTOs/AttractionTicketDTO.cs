using myapi.Models;

namespace myapi._03_Infrastructure.DTOs
{
    public class AttractionTicketDTO
    {
        public int Id { get; set; }
        public int AttractionId { get; set; }   
        public decimal Price { get; set; }  
        public int Discount { get; set; }   
        public int AttractionTicketTypeId { get; set; }
        public bool TicketStatus { get; set; }  
        public string TicketTitle { get; set;}
        public string TicketDetail { get; set;}
        public List<AttractionTicketStock> AttractionTicketStock { get; set; }  
        public string TicketType { get; set; }  
        
    }
}
