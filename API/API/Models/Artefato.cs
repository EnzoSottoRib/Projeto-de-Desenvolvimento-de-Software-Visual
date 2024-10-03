namespace API.Models;

public class Artefato
{
    //C# - Contrutor da classe
    public Artefato()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }
    //C# - Atributo com get e set
    public string? Id { get; set; }
    public string? Nome { get; set; }
    public string? Periodo { get; set; }
    public string? CivilizacaoOrigem { get; set; }
    public string? Funcionalidade { get; set; }
    public string? Dimensao { get; set; }
    public string? Material { get; set; }
    public DateTime CriadoEm { get; set; }

}
