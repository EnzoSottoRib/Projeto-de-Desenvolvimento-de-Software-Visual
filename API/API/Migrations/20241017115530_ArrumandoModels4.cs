using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ArrumandoModels4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Paleontologos_AreaEspecializacaoId",
                table: "Paleontologos",
                column: "AreaEspecializacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Arqueologos_FormacaoAcademicaId",
                table: "Arqueologos",
                column: "FormacaoAcademicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arqueologos_FormacoesAcademicas_FormacaoAcademicaId",
                table: "Arqueologos",
                column: "FormacaoAcademicaId",
                principalTable: "FormacoesAcademicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paleontologos_AreasEspecializacao_AreaEspecializacaoId",
                table: "Paleontologos",
                column: "AreaEspecializacaoId",
                principalTable: "AreasEspecializacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arqueologos_FormacoesAcademicas_FormacaoAcademicaId",
                table: "Arqueologos");

            migrationBuilder.DropForeignKey(
                name: "FK_Paleontologos_AreasEspecializacao_AreaEspecializacaoId",
                table: "Paleontologos");

            migrationBuilder.DropIndex(
                name: "IX_Paleontologos_AreaEspecializacaoId",
                table: "Paleontologos");

            migrationBuilder.DropIndex(
                name: "IX_Arqueologos_FormacaoAcademicaId",
                table: "Arqueologos");
        }
    }
}
