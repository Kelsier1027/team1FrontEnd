
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using team1FrontEnd.Server.Auth;
using team1FrontEnd.Server.Hubs;
using team1FrontEnd.Server.HubService;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddDbContext<dbTeam1Context>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("dbTeam1"));
			});

			string CorsPolicy = "AllowAny";
			builder.Services.AddCors(options => {
				options.AddPolicy(name: CorsPolicy,
					policy =>
					{
						policy.WithOrigins("*").
						WithHeaders("*").
						WithMethods("*");
					});
			});

			builder.Services.AddSignalR().
				AddJsonProtocol(options =>
				{
					options.PayloadSerializerOptions.PropertyNamingPolicy = null;
				});
			builder.Services.TryAddSingleton(typeof(CommonService));

			builder.Services.AddMyJWTBearerAuth();

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			app.UseDefaultFiles();
			app.UseStaticFiles();

			app.MapHub<ChatHub>("/ChatHub", options => {
				options.Transports = HttpTransportType.WebSockets | HttpTransportType.LongPolling;
			});
			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}
			app.UseCors();
			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.UseAuthentication();
			app.UseAuthorization();

			// 授权路径			
			app.MapGet("generatetoken", c => c.Response.WriteAsync(MyJWTBearer.GenerateToken(c)));

			app.MapControllers();

			app.MapFallbackToFile("/index.html");

			app.Run();
		}
	}
}
