using API.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "API Sítio Arqueológico");

//GET: /api/produto/listar
app.MapGet("/api/arqueologo/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.Arqueologos.Any())
    {
        return Results.OK(ctx.Arqueologos.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/artefato/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.Artefatos.Any())
    {
        return Results.OK(ctx.Arterfatos.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/fossil/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.Fosseis.Any())
    {
        return Results.OK(ctx.Fosseis.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/paleontologo/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.Paleontologos.Any())
    {
        return Results.OK(ctx.Paleontologos.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/area de especialização/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.AreasEspecializacao.Any())
    {
        return Results.OK(ctx.AreasEspecializacao.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/formacoes academicas/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.FormacoesAcademicas.Any())
    {
        return Results.OK(ctx.FormacoesAcademicas.ToList());
    }
    return Results.NotFound();
});

//GET: /api/produto/buscar/{id}
app.MapGet("/api/arqueologo/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Arqueologo? arqueologo = ctx.Arqueologos.Find(id);
    if (arqueologo is null)
    {
        return Results.NotFound();
    }
    return Results.OK(arqueologo);
});

app.MapGet("/api/artefato/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Artefato? artefato = ctx.Artefatos.Find(id);
    if (artefato is null)
    {
        return Results.NotFound();
    }
    return Results.OK(artefato);
});

app.MapGet("/api/fossil/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Fossil? fossil = ctx.Fosseis.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    return Results.OK(fossil);
});

app.MapGet("/api/peleontologo/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Peleontologo? peleontologo = ctx.Paleontologos.Find(id);
    if (paleontologo is null)
    {
        return Results.NotFound();
    }
    return Results.OK(peleontologo);
});

app.MapGet("/api/area de especialização/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    AreasEspecializacao? areasEspecializacao = ctx.AreasEspecializacao.Find(id);
    if (areasEspecializacao is null)
    {
        return Results.NotFound();
    }
    return Results.OK(areasEspecializacao);
});

app.MapGet("/api/formacao academica/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    FormacaoAcademica? formacaoAcademica = ctx.FormacoesAcademicas.Find(id);
    if (formacaoAcademica is null)
    {
        return Results.NotFound();
    }
    return Results.OK(formacaoAcademica);
});

//POST: /api/produto/cadastrar/param_nome
app.MapPost("/api/artefato/cadastrar", ([FromBody] Artefato artefato, [FromServices] AppDataContext ctx) =>
{
    ctx.Artefatos.Add(artefato);
    ctx.SaveChanges();
    // bd
    return Results.Created("", artefato);
});

app.MapPost("/api/fossil/cadastrar", ([FromBody] Fossil fossil, [FromServices] AppDataContext ctx) =>
{
    ctx.Fosseis.Add(fossil);
    ctx.SaveChanges();
    return Results.Created("", fossil);
});

app.MapPost("/api/paleontologo/cadastrar", ([FromBody] Paleontologo paleontologo, [FromServices] AppDataContext ctx) =>
{
    ctx.Paleontologos.Add(paleontologo);
    ctx.SaveChanges();
    return Results.Created("", paleontologo);
});

app.MapPost("/api/arqueologo/cadastrar", ([FromBody] Arqueologo arqueologo, [FromServices] AppDataContext ctx) =>
{
    ctx.Arqueologos.Add(arqueologo);
    ctx.SaveChanges();
    return Results.Created("", arqueologo);
});

app.MapPost("/api/area de especialização/cadastrar", ([FromBody] Arqueologo areaEspecializacao, [FromServices] AppDataContext ctx) =>
{
    ctx.AreasEspecializacao.Add(areaEspecializacao);
    ctx.SaveChanges();
    return Results.Created("", areaEspecializacao);
});

app.MapPost("/api/formacao academica/cadastrar", ([FromBody] Arqueologo formacaoAcademica, [FromServices] AppDataContext ctx) =>
{
    ctx.FormacoesAcademicas.Add(formacaoAcademica);
    ctx.SaveChanges();
    return Results.Created("", formacaoAcademica);
});
//DELETE: /api/produto/deletar/{id}
app.MapDelete("/api/fossil/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Fossil? fossil = ctx.Fosseis.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    ctx.Fosseis.Remove(fossil);
    ctx.SaveChanges();
    return Results.OK(fossil);
});

app.MapDelete("/api/artefato/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Artefato? artefato = ctx.Arterfatos.Find(id);
    if (artefato is null)
    {
        return Results.NotFound();
    }
    ctx.Artefatos.Remove(artefato);
    ctx.SaveChanges();
    return Results.OK(artefato);
});

app.MapDelete("/api/arqueologo/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Arqueologo?  arqueologo = ctx.Arqueologos.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    ctx.Arqueologos.Remove(arqueologo);
    ctx.SaveChanges();
    return Results.OK(arqueologo);
});

app.MapDelete("/api/paleontologo/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Paleontologo? paleontologo = ctx.Paleontologos.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    ctx.Paleontologos.Remove(paleontologo);
    ctx.SaveChanges();
    return Results.OK(paleontologo);
});

app.MapDelete("/api/area de especialização/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    AreaEspecializacao? AreaEspecializacao = ctx.AreasEspecializacao.Find(id);
    if (areaEspecializacao is null)
    {
        return Results.NotFound();
    }
    ctx.AreasEspecializacao.Remove(areaEspecializacao);
    ctx.SaveChanges();
    return Results.OK(areaEspecializacao);
});

app.MapDelete("/api/formacao academica/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    FormacaoAcademica? paleontologo = ctx.FormacoesAcademicas.Find(id);
    if (formacoesAcademica is null)
    {
        return Results.NotFound();
    }
    ctx.FormacoesAcademicas.Remove(formacaoAcademica);
    ctx.SaveChanges();
    return Results.OK(formacaoAcademica);
});

//PUT: /api/produto/alterar/{id}
app.MapPut("/api/fossil/alterar/{id}", ([FromRoute] int id
    [FromBody] Fossil fossilAlterada,
    [FromServices] AppDataContext ctx) =>
{
    Fossil? fossil = ctx.Fosseis.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    fossil.Nome = fossilAlterada.Nome;
    ctx.Fosseis.Update(fossil);
    ctx.SaveChanges();
    return Results.OK(fossil)
});

app.MapPut("/api/artefato/alterar/{id}", ([FromRoute] int id
    [FromBody] Fossil artefatoAlterada,
    [FromServices] AppDataContext ctx) =>
{
    Artefato? artefato = ctx.Artefatos.Find(id);
    if (artefato is null)
    {
        return Results.NotFound();
    }
    artefato.Periodo = artefatoAlterada.Periodo;
    ctx.Artefatos.Update(artefato);
    ctx.SaveChanges();
    return Results.OK(artefato)
});

app.MapPut("/api/arqueologo/alterar/{id}", ([FromRoute] int id
    [FromBody] Fossil arqueologoAlterada,
    [FromServices] AppDataContext ctx) =>
{
    Arqueologo? arqueologo = ctx.Arqueologos.Find(id);
    if (arqueologo is null)
    {
        return Results.NotFound();
    }
    arqueologo.AnosExperiencia = arqueologoAlterada.AnosExperiencia;
    ctx.Arqueologos.Update(arqueologo);
    ctx.SaveChanges();
    return Results.OK(arqueologo)
});

app.MapPut("/api/paleontologo/alterar/{id}", ([FromRoute] int id
    [FromBody] Paleontologo paleontologoAlterada,
    [FromServices] AppDataContext ctx) =>
{
    Paleontologo? paleontologo = ctx.Paleontologos.Find(id);
    if (paleontologo is null)
    {
        return Results.NotFound();
    }
    paleontologo.IdMatricula = paleontologoAlterada.IdMatricula;
    ctx.Paleontologos.Update(paleontologo);
    ctx.SaveChanges();
    return Results.OK(paleontologo)
});

app.MapPut("/api/area de especialização/alterar/{id}", ([FromRoute] int id
    [FromBody] AreaEspecializacao areaEspecializacaoAlterada,
    [FromServices] AppDataContext ctx) =>
{
    AreaEspecializacao? areaEspecializacao = ctx.AreasEspecializacao.Find(id);
    if (areaEspecializacao is null)
    {
        return Results.NotFound();
    }
    areaEspecializacao.Nome = areasEspecializacaoAlterada.Nome;
    ctx.AreasEspecializacao.Update(areaEspecializacao);
    ctx.SaveChanges();
    return Results.OK(areaEspecializacao)
});

app.MapPut("/api/formacao academica/alterar/{id}", ([FromRoute] int id
    [FromBody] FormacaoAcademica formacaoAcademicaAlterada,
    [FromServices] AppDataContext ctx) =>
{
    FormacaoAcademica? formacaoAcademica = ctx.FormacoesAcademicas.Find(id);
    if (formacoeAcademica is null)
    {
        return Results.NotFound();
    }
    formacoeAcademica.Universidade = formacaoAcademica.Universidade;
    ctx.FormacoesAcademicas.Update(formacaoAcademica);
    ctx.SaveChanges();
    return Results.OK(formacaoAcademica)
});

app.Run();