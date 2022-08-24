using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldPetApi.Migrations
{
    public partial class ajuste202208241141 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEspecie",
                table: "Raca");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "IdEspecie",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "IdRaca",
                table: "Pet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdEspecie",
                table: "Raca",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdCliente",
                table: "Pet",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdEspecie",
                table: "Pet",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdRaca",
                table: "Pet",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
