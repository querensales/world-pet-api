using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldPetApi.Migrations
{
    public partial class ajuste202208241123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Raca_Raca_RacaId",
                table: "Raca");

            migrationBuilder.DropIndex(
                name: "IX_Raca_RacaId",
                table: "Raca");

            migrationBuilder.DropColumn(
                name: "RacaId",
                table: "Raca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RacaId",
                table: "Raca",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Raca_RacaId",
                table: "Raca",
                column: "RacaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Raca_Raca_RacaId",
                table: "Raca",
                column: "RacaId",
                principalTable: "Raca",
                principalColumn: "Id");
        }
    }
}
