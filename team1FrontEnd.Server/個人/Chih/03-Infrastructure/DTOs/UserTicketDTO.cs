namespace team1FrontEnd.Server.個人.Chih._03_Infrastructure.DTOs
{
    public class UserTicketDTO
    {
        public int ItemId {  get; set; } 
        public int AttractionOrderId { get; set; }  
        public string TicketName { get; set; }  
        public string ImgOfQRCode { get; set;}
        public DateTime? CreateTime { get; set;}
        public string TicketImg { get; set;}    
    }
}
