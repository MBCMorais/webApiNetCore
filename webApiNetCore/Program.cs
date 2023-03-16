using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using webApiNetCore.Data;
using webApiNetCore.Models;
using webApiNetCore.Services;
using webApiNetCore.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowOrigin", options => options)
//});

//builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("BookStoreDatabase"));

//builder.Services.AddDbContext<MongoContext>(options => options.UseInMemoryDatabase("BookStoreDatabase"));

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("BookStoreDatabase"));
builder.Services.AddSingleton<MongoContext>();
builder.Services.AddScoped<IDataService, DataService>();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
