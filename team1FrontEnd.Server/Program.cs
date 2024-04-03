using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using myapi._01_BLL.BLL;
using myapi._01_BLL.IBILL;
using myapi._01_BLL.IDAL;
using myapi._02_DAL;
using Swashbuckle.AspNetCore.Filters;
using team1FrontEnd.Server.Auth;
using team1FrontEnd.Server.Hubs;
using team1FrontEnd.Server.HubService;
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Yen.Data;
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

			builder.Services.AddScoped<IAttractionService, AttractionService>();
			builder.Services.AddScoped<IAttractionRepository, AttractionRepository>();
			builder.Services.AddScoped<IAttractionTicketService, AttractionTicketService>();
			builder.Services.AddScoped<IAttractionTicketRepository, AttractionTicketRepository>();

			// 加入DbContext服務
			builder.Services.AddDbContext<dbTeam1Context>(
	options => options.UseSqlServer(
		builder.Configuration.GetConnectionString("dbTeam1Connection")
));
			string http = "https://127.0.0.1";
			string httpPort = "https://127.0.0.1:5173";
            string httpLocal = "https://localhost:5173";
            // CORS policy 設定
            builder.Services.AddCors(options =>
			{
				// 設定為允許跨域請求攜帶cookies ， 接收跨域請求的網址攜帶cookies
				options.AddPolicy("AllowAll",
					builder => builder
						//.AllowAnyOrigin() // 允許任何來源
						// 設定允許跨域請求攜帶cookies
						.WithOrigins(http, httpPort,httpLocal) // 允許跨域請求的網址
						.AllowAnyHeader() // 允許任何標頭
						.AllowAnyMethod() // 允許任何方法
						.WithExposedHeaders("Set-Cookie") // 允許公開標頭
						.AllowCredentials() // 允許cookie，讓瀏覽器可以儲存cookie，並且在跨域請求時發送cookie


						);

			});


			builder.Services.AddDbContext<dbTeam1Context>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("dbTeam1"));
			});
			builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
));

			//string CorsPolicy = "AllowAny";
			//builder.Services.AddCors(options =>
			//{
			//	options.AddPolicy(name: CorsPolicy,
			//		policy =>
			//		{
			//			policy.WithOrigins("*").
			//			WithHeaders("*").
			//			WithMethods("*");
			//		});
			//});

			builder.Services.AddSignalR().
				AddJsonProtocol(options =>
				{
					options.PayloadSerializerOptions.PropertyNamingPolicy = null;
				});
			builder.Services.TryAddSingleton(typeof(CommonService));

			builder.Services.AddMyJWTBearerAuth();

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer(); // 加入API探索服務
			builder.Services.AddSwaggerGen(options =>
			{
				options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
				{
					In = ParameterLocation.Header,
					Name = "Authorization",
					Type = SecuritySchemeType.ApiKey
				});

				options.OperationFilter<SecurityRequirementsOperationFilter>();
			});

			builder.Services.Configure<CookiePolicyOptions>(options =>
			{
				options.MinimumSameSitePolicy = SameSiteMode.None;
				options.HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.None; // 允许跨域请求携带 cookie
				options.Secure = CookieSecurePolicy.Always;

				options.OnAppendCookie = cookieContext =>
				{
					if (cookieContext.CookieName == ".AspNetCore.Identity.Application")
					{
						cookieContext.CookieOptions.SameSite = SameSiteMode.None;
					}
				};
			});

			builder.Services.AddIdentityApiEndpoints<IdentityUser>().AddEntityFrameworkStores<DataContext>();

			var app = builder.Build(); // 建立應用程式

			app.UseDefaultFiles(); // 使用預設檔案
			app.UseStaticFiles(new StaticFileOptions
			{
				FileProvider = new PhysicalFileProvider(
				Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles")),
				RequestPath = "/StaticFiles"
			}); // 使用靜態檔案

			app.MapHub<ChatHub>("/ChatHub", options =>
			{
				options.Transports = HttpTransportType.WebSockets | HttpTransportType.LongPolling;
			});
			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment()) // 如果是開發環境
			{
				app.UseSwagger(); // 使用Swagger
				app.UseSwaggerUI(); // 使用SwaggerUI
			}

			app.UseCors("AllowAll"); // 使用CORS

			// 配置 SameSite 策略
			app.UseCookiePolicy(new CookiePolicyOptions
			{
				MinimumSameSitePolicy = SameSiteMode.None,
				HttpOnly = HttpOnlyPolicy.None, // 為了讓前端可以讀取cookie，所以設定為None
				Secure = CookieSecurePolicy.Always, // CookieSecurePolicy.Always 表示只有在https下才能傳送cookie，如果憑證無效需使用CookieSecurePolicy.None
				OnAppendCookie = cookieContext =>
				{
					if (cookieContext.CookieName == ".AspNetCore.Identity.Application")
					{
						cookieContext.CookieOptions.SameSite = SameSiteMode.None;
					}
				}
			});

			app.MapIdentityApi<IdentityUser>(); // 對應Identity API，使用IdentityUser，用來管理使用者，包括註冊、登入、登出等功能

			//app.UseCors();
			app.UseHttpsRedirection();

			app.UseAuthentication();
			app.UseAuthorization();


			app.MapGet("generatetoken", c => c.Response.WriteAsync(MyJWTBearer.GenerateToken(c))); // MapGet 是用來處理 GET 請求的方法，這裡是用來處理 /generatetoken 請求，並且回傳 MyJWTBearer.GenerateToken(c) 的結果



			app.MapControllers(); // 對應控制器

			app.MapFallbackToFile("/index.html"); // 對應回退檔案

			app.Run(); // 執行應用程式
		}
	}
}
