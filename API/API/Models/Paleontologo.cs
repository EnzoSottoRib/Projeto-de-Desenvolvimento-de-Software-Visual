namespace API.Models;

public class Paleontologo
{
    //C# - Contrutor da classe
    public Paleontologo()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    //C# - Atributo com get e set
    public string? Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public int AnosExperiencia { get; set; }
    public string? AreaEspecializacao { get; set; }
    public int IdMatricula { get; set; }
    public DateTime CriadoEm { get; set; }

}
