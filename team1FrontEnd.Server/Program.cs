using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member;
using team1FrontEnd.Server.個人.Yen.Repositories.Members;

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
			builder.Services.AddControllers(); // 加入Controller服務

			// 加入MemberRepository服務
			builder.Services.AddScoped<IMemberRepository, MemberEFRepository>();

			// 加入DbContext服務
			builder.Services.AddDbContext<dbTeam1Context>(
	options => options.UseSqlServer(
		builder.Configuration.GetConnectionString("dbTeam1Connection")
));

			// CORS policy 設定
			builder.Services.AddCors(options =>
			{
				options.AddPolicy("AllowAll",
					builder => builder
						.AllowAnyOrigin() // 允許任何來源
						.AllowAnyHeader() // 允許任何標頭
						.AllowAnyMethod() // 允許任何方法
						.WithExposedHeaders("Set-Cookie") // 允許公開標頭
						);

			});

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
			builder.Services.AddEndpointsApiExplorer(); // 加入API探索服務
			builder.Services.AddSwaggerGen(); // 加入Swagger服務

			var app = builder.Build(); // 建立應用程式

			app.UseDefaultFiles(); // 使用預設檔案
			app.UseStaticFiles(); // 使用靜態檔案

			app.MapHub<ChatHub>("/ChatHub", options => {
				options.Transports = HttpTransportType.WebSockets | HttpTransportType.LongPolling;
			});
			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment()) // 如果是開發環境
			{
				app.UseSwagger(); // 使用Swagger
				app.UseSwaggerUI(); // 使用SwaggerUI
			}

			app.UseCors("AllowAll"); // 使用CORS

			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}
			//app.UseCors();
			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.UseAuthentication();
			app.UseAuthorization();

			// 授权路径			
			app.MapGet("generatetoken", c => c.Response.WriteAsync(MyJWTBearer.GenerateToken(c)));

			app.MapControllers(); // 對應控制器

			app.MapFallbackToFile("/index.html"); // 對應回退檔案

			app.Run(); // 執行應用程式
		}
	}
}
