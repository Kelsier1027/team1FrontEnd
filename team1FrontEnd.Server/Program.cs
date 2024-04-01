
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.Extensions.DependencyInjection.Extensions;
using team1FrontEnd.Server.ChatHubs;

namespace team1FrontEnd.Server
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			//¥[¤JsignalR service
            builder.Services
    .AddSignalR()
    .AddJsonProtocol(options => {
        options.PayloadSerializerOptions.PropertyNamingPolicy = null;
    })
    ;
            builder.Services.TryAddSingleton(typeof(CommonService));

            var app = builder.Build();

			app.UseDefaultFiles();
			app.UseStaticFiles();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.MapFallbackToFile("/index.html");

			app.MapHub<ChatHub>("/ChatHub", options =>
			{
				options.Transports = HttpTransportType.WebSockets | HttpTransportType.LongPolling;
			});

			app.Run();
		}
	}
}
