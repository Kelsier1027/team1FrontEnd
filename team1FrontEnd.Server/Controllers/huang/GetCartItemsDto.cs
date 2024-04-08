

namespace team1FrontEnd.Server.Controllers.huang
{
    public class GetCartItemsDto
    {
        public int Id { get; set; }
        public int quantity { get; set; }
        public bool selected { get; set; }
        public ICartItem cartItem { get; set; }
    }
}
