using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qualinea.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistroLaudos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataRegistro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IdInsumo = table.Column<int>(type: "INTEGER", nullable: false),
                    IdFornecedor = table.Column<int>(type: "INTEGER", nullable: false),
                    IdAnalista = table.Column<int>(type: "INTEGER", nullable: false),
                    ResultadoFinal = table.Column<int>(type: "INTEGER", nullable: false),
                    Observacoes = table.Column<string>(type: "TEXT", nullable: false),
                    Lote = table.Column<string>(type: "TEXT", nullable: false),
                    NotaFiscal = table.Column<string>(type: "TEXT", nullable: false),
                    Brix = table.Column<float>(type: "REAL", nullable: false),
                    Particulas = table.Column<float>(type: "REAL", nullable: false),
                    Peso = table.Column<float>(type: "REAL", nullable: false),
                    Ph = table.Column<float>(type: "REAL", nullable: false),
                    Umidade = table.Column<float>(type: "REAL", nullable: false),
                    Viscosidade = table.Column<float>(type: "REAL", nullable: false),
                    Temperatura = table.Column<float>(type: "REAL", nullable: false),
                    Solidificacao = table.Column<int>(type: "INTEGER", nullable: false),
                    Textura = table.Column<int>(type: "INTEGER", nullable: false),
                    Vedacao = table.Column<int>(type: "INTEGER", nullable: false),
                    Medida = table.Column<int>(type: "INTEGER", nullable: false),
                    Granulometria = table.Column<int>(type: "INTEGER", nullable: false),
                    InspecaoVisual = table.Column<int>(type: "INTEGER", nullable: false),
                    Dimensao = table.Column<int>(type: "INTEGER", nullable: false),
                    Cor = table.Column<int>(type: "INTEGER", nullable: false),
                    CorConcentrado = table.Column<int>(type: "INTEGER", nullable: false),
                    CorDiluicao = table.Column<int>(type: "INTEGER", nullable: false),
                    Odor = table.Column<int>(type: "INTEGER", nullable: false),
                    OdorConcentrado = table.Column<int>(type: "INTEGER", nullable: false),
                    OdorDiluicao = table.Column<int>(type: "INTEGER", nullable: false),
                    Sabor = table.Column<int>(type: "INTEGER", nullable: false),
                    SaborDiluicao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroLaudos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroLaudos");
        }
    }
}
