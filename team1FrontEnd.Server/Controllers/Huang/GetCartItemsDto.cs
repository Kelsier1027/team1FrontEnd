namespace team1FrontEnd.Server.Controllers.Huang
{
	public class GetCartItemsDto
	{
		public int Id { get; set; }
		public int quantity { get; set; }
		public ICartItem cartItem { get; set; }
	}
}
