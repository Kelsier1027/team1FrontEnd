namespace team1FrontEnd.Server.Dtos
{
	public interface ICartItem
	{
		int Id { get; }
		string Name { get; }
		int Price { get; }
		string FileName { get; }
	}
	
}
