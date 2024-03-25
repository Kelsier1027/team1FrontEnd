namespace team1FrontEnd.Server.HubClients
{
	public interface IChatClient
	{
		Task SendAll(object message);
		Task SendCustomUserMessage(object message);
	}
}
