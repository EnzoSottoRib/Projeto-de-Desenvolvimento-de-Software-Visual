using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arqueologos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AnosExperiencia = table.Column<int>(type: "INTEGER", nullable: false),
                    IdRegistroProfissional = table.Column<int>(type: "INTEGER", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arqueologos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artefatos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Periodo = table.Column<string>(type: "TEXT", nullable: true),
                    CivilizacaoOrigem = table.Column<string>(type: "TEXT", nullable: true),
                    Funcionalidade = table.Column<string>(type: "TEXT", nullable: true),
                    Dimensao = table.Column<string>(type: "TEXT", nullable: true),
                    Material = table.Column<string>(type: "TEXT", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artefatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fosseis",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    NomeCientifico = table.Column<string>(type: "TEXT", nullable: true),
                    LocalizacaoDescoberta = table.Column<string>(type: "TEXT", nullable: true),
                    TipoFossil = table.Column<string>(type: "TEXT", nullable: true),
                    EspeciaOrganismo = table.Column<string>(type: "TEXT", nullable: true),
                    CondicaoPreservacao = table.Column<string>(type: "TEXT", nullable: true),
                    EpocaGeologica = table.Column<string>(type: "TEXT", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fosseis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paleontologos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AnosExperiencia = table.Column<int>(type: "INTEGER", nullable: false),
                    AreaEspecializacao = table.Column<string>(type: "TEXT", nullable: true),
                    IdMatricula = table.Column<int>(type: "INTEGER", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paleontologos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arqueologos");

            migrationBuilder.DropTable(
                name: "Artefatos");

            migrationBuilder.DropTable(
                name: "Fosseis");

            migrationBuilder.DropTable(
                name: "Paleontologos");
        }
    }
}
