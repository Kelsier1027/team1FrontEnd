namespace team1FrontEnd.Server.ChatHubs
{
    public class CommonService
    {
        internal object SendAll(string data)
        {
            return $"Hello{new Random().Next(0, 100)}";
        }
    }
}
