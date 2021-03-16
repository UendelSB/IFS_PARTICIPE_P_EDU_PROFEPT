using Microsoft.EntityFrameworkCore.Migrations;

namespace IfsParticipe.Migrations
{
    public partial class relacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentario_Demanda_IdDemanda",
                table: "Comentario");

            migrationBuilder.AddColumn<int>(
                name: "IdDemanda",
                table: "Demanda",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPDI",
                table: "Demanda",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "IdDemanda",
                table: "Comentario",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Demanda_IdDemanda",
                table: "Demanda",
                column: "IdDemanda");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentario_Demanda_IdDemanda",
                table: "Comentario",
                column: "IdDemanda",
                principalTable: "Demanda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Demanda_PDI_IdDemanda",
                table: "Demanda",
                column: "IdDemanda",
                principalTable: "PDI",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentario_Demanda_IdDemanda",
                table: "Comentario");

            migrationBuilder.DropForeignKey(
                name: "FK_Demanda_PDI_IdDemanda",
                table: "Demanda");

            migrationBuilder.DropIndex(
                name: "IX_Demanda_IdDemanda",
                table: "Demanda");

            migrationBuilder.DropColumn(
                name: "IdDemanda",
                table: "Demanda");

            migrationBuilder.DropColumn(
                name: "IdPDI",
                table: "Demanda");

            migrationBuilder.AlterColumn<int>(
                name: "IdDemanda",
                table: "Comentario",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Comentario_Demanda_IdDemanda",
                table: "Comentario",
                column: "IdDemanda",
                principalTable: "Demanda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
