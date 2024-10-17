using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ArrumandoModels3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AreaEspecializacaoPId",
                table: "Paleontologos",
                newName: "AreaEspecializacaoId");

            migrationBuilder.RenameColumn(
                name: "FormacaoAcademicaAId",
                table: "Arqueologos",
                newName: "FormacaoAcademicaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AreaEspecializacaoId",
                table: "Paleontologos",
                newName: "AreaEspecializacaoPId");

            migrationBuilder.RenameColumn(
                name: "FormacaoAcademicaId",
                table: "Arqueologos",
                newName: "FormacaoAcademicaAId");
        }
    }
}
