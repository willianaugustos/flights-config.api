using System.Reflection.Metadata;
using System.Text.Json.Serialization;
using Flights.Data.Contexts;
using flights_config.Data.Repositories;
using flights_config.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x =>
   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(flights_config.Domain.Services.SearchFlightsHandler).Assembly);
builder.Services.AddScoped<IAirportsRepository, AirportsRepository>();
builder.Services.AddScoped<IFlightsRepository, FlightsRepository>();
builder.Services.AddDbContext<FlightsContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

