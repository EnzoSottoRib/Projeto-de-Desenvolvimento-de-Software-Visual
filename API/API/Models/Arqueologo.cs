namespace API.Models;

public class Arqueologo
{
    //C# - Contrutor da classe
    public Arqueologo()
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
    public int IdRegistroProfissional { get; set; }
    public DateTime CriadoEm { get; set; }


}
