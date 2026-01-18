using Application.Interfaces;
using Infrastructure.Factories;
using Infrastructure.Providers;
using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPaymentProviderFactory, PaymentProviderFactory>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<MockPayProvider>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();








//Domain'i applicationa ekledik ,
//Applicaton insfrastructure'a ekledik.
//Infrastructure'u API'ye ekledik.

