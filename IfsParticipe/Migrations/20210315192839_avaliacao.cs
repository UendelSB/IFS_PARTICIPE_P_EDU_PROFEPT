using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfsParticipe.Migrations
{
    public partial class avaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(nullable: false),
                    Nota = table.Column<int>(nullable: false),
                    IdDemanda = table.Column<int>(nullable: true),
                    IdComentario = table.Column<int>(nullable: true),
                    Tipo = table.Column<string>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Comentario_IdComentario",
                        column: x => x.IdComentario,
                        principalTable: "Comentario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Demanda_IdDemanda",
                        column: x => x.IdDemanda,
                        principalTable: "Demanda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_IdComentario",
                table: "Avaliacao",
                column: "IdComentario");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_IdDemanda",
                table: "Avaliacao",
                column: "IdDemanda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacao");
        }
    }
}
