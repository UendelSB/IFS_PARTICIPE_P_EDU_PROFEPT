using Microsoft.EntityFrameworkCore.Migrations;

namespace IfsParticipe.Migrations
{
    public partial class relacionamentosv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demanda_PDI_IdDemanda",
                table: "Demanda");

            migrationBuilder.DropIndex(
                name: "IX_Demanda_IdDemanda",
                table: "Demanda");

            migrationBuilder.DropColumn(
                name: "IdDemanda",
                table: "Demanda");

            migrationBuilder.CreateIndex(
                name: "IX_Demanda_IdPDI",
                table: "Demanda",
                column: "IdPDI");

            migrationBuilder.AddForeignKey(
                name: "FK_Demanda_PDI_IdPDI",
                table: "Demanda",
                column: "IdPDI",
                principalTable: "PDI",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demanda_PDI_IdPDI",
                table: "Demanda");

            migrationBuilder.DropIndex(
                name: "IX_Demanda_IdPDI",
                table: "Demanda");

            migrationBuilder.AddColumn<int>(
                name: "IdDemanda",
                table: "Demanda",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Demanda_IdDemanda",
                table: "Demanda",
                column: "IdDemanda");

            migrationBuilder.AddForeignKey(
                name: "FK_Demanda_PDI_IdDemanda",
                table: "Demanda",
                column: "IdDemanda",
                principalTable: "PDI",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
