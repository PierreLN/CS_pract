using PhoneContactAPI.Data;
using PhoneContactAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ContactDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
