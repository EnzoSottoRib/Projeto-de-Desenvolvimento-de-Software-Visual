namespace API.Models;

public class Fossil
{
    public Fossil()
    {
        AdicionadoEm = DateTime.Now;
    }
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? NomeCientifico { get; set; }
    public string? LocalizacaoDescoberta {get; set; }
    public string? TipoFossil {get; set; }
    public string? EspeciaOrganismo {get; set; }
    public string? CondicaoPreservacao {get; set; }
    public string? EpocaGeologica {get; set; }

    // herda de paleontologo
    public int PaleontologoId {get; set; }
    public Paleontologo? Paleontologo {get; set; }

    public DateTime AdicionadoEm { get; set; }


 
}
