namespace API.Models;

public class Artefato
{
    public Artefato()
    {
        AdicionadoEm = DateTime.Now;
    }
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Periodo { get; set; }
    public string? CivilizacaoOrigem { get; set; }
    public string? Funcionalidade { get; set; }
    public string? Dimensao { get; set; }
    public string? Material { get; set; }

    // herda de arqueologo
    public int ArqueologoId { get; set; }
    public Arqueologo? Arqueologo {get; set; }

    public DateTime AdicionadoEm { get; set; }

}
