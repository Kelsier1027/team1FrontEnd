using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using myapi._01_BLL.BLL;
using myapi._01_BLL.IBILL;
using myapi._01_BLL.IDAL;
using myapi._02_DAL;
using myapi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<dbTeam1Context>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("TripAll"));
});
builder.Services.AddControllers();
//DIµù¥U
builder.Services.AddScoped<IAttractionService, AttractionService>();
builder.Services.AddScoped<IAttractionRepository, AttractionRepository>();
builder.Services.AddScoped<IAttractionTicketService, AttractionTicketService>();
builder.Services.AddScoped<IAttractionTicketRepository, AttractionTicketRepository>();  



builder.Services.AddCors(option =>
{
    option.AddPolicy("AllowAll",builder=>builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");  
app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles")),
    RequestPath= "/StaticFiles"
});
app.UseAuthorization();

app.MapControllers();

app.Run();
