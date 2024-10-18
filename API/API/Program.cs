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
    if (ctx.TabelaArqueologos.Any())
    {
        return Results.OK(ctx.arqueologos.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/artefato/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.TabelaArtefatos.Any())
    {
        return Results.OK(ctx.arterfatos.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/fossil/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.TabelaFossilsfossil.Any())
    {
        return Results.OK(ctx.fossils.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/paleontologo/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.TabelaPaleontologos.Any())
    {
        return Results.OK(ctx.paleontologos.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/areas de especializacao/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.TabelaAreasEspecializacao.Any())
    {
        return Results.OK(ctx.areasEspecializacao.ToList());
    }
    return Results.NotFound();
});

app.MapGet("/api/formacoes academicas/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.TabelaFormacoesAcademicas.Any())
    {
        return Results.OK(ctx.formacoesAcademicas.ToList());
    }
    return Results.NotFound();
});

//GET: /api/produto/buscar/{id}
app.MapGet("/api/arqueologo/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Arqueologo? arqueologo = ctx.arqueologos.Find(id);
    if (arqueologo is null)
    {
        return Results.NotFound();
    }
    return Results.OK(arqueologo);
});

app.MapGet("/api/artefato/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Artefato? artefato = ctx.artefato.Find(id);
    if (arqueologo is null)
    {
        return Results.NotFound();
    }
    return Results.OK(artefato);
});

app.MapGet("/api/fossil/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Fossil? fossil = ctx.fossil.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    return Results.OK(fossil);
});

app.MapGet("/api/peleontologo/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Peleontologo? peleontologo = ctx.fossil.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    return Results.OK(peleontologo);
});

app.MapGet("/api/area de especialização/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    AreasEspecializacao? areasEspecializacao = ctx.areasEspecializacao.Find(id);
    if (areasEspecializacao is null)
    {
        return Results.NotFound();
    }
    return Results.OK(areasEspecializacao);
});

app.MapGet("/api/formacao academica/buscar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    FormacoesAcademica? formacoesAcademica = ctx.formacoesAcademica.Find(id);
    if (FormacoesAcademicas is null)
    {
        return Results.NotFound();
    }
    return Results.OK(FormacoesAcademica);
});

//POST: /api/produto/cadastrar/param_nome
app.MapPost("/api/artefato/cadastrar", ([FromBody] Artefato artefato, [FromServices] AppDataContext ctx) =>
{
    ctx.TabelaArtefatos.Add(artefato);
    ctx.SaveChanges();
    // bd
    return Results.Created("", artefato);
});

app.MapPost("/api/fossil/cadastrar", ([FromBody] Fossil fossil, [FromServices] AppDataContext ctx) =>
{
    ctx.TabelaFossils.Add(fossil);
    ctx.SaveChanges();
    return Results.Created("", fossil);
});

app.MapPost("/api/paleontologo/cadastrar", ([FromBody] Paleontologo paleontologo, [FromServices] AppDataContext ctx) =>
{
    ctx.TabelaPaleontologo.Add(paleontologo);
    ctx.SaveChanges();
    return Results.Created("", paleontologo);
});

app.MapPost("/api/arqueologo/cadastrar", ([FromBody] Arqueologo arqueologo, [FromServices] AppDataContext ctx) =>
{
    ctx.TabelaArqueologo.Add(arqueologo);
    ctx.SaveChanges();
    return Results.Created("", arqueologo);
});

app.MapPost("/api/area de especialização/cadastrar", ([FromBody] Arqueologo areasEspecializacao, [FromServices] AppDataContext ctx) =>
{
    ctx.TabelaAreasEspecializacao.Add(areasEspecializacao);
    ctx.SaveChanges();
    return Results.Created("", areasEspecializacao);
});

app.MapPost("/api/formacao academica/cadastrar", ([FromBody] Arqueologo formacoesAcademica, [FromServices] AppDataContext ctx) =>
{
    ctx.TabelaFormacoesAcademica.Add(formacoesAcademicas);
    ctx.SaveChanges();
    return Results.Created("", formacoesAcademicas);
});
//DELETE: /api/produto/deletar/{id}
app.MapDelete("/api/fossil/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Fossil? fossil = ctx.Fossil.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    ctx.Fossil.Remove(fossil);
    ctx.SaveChanges();
    return Results.OK(fossil);
});

app.MapDelete("/api/artefato/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Artefato? artefato = ctx.Artefato.Find(id);
    if (artefato is null)
    {
        return Results.NotFound();
    }
    ctx.Fossil.Remove(artefato);
    ctx.SaveChanges();
    return Results.OK(artefato);
});

app.MapDelete("/api/arqueologo/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Arqueologo?  arqueologo = ctx.Arqueologo.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    ctx.Fossil.Remove(arqueologo);
    ctx.SaveChanges();
    return Results.OK(arqueologo);
});

app.MapDelete("/api/paleontologo/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    Paleontologo? paleontologo = ctx.paleontologo.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    ctx.Fossil.Remove(paleontologo);
    ctx.SaveChanges();
    return Results.OK(paleontologo);
});

app.MapDelete("/api/area de especialização/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    AreaEspecializacao? AreaEspecializacao = ctx.AreaEspecializacao.Find(id);
    if (AreaEspecializacao is null)
    {
        return Results.NotFound();
    }
    ctx.AreaEspecializacao.Remove(AreaEspecializacao);
    ctx.SaveChanges();
    return Results.OK(AreaEspecializacao);
});

app.MapDelete("/api/formacao academica/deletar/{id}", ([FromRoute] int id,
    [FromServices] AppDataContext ctx) =>
{
    FormacaoAcademica? paleontologo = ctx.formacoesAcademica.Find(id);
    if (formacoesAcademica is null)
    {
        return Results.NotFound();
    }
    ctx.formacoesAcademica.Remove(formacoesAcademica);
    ctx.SaveChanges();
    return Results.OK(formacoesAcademica);
});

//PUT: /api/produto/alterar/{id}
app.MapPut("/api/fossil/alterar/{id}", ([FromRoute] int id
    [FromBody] Fossil fossilAlterada,
    [FromServices] AppDataContext ctx) =>
{
    Fossil? fossil = ctx.Fossil.Find(id);
    if (fossil is null)
    {
        return Results.NotFound();
    }
    fossil.Nome = fossilAlterada.Nome;
    ctx.Fossil.Update(fossil);
    ctx.SaveChanges();
    return Results.OK(fossil)
});

app.MapPut("/api/artefato/alterar/{id}", ([FromRoute] int id
    [FromBody] Fossil artefatoAlterada,
    [FromServices] AppDataContext ctx) =>
{
    Artefato? artefato = ctx.Artefato.Find(id);
    if (artefato is null)
    {
        return Results.NotFound();
    }
    artefato.Periodo = artefatoAlterada.Periodo;
    ctx.Artefato.Update(artefato);
    ctx.SaveChanges();
    return Results.OK(artefato)
});

app.MapPut("/api/arqueologo/alterar/{id}", ([FromRoute] int id
    [FromBody] Fossil arqueologoAlterada,
    [FromServices] AppDataContext ctx) =>
{
    Arqueologo? arqueologo = ctx.Arqueologo.Find(id);
    if (arqueologo is null)
    {
        return Results.NotFound();
    }
    arqueologo.AnosExperiencia = arqueologoAlterada.AnosExperiencia;
    ctx.Arqueologo.Update(arqueologo);
    ctx.SaveChanges();
    return Results.OK(arqueologo)
});

app.MapPut("/api/paleontologo/alterar/{id}", ([FromRoute] int id
    [FromBody] Paleontologo paleontologoAlterada,
    [FromServices] AppDataContext ctx) =>
{
    Paleontologo? paleontologo = ctx.Paleontologo.Find(id);
    if (paleontologo is null)
    {
        return Results.NotFound();
    }
    paleontologo.IdMatricula = paleontologoAlterada.IdMatricula;
    ctx.Paleontologo.Update(paleontologo);
    ctx.SaveChanges();
    return Results.OK(paleontologo)
});

app.MapPut("/api/area de especialização/alterar/{id}", ([FromRoute] int id
    [FromBody] AreaEspecializacao areasEspecializacaoAlterada,
    [FromServices] AppDataContext ctx) =>
{
    AreaEspecializacao? areasEspecializacao = ctx.AreaEspecializacao.Find(id);
    if (areasEspecializacao is null)
    {
        return Results.NotFound();
    }
    areasEspecializacao.Nome = areasEspecializacaoAlterada.Nome;
    ctx.AreaEspecializacao.Update(areaEspecializacao);
    ctx.SaveChanges();
    return Results.OK(areaEspecializacao)
});

app.MapPut("/api/formacao academica/alterar/{id}", ([FromRoute] int id
    [FromBody] FormacaoAcademica formacoeAcademicaAlterada,
    [FromServices] AppDataContext ctx) =>
{
    FormacaoAcademica? formacoeAcademica = ctx.FormacaoAcademica.Find(id);
    if (formacoeAcademica is null)
    {
        return Results.NotFound();
    }
    formacoeAcademica.Universidade = formacoeAcademica.Universidade;
    ctx.formacoeAcademica.Update(formacoeAcademica);
    ctx.SaveChanges();
    return Results.OK(formacoeAcademica)
});

app.Run();