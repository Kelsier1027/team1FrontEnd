using Microsoft.AspNetCore.SignalR;

namespace team1FrontEnd.Server.ChatHubs
{
    public class ChatHub:Hub<IChatClient>
    {
        ILogger<ChatHub> _logger;
        public ChatHub(ILogger<ChatHub> logger, CommonService commonService)
        {
            _logger = logger;
            _commonService = commonService;
        }

        readonly CommonService _commonService;
        /// <summary>
        /// 客户端连接服务端
        /// </summary>
        /// <returns></returns>
        public override Task OnConnectedAsync()
        {
            var id = Context.ConnectionId;
            _logger.LogInformation($"Client ConnectionId=>[[{id}]] connected");
            return base.OnConnectedAsync(); 
        }

        /// <summary>
        /// 客户端断开连接
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public override Task OnDisconnectedAsync(Exception exception)
        {
            var id= Context.ConnectionId;
            _logger.LogInformation($"{id} closed the server");
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
            Console.WriteLine("Got data");
            await Clients.All.SendAll(_commonService.SendAll(data));
        }
    }
}
