using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDataContext>();

var app = builder.Build();
app.MapGet("/", () => "API Sítio Arqueológico");



app.MapGet("/api/arqueologo/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.Arqueologos.Any())
    {
        return Results.Ok(ctx.Arqueologos.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/artefato/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.Artefatos.Any())
    {
        return Results.Ok(ctx.Artefatos.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/fossil/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.Fosseis.Any())
    {
        return Results.Ok(ctx.Fosseis.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/paleontologo/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.Paleontologos.Any())
    {
        return Results.Ok(ctx.Paleontologos.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/area-especializacao/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.AreasEspecializacao.Any())
    {
        return Results.Ok(ctx.AreasEspecializacao.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/formacao-academica/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.FormacoesAcademicas.Any())
    {
        return Results.Ok(ctx.FormacoesAcademicas.ToList());
    }
    return Results.NotFound();
});

//GET: /api/arqueologo/buscar/{id}
app.MapGet("/api/arqueologo/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Arqueologo? arqueologo = ctx.Arqueologos.Find(id);
    if (arqueologo is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(arqueologo);
});

app.MapGet("/api/artefato/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Artefato? artefato = ctx.Artefatos.Find(id);
    if (artefato is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(artefato);
});

app.MapGet("/api/fossil/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Fossil? fossil = ctx.Fosseis.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(fossil);
});

app.MapGet("/api/paleontologo/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Paleontologo? paleontologo = ctx.Paleontologos.Find(id);
    if (paleontologo is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(paleontologo);
});

app.MapGet("/api/area-especializacao/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    AreaEspecializacao? areasEspecializacao = ctx.AreasEspecializacao.Find(id);
    if (areasEspecializacao is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(areasEspecializacao);
});

app.MapGet("/api/formacao-academica/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    FormacaoAcademica? formacoesAcademica = ctx.FormacoesAcademicas.Find(id);
    if (formacoesAcademica is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(formacoesAcademica);
});

//POST: /api/produto/cadastrar/param_nome
app.MapPost("/api/artefato/cadastrar", ([FromBody] Artefato artefato, [FromServices] AppDataContext ctx) =>
{
    Arqueologo? arqueologo = ctx.Arqueologos.Find(artefato.ArqueologoId);
    if (arqueologo is null)
    {
        return Results.NotFound();
    }
    artefato.Arqueologo = arqueologo;

    ctx.Artefatos.Add(artefato);
    ctx.SaveChanges();
    // bd
    return Results.Created("", artefato);
});




app.MapPost("/api/fossil/cadastrar", ([FromBody] Fossil fossil, [FromServices] AppDataContext ctx) =>
{
    Paleontologo? paleontologo = ctx.Paleontologos.Find(fossil.PaleontologoId);
    if (paleontologo is null)
    {
        return Results.NotFound();
    }
    fossil.Paleontologo = paleontologo;


    ctx.Fosseis.Add(fossil);
    ctx.SaveChanges();
    return Results.Created("", fossil);
});





app.MapPost("/api/paleontologo/cadastrar", ([FromBody] Paleontologo paleontologo, [FromServices] AppDataContext ctx) =>
{
    AreaEspecializacao? areasEspecializacao = ctx.AreasEspecializacao.Find(paleontologo.AreaEspecializacaoId);
    if (areasEspecializacao is null)
    {
        return Results.NotFound();
    }

    paleontologo.AreaEspecializacao = areasEspecializacao;

    ctx.Paleontologos.Add(paleontologo);
    ctx.SaveChanges();
    return Results.Created("", paleontologo);
});


app.MapPost("/api/arqueologo/cadastrar", ([FromBody] Arqueologo arqueologo, [FromServices] AppDataContext ctx) =>
{
    FormacaoAcademica? formacaoAcademica = ctx.FormacoesAcademicas.Find(arqueologo.FormacaoAcademicaId);
    if (formacaoAcademica is null)
    {
        return Results.NotFound();
    }

    arqueologo.FormacaoAcademica = formacaoAcademica;


    ctx.Arqueologos.Add(arqueologo);
    ctx.SaveChanges();
    return Results.Created("", arqueologo);
});

app.MapPost("/api/area-especializacao/cadastrar", ([FromBody] AreaEspecializacao areasEspecializacao, [FromServices] AppDataContext ctx) =>
{
    ctx.AreasEspecializacao.Add(areasEspecializacao);
    ctx.SaveChanges();
    return Results.Created("", areasEspecializacao);
});


app.MapPost("/api/formacao-academica/cadastrar", ([FromBody] FormacaoAcademica formacaoAcademica, [FromServices] AppDataContext ctx) =>
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
    return Results.Ok(fossil);
});

app.MapDelete("/api/artefato/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Artefato? artefato = ctx.Artefatos.Find(id);
    if (artefato is null)
    {
        return Results.NotFound();
    }
    ctx.Artefatos.Remove(artefato);
    ctx.SaveChanges();
    return Results.Ok(artefato);
});

app.MapDelete("/api/arqueologo/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Arqueologo?  arqueologo = ctx.Arqueologos.Find(id);
    if (arqueologo is null)
    {
        return Results.NotFound();
    }
    ctx.Arqueologos.Remove(arqueologo);
    ctx.SaveChanges();
    return Results.Ok(arqueologo);
});

app.MapDelete("/api/paleontologo/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Paleontologo? paleontologo = ctx.Paleontologos.Find(id);
    if (paleontologo is null)
    {
        return Results.NotFound();
    }
    ctx.Paleontologos.Remove(paleontologo);
    ctx.SaveChanges();
    return Results.Ok(paleontologo);
});

app.MapDelete("/api/area-especializacao/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    AreaEspecializacao? AreaEspecializacao = ctx.AreasEspecializacao.Find(id);
    if (AreaEspecializacao is null)
    {
        return Results.NotFound();
    }
    ctx.AreasEspecializacao.Remove(AreaEspecializacao);
    ctx.SaveChanges();
    return Results.Ok(AreaEspecializacao);
});

app.MapDelete("/api/formacao-academica/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    FormacaoAcademica? formacaoAcademica = ctx.FormacoesAcademicas.Find(id);
    if (formacaoAcademica is null)
    {
        return Results.NotFound();
    }
    ctx.FormacoesAcademicas.Remove(formacaoAcademica);
    ctx.SaveChanges();
    return Results.Ok(formacaoAcademica);
});

//PUT: /api/produto/alterar/{id}
app.MapPut("/api/fossil/alterar/{id}", ([FromRoute] int id,
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
    return Results.Ok(fossil);
});

app.MapPut("/api/artefato/alterar/{id}", ([FromRoute] int id,
    [FromBody] Artefato artefatoAlterada,
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
    return Results.Ok(artefato);
});

app.MapPut("/api/arqueologo/alterar/{id}", ([FromRoute] int id,
    [FromBody] Arqueologo arqueologoAlterada,
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
    return Results.Ok(arqueologo);
});

app.MapPut("/api/paleontologo/alterar/{id}", ([FromRoute] int id,
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
    return Results.Ok(paleontologo);
});

app.MapPut("/api/area-especializacao/alterar/{id}", ([FromRoute] int id,
    [FromBody] AreaEspecializacao areasEspecializacaoAlterada,
    [FromServices] AppDataContext ctx) =>
{
    AreaEspecializacao? areasEspecializacao = ctx.AreasEspecializacao.Find(id);
    if (areasEspecializacao is null)
    {
        return Results.NotFound();
    }
    areasEspecializacao.Nome = areasEspecializacaoAlterada.Nome;
    ctx.AreasEspecializacao.Update(areasEspecializacao);
    ctx.SaveChanges();
    return Results.Ok(areasEspecializacao);
});

app.MapPut("/api/formacao-academica/alterar/{id}", ([FromRoute] int id,
    [FromBody] FormacaoAcademica formacaoAcademicaAlterada,
    [FromServices] AppDataContext ctx) =>
{
    FormacaoAcademica? formacaoAcademica = ctx.FormacoesAcademicas.Find(id);
    if (formacaoAcademica is null)
    {
        return Results.NotFound();
    }
    formacaoAcademica.Universidade = formacaoAcademica.Universidade;
    ctx.FormacoesAcademicas.Update(formacaoAcademica);
    ctx.SaveChanges();
    return Results.Ok(formacaoAcademica);
});

app.Run();