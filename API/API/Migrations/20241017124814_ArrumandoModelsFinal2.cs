using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ArrumandoModelsFinal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CriadoEm",
                table: "Paleontologos",
                newName: "AdicionadoEm");

            migrationBuilder.RenameColumn(
                name: "CriadoEm",
                table: "Fosseis",
                newName: "AdicionadoEm");

            migrationBuilder.RenameColumn(
                name: "CriadoEm",
                table: "Artefatos",
                newName: "AdicionadoEm");

            migrationBuilder.RenameColumn(
                name: "CriadoEm",
                table: "Arqueologos",
                newName: "AdicionadoEm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdicionadoEm",
                table: "Paleontologos",
                newName: "CriadoEm");

            migrationBuilder.RenameColumn(
                name: "AdicionadoEm",
                table: "Fosseis",
                newName: "CriadoEm");

            migrationBuilder.RenameColumn(
                name: "AdicionadoEm",
                table: "Artefatos",
                newName: "CriadoEm");

            migrationBuilder.RenameColumn(
                name: "AdicionadoEm",
                table: "Arqueologos",
                newName: "CriadoEm");
        }
    }
}
