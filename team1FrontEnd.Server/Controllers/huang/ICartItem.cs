namespace team1FrontEnd.Server.Controllers.huang
{
    public interface ICartItem
    {
        int Id { get; }
        string FileName { get; }
        string Name { get; }
        string Detail { get; }
        int Price { get; }
    }
}
