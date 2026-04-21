using FactoryPatttern;
using FactoryPatttern.Controllers;
using FactoryPatttern.Factory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;

services.AddTransient<Ifactory, BookingBusLineFactory>();
services.AddTransient<Ifactory, TrainLineFactory>();
services.AddTransient<IFactoryResolverFinal, FinalFactory>();

services.AddSingleton<IFactoryResolver, FactoryResolver>();

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
