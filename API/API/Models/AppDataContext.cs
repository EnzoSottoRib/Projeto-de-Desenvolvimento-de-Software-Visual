using Microsoft.EntityFrameworkCore;

namespace API.Models;

//Implementar a herança da classe DbContext
public class AppDataContext : DbContext
{
    //Informar quais as classes serão tabelas no banco de dados
    public DbSet<Arqueologo> Arqueologos { get; set; }
    public DbSet<Artefato> Artefatos { get; set; }
    public DbSet<Fossil> Fosseis { get; set; }
    public DbSet<Paleontologo> Paleontologos { get; set; }
    public DbSet<AreaEspecializacao> AreasEspecializacao { get; set; }
    public DbSet<FormacaoAcademica> FormacoesAcademicas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Database.db");
    }

}
