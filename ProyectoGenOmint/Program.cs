using Negocio;
using ProyectoGenOmint.Models;
using ProyectoGenOmint.Services;
using ProyectoGenOmint.Services.Interface;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPersonaRandomService,PersonaRandomService>();
builder.Services.AddScoped<IUserRandomService, UserRandomService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IPersonaRandomService, PersonaRandomService>();
builder.Services.AddScoped<IUserRandomService, UserRandomService>();
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
