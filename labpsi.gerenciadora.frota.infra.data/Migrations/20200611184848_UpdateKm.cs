using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace labpsi.gerenciadora.frota.infra.data.Migrations
{
    public partial class UpdateKm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Km",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValue: new Guid("953c6d83-bcb4-4a81-a126-ebfb04119b73")),
                    KmAtual = table.Column<decimal>(nullable: false),
                    DateSaida = table.Column<DateTime>(nullable: false),
                    DataChegada = table.Column<DateTime>(nullable: false),
                    Destino = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Km", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValue: new Guid("f9fe6fca-81cd-4a8c-be8b-78c6d9df0316")),
                    Placa = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    Chassi = table.Column<string>(nullable: false),
                    Renavam = table.Column<string>(nullable: false),
                    Marca = table.Column<string>(nullable: false),
                    Cor = table.Column<string>(nullable: false),
                    ValorPago = table.Column<decimal>(nullable: false),
                    MesIpva = table.Column<int>(nullable: false),
                    KmAtual = table.Column<decimal>(nullable: false),
                    _kmId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Km__kmId",
                        column: x => x._kmId,
                        principalTable: "Km",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo__kmId",
                table: "Veiculo",
                column: "_kmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Km");
        }
    }
}
