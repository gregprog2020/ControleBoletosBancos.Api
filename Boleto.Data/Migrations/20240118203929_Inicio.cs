using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleBoleto.Data.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bancos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nomebanco = table.Column<string>(type: "varchar(100)", nullable: false),
                    codigobanco = table.Column<string>(type: "varchar(100)", nullable: false),
                    percentualjuros = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bancos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "boletos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nomepagador = table.Column<string>(type: "varchar(100)", nullable: false),
                    cpfcnpjpagador = table.Column<string>(type: "varchar(100)", nullable: false),
                    nomebeneficiario = table.Column<string>(type: "varchar(100)", nullable: false),
                    cpfcnpjbeneficiario = table.Column<string>(type: "varchar(100)", nullable: false),
                    valor = table.Column<decimal>(type: "numeric", nullable: false),
                    datavencimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    observacao = table.Column<string>(type: "varchar(100)", nullable: false),
                    bancoid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boletos", x => x.id);
                    table.ForeignKey(
                        name: "FK_boletos_bancos_bancoid",
                        column: x => x.bancoid,
                        principalTable: "bancos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_boletos_bancoid",
                table: "boletos",
                column: "bancoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "boletos");

            migrationBuilder.DropTable(
                name: "bancos");
        }
    }
}
