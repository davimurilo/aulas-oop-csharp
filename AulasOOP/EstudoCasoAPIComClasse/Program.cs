using EstudoDeCasoWebClassesPura.DAO;
using EstudoDeCasoWebClassesPura.Interfaces;
using EstudoDeCasoWebClassesPura.Servicos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ContextoGeral>(options => options.UseSqlServer(config.GetConnectionString("conexao")));
builder.Services.AddScoped<IClienteDAO, ClienteDAO>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
