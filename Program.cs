using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using patrickJesusSuprano.Models;
using patrickJesusSuprano.Models.Folha;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapPost("/api/funcionario/cadastrar",
    ([FromBody] Funcionario funcionario,
    [FromServices] AppDbContext ctx) =>
{
    ctx.Funcionarios.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);
});

app.MapGet("/api/funcionario/listar",
    ([FromServices] AppDbContext ctx) =>
{
    if (ctx.Funcionarios.Any())
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound("Tabela vazia!");
});

app.MapPost("/api/folha/cadastrar",
    ([FromBody] Folha folha,
    [FromServices] AppDbContext ctx) =>
{
    ctx.Folhas.Add(folha);
    ctx.SaveChanges();
    return Results.Created("", folha);
});

public calcularIrrf(){
    public double aliquota;

    if((quantidade * valor) < 1903,98){
        aliquota = 0;
    }else if ()
}



app.Run();