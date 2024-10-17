namespace API.Models;

public class Artefato
{
    //C# - Contrutor da classe
    public Artefato()
    {
        AdicionadoEm = DateTime.Now;
    }
    //C# - Atributo com get e set
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Periodo { get; set; }
    public string? CivilizacaoOrigem { get; set; }
    public string? Funcionalidade { get; set; }
    public string? Dimensao { get; set; }
    public string? Material { get; set; }
    public DateTime AdicionadoEm { get; set; }

}
