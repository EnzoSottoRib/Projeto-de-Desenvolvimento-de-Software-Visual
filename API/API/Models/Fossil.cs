namespace API.Models;

public class Fossil
{
    //C# - Contrutor da classe
    public Fossil()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }
    //C# - Atributo com get e set
    public string? Id { get; set; }
    public string? Nome { get; set; }
    public string? NomeCientifico { get; set; }
    public string? LocalizacaoDescoberta {get; set; }
    public string? TipoFossil {get; set; }
    public string? EspeciaOrganismo {get; set; }
    public string? CondicaoPreservacao {get; set; }
    public string? EpocaGeologica {get; set; }
    public DateTime CriadoEm { get; set; }


 
}
