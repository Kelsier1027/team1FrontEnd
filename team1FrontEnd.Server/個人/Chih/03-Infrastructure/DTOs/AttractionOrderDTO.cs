namespace team1FrontEnd.Server.個人.Chih._03_Infrastructure.DTOs
{
    public class AttractionOrderDTO
    {
        public int UserId { get; set; } 
        public int OrderStatus {  get; set; }   
        public DateTime OrderDate {  get; set; }
        public decimal OrderPrice {  get; set; }    

        public List<AttractionOrderItemsDTO> OrderItem { get; set; }
    }
}
