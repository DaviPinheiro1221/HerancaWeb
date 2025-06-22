using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using Swashbuckle.AspNetCore.Swagger;


// Program.cs
var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços necessários
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // obrigatório pro Swagger
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configuração do pipeline HTTP

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();
app.MapControllers();

// URL para acessar a API
Console.WriteLine("http://localhost:5000");

app.MapGet("/", context =>
{
    context.Response.Redirect("/menu.html");
    return Task.CompletedTask;
});

app.Run();


