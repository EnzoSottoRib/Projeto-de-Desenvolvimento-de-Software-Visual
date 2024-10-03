//Testar as APIs
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia
//MINIMAL APIs - C# - Minimal APIs

using API.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//EndPoints - Funcionalidades
//Request - Configurar a URL e o método/verbo HTTP
//Reponse - Retornar os dados (json/xml) e códigos de status HTTP
app.MapGet("/", () => "API Sítio Arqueológico");

//GET: /api/produto/listar
app.MapGet("/api/item/listar", () => {
    if (itens.Count > 0){
        return Results.Ok(itens);
    }
    return Results.NotFound();
});

//GET: /api/produto/buscar/{id}


//POST: /api/produto/cadastrar/param_nome


//DELETE: /api/produto/deletar/{id}


//PUT: /api/produto/alterar/{id}



app.Run();