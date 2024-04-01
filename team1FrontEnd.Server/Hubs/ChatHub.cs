using Microsoft.AspNetCore.SignalR;
using team1FrontEnd.Server.HubClients;
using team1FrontEnd.Server.HubService;


namespace team1FrontEnd.Server.Hubs
{	

	public class ChatHub : Hub<IChatClient>
	{
		ILogger<ChatHub> _logger;
		public ChatHub(ILogger<ChatHub> logger, CommonService common)
		{
			_logger = logger;
			_common = common;
		}
		readonly CommonService _common;
		/// <summary>
		/// 客户端连接服务端
		/// </summary>
		/// <returns></returns>
		public override Task OnConnectedAsync()
		{
			var id = Context.ConnectionId;
			_logger.LogInformation($"Client ConnectionId=> [[{id}]] Already Connection Server！");
			return base.OnConnectedAsync();
		}
		/// <summary>
		/// 客户端断开连接
		/// </summary>
		/// <param name="exception"></param>
		/// <returns></returns>
		public override Task OnDisconnectedAsync(Exception exception)
		{
			var id = Context.ConnectionId;
			_logger.LogInformation($"Client ConnectionId=> [[{id}]] Already Close Connection Server!");
			return base.OnDisconnectedAsync(exception);
		}
		/**
		 * 测试 
		 * */
		/// <summary>
		/// 给所有客户端发送消息
		/// </summary>
		/// <returns></returns>
		public async Task SendMessage(string data)
		{
			Console.WriteLine("Have one Data!");
			await Clients.All.SendAll(_common.SendAll(data));
			await Clients.Caller.SendAll(_common.SendCaller());
		}

	}
}
