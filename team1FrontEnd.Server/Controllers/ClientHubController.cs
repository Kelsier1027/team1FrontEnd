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
		public ClientHubController(ILogger<ClientHubController> logger)
		{
			_logger = logger;
		}
		[HttpGet(Name = "SendMessage")]
		public async Task SendMessage(string date, [FromServices] IHubContext<ChatHub, IChatClient> hubContext)
		{
			await hubContext.Clients.All.SendAll(date);
		}		
	}
}
