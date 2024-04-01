namespace team1FrontEnd.Server.個人.Chih._03_Infrastructure.DTOs
{
    public class CartItemsDTO
    {
        public int CartId { get; set; }
        public int MemberId { get; set; }
        public List<CartTicketDTO> CartItems { get; set; }
        public decimal Total { get; set; }
    }
}
