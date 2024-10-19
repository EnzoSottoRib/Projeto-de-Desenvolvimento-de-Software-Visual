using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Colocandoidemartefatoefossil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaleontologoId",
                table: "Fosseis",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArqueologoId",
                table: "Artefatos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fosseis_PaleontologoId",
                table: "Fosseis",
                column: "PaleontologoId");

            migrationBuilder.CreateIndex(
                name: "IX_Artefatos_ArqueologoId",
                table: "Artefatos",
                column: "ArqueologoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artefatos_Arqueologos_ArqueologoId",
                table: "Artefatos",
                column: "ArqueologoId",
                principalTable: "Arqueologos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fosseis_Paleontologos_PaleontologoId",
                table: "Fosseis",
                column: "PaleontologoId",
                principalTable: "Paleontologos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artefatos_Arqueologos_ArqueologoId",
                table: "Artefatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Fosseis_Paleontologos_PaleontologoId",
                table: "Fosseis");

            migrationBuilder.DropIndex(
                name: "IX_Fosseis_PaleontologoId",
                table: "Fosseis");

            migrationBuilder.DropIndex(
                name: "IX_Artefatos_ArqueologoId",
                table: "Artefatos");

            migrationBuilder.DropColumn(
                name: "PaleontologoId",
                table: "Fosseis");

            migrationBuilder.DropColumn(
                name: "ArqueologoId",
                table: "Artefatos");
        }
    }
}
