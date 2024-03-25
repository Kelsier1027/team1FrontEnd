using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using team1FrontEnd.Server.HubClients;
using team1FrontEnd.Server.Hubs;

namespace team1FrontEnd.Server.Controllers
{
	[EnableCors("AllowAny")]
	[Route("api/[controller]")]
	[ApiController]
	public class ClientHubController : ControllerBase
	{
		private readonly ILogger<ClientHubController> _logger;
		public ClientHubController(
			ILogger<ClientHubController> logger
			)
		{
			_logger = logger;
		}
		[HttpGet(Name = "SendMessage")]
		public async Task SendMessage(string date, [FromServices] IHubContext<ChatHub, IChatClient> hubContext)
		{
			await hubContext.Clients.All.SendAll(date);
		}
		// 获取所有的用户
		[HttpGet("GetAllUserIds", Name = "GetAllUserIds")]
		public string[] GetAllUserIds()
		{
			return UserIdsStore.Ids.ToArray();
		}
		/// <summary>
		/// 发送指定的消息给指定的客户端
		/// </summary>
		/// <param name="userid"></param>
		/// <param name="date"></param>
		/// <param name="hubContext"></param>
		/// <returns></returns>
		[HttpGet("SendCustomUserMessage", Name = "SendCustomUserMessage")]
		public async Task<IActionResult> SendCustomUserMessage(string userid,string date,[FromServices] IHubContext<ChatHub, IChatClient> hubContext)
		{
			await hubContext.Clients.Client(userid).SendCustomUserMessage(date);
			return Ok("Send Successful!");
		}
	}
}
