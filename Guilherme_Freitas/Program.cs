using Microsoft.EntityFrameworkCore;
using Guilherme_Freitas.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ProvaDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();


app.MapControllers();

app.Run();
