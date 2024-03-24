using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Interface.IRepositories.Member;
using team1FrontEnd.Server.個人.Yen.Repositories.Members;

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

			// Configure Cookie Authentication 設定 Cookie 驗證
			builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(options => // 設定 Cookie 選項
				{
					options.Cookie.HttpOnly = true; // 防止XSS攻擊 (只能透過HTTP傳送Cookie) ， 無法透過JavaScript存取
					options.ExpireTimeSpan = TimeSpan.FromHours(1); // Cookie過期時間 (1小時)
					options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax; // 跨域設定為Lax (Lax: 只有在GET請求時才會傳送Cookie) ，無法透過POST傳送
					options.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.Always; // 安全性設定 (Always: 只有在HTTPS下才會傳送Cookie) ， 無法透過HTTP傳送
					options.SlidingExpiration = true; // 是否滑動過期 (如果為true，則過期時間會延長) ，如果為false，則過期時間不會延長
				});

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer(); // 加入API探索服務
			builder.Services.AddSwaggerGen(); // 加入Swagger服務

			var app = builder.Build(); // 建立應用程式

			app.UseDefaultFiles(); // 使用預設檔案
			app.UseStaticFiles(); // 使用靜態檔案

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment()) // 如果是開發環境
			{
				app.UseSwagger(); // 使用Swagger
				app.UseSwaggerUI(); // 使用SwaggerUI
			}

			app.UseCors("AllowAll"); // 使用CORS

			app.UseHttpsRedirection();  // 使用HTTPS重新導向

			app.UseAuthorization(); // 使用授權

			app.MapControllers(); // 對應控制器

			app.MapFallbackToFile("/index.html"); // 對應回退檔案

			app.Run(); // 執行應用程式
		}
	}
}
