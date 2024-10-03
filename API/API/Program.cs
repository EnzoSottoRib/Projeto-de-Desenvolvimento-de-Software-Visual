//Testar as APIs
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia
//MINIMAL APIs - C# - Minimal APIs

using API.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Lista de itens para simular um banco de dados em memória
List<Item> itens = new List<Item>
{
    new Item { Id = 1, Nome = "Espada de Ferro", Descricao = "Espada usada na Idade Média" },
    new Item { Id = 2, Nome = "Escudo de Bronze", Descricao = "Escudo encontrado em sítios arqueológicos" }
};

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
app.MapGet("/api/item/buscar/{id}", (int id) =>
{
    var item = itens.FirstOrDefault(i => i.Id == id);
    if (item != null)
    {
        return Results.Ok(item);
    }
    return Results.NotFound();
});

//POST: /api/produto/cadastrar/param_nome
app.MapPost("/api/item/cadastrar", (Item newItem) =>
{
    if (newItem != null && !string.IsNullOrEmpty(newItem.Nome))
    {
        newItem.Id = itens.Max(i => i.Id) + 1; // Atribui um novo ID baseado no maior existente
        itens.Add(newItem);
        return Results.Created($"/api/item/buscar/{newItem.Id}", newItem);
    }
    return Results.BadRequest("Nome do item é obrigatório.");
});

//DELETE: /api/produto/deletar/{id}
app.MapDelete("/api/item/deletar/{id}", (int id) =>
{
    var item = itens.FirstOrDefault(i => i.Id == id);
    if (item != null)
    {
        itens.Remove(item);
        return Results.NoContent(); // Código 204: No Content
    }
    return Results.NotFound();
});

//PUT: /api/produto/alterar/{id}
app.MapPut("/api/item/alterar/{id}", (int id, Item updatedItem) =>
{
    var item = itens.FirstOrDefault(i => i.Id == id);
    if (item != null)
    {
        item.Nome = updatedItem.Nome ?? item.Nome;
        item.Descricao = updatedItem.Descricao ?? item.Descricao;
        return Results.Ok(item);
    }
    return Results.NotFound();
});

app.Run();

// Modelo Item
public class Item
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
}