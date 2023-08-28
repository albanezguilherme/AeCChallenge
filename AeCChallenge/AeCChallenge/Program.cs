using AeCChallenge.Core.Interfaces.Repositories;
using AeCChallenge.Core.Interfaces.Services;
using AeCChallenge.Core.Services;
using AeCChallenge.Infrastructure;
using AeCChallenge.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Sinks.MSSqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICityWeatherRepository, CityWeatherRepository>();
builder.Services.AddTransient<IAirportWeatherRepository, AirportWeatherRepository>();
builder.Services.AddTransient<ICityWeatherService, CityWeatherService>();
builder.Services.AddTransient<IAirportWeatherService, AirportWeatherService>();
builder.Services.AddDbContext<AeCChallengeContext>(option => option.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value));

Log.Logger = new LoggerConfiguration()
    .WriteTo
    .MSSqlServer(
        connectionString: builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value,
        sinkOptions: new MSSqlServerSinkOptions { TableName = "LogEvents", AutoCreateSqlTable = true })        
    .CreateLogger();

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
