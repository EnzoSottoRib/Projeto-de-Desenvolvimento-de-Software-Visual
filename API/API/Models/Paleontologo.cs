namespace API.Models;

public class Paleontologo
{
    //C# - Contrutor da classe
    public Paleontologo()
    {
        AdicionadoEm = DateTime.Now;
    }

    //C# - Atributo com get e set
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? DataNascimento { get; set; }
    public int AnosExperiencia { get; set; }

    // herda de AreaEspecializacao
    public int AreaEspecializacaoId { get; set; }
    public AreaEspecializacao? AreaEspecializacao { get; set; }
    public int IdMatricula { get; set; }
    public DateTime AdicionadoEm { get; set; }

}
