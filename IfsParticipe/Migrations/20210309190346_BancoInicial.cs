using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfsParticipe.Migrations
{
    public partial class BancoInicial : Migration
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
                    Situacao = table.Column<string>(nullable: true),
                    DataIniVig = table.Column<DateTime>(nullable: false),
                    DataFimVig = table.Column<DateTime>(nullable: false),
                    DataIniRecDem = table.Column<DateTime>(nullable: false),
                    DataFimRecDem = table.Column<DateTime>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDI", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PDI");
        }
    }
}
