using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace team1FrontEnd.Server.Auth
{
	public static class MyJWTBearer
	{
		public static readonly SymmetricSecurityKey SecurityKey = new SymmetricSecurityKey(Guid.NewGuid().ToByteArray());
		public static readonly JwtSecurityTokenHandler JwtTokenHandler = new JwtSecurityTokenHandler();
		public static string GenerateToken(HttpContext httpContext)
		{
			// 请求时传入的用户参数为NameIdentifier claim的值
			var claims = new[] { new Claim(ClaimTypes.NameIdentifier, httpContext.Request.Query["user"]) };
			// 签名凭据
			var credentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);
			// 生成JWT Token
			var token = new JwtSecurityToken("SignalRTestServer", "SignalRTests", claims, expires: DateTime.UtcNow.AddSeconds(60), signingCredentials: credentials);
			return JwtTokenHandler.WriteToken(token);
		}
		public static void AddMyJWTBearerAuth(this IServiceCollection services)
		{
			// 添加自定义授权
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddJwtBearer(options =>
				{
					options.TokenValidationParameters =
					new TokenValidationParameters
					{
						LifetimeValidator = (before, expires, token, parameters) => expires > DateTime.UtcNow,
						ValidateAudience = false,
						ValidateIssuer = false,
						ValidateActor = false,
						ValidateLifetime = true,
						IssuerSigningKey = MyJWTBearer.SecurityKey
					};
					options.Events = new JwtBearerEvents
					{
						OnMessageReceived = context =>
						{
							// 当我们收到消息时，去获取请求中的access_token字段
							var accessToken = context.Request.Query["access_token"];
							// 如果没有就去头上找，找到了就放入我们context.token中
							if (!string.IsNullOrEmpty(accessToken))
							{
								context.Token = accessToken;
							}
							return Task.CompletedTask;
						}
					};
				});
		}
	}
}
