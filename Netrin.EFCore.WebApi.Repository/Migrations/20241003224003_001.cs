using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netrin.EFCore.WebApi.Repository.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    str_nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dat_nascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    str_cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lon_telefone = table.Column<long>(type: "bigint", nullable: true),
                    str_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    str_nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dat_nascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    str_cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lon_telefone = table.Column<long>(type: "bigint", nullable: true),
                    str_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_PessoaId",
                table: "Enderecos",
                column: "PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
