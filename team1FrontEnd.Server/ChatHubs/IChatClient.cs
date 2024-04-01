namespace team1FrontEnd.Server.ChatHubs
{
    public interface IChatClient
    {
        Task SendAll(object message);
    }
}
