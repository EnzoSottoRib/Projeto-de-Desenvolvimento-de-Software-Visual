namespace API.Models;

public class Arqueologo
{
    //C# - Construtor da classe
    public Arqueologo()
    {
        AdicionadoEm = DateTime.Now;
    }


    //C# - Atributo com get e set
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public int AnosExperiencia { get; set; }
    public int IdRegistroProfissional { get; set; }
    // herda de FormacaoAcademica
    public int FormacaoAcademicaId { get; set; }
     public FormacaoAcademica FormacaoAcademica { get; set; }
    public DateTime AdicionadoEm { get; set; }


}
