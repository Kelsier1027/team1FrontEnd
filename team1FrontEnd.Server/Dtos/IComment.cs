namespace team1FrontEnd.Server.Dtos
{
	public interface ICartItem
	{
		int Id { get; }
		string FileName { get; }
		string Name { get; }
		int Price { get; }
		int Quantity { get; }


	}
	
}
