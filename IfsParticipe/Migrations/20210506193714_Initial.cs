using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfsParticipe.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PDI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(nullable: false),
                    Situacao = table.Column<int>(nullable: false),
                    DataIniVig = table.Column<DateTime>(nullable: false),
                    DataFimVig = table.Column<DateTime>(nullable: false),
                    DataIniRecDem = table.Column<DateTime>(nullable: true),
                    DataFimRecDem = table.Column<DateTime>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Login = table.Column<string>(maxLength: 10, nullable: false),
                    Senha = table.Column<string>(maxLength: 10, nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Demanda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(nullable: false),
                    IdPDI = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(maxLength: 60, nullable: false),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false),
                    Situacao = table.Column<int>(nullable: true),
                    Categoria = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Demanda_PDI_IdPDI",
                        column: x => x.IdPDI,
                        principalTable: "PDI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(nullable: false),
                    IdDemanda = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentario_Demanda_IdDemanda",
                        column: x => x.IdDemanda,
                        principalTable: "Demanda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_IdDemanda",
                table: "Comentario",
                column: "IdDemanda");

            migrationBuilder.CreateIndex(
                name: "IX_Demanda_IdPDI",
                table: "Demanda",
                column: "IdPDI");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacao");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Demanda");

            migrationBuilder.DropTable(
                name: "PDI");
        }
    }
}
