namespace team1FrontEnd.Server.Dtos
{
	public class CartItemDto
	{
		public int Id { get; set; }
		public int CartId { get; set; }
		public int OrderId { get; set; }
		public int ServicerCategoryId { get; set; }
	}
}
