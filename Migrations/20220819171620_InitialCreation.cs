using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldPetApi.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrimeiroNome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Celular = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Name",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Login = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Raca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    IdEspecie = table.Column<Guid>(type: "TEXT", nullable: false),
                    EspecieId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RacaId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Raca_Name_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Name",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Raca_Raca_RacaId",
                        column: x => x.RacaId,
                        principalTable: "Raca",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    IdEspecie = table.Column<Guid>(type: "TEXT", nullable: false),
                    EspecieId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdRaca = table.Column<Guid>(type: "TEXT", nullable: false),
                    RacaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClienteId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pet_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pet_Name_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Name",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Raca_RacaId",
                        column: x => x.RacaId,
                        principalTable: "Raca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pet_ClienteId",
                table: "Pet",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_EspecieId",
                table: "Pet",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_RacaId",
                table: "Pet",
                column: "RacaId");

            migrationBuilder.CreateIndex(
                name: "IX_Raca_EspecieId",
                table: "Raca",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_Raca_RacaId",
                table: "Raca",
                column: "RacaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Raca");

            migrationBuilder.DropTable(
                name: "Name");
        }
    }
}
