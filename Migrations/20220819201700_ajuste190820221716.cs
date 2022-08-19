using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldPetApi.Migrations
{
    public partial class ajuste190820221716 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Cliente_ClienteId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Name_EspecieId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Raca_Name_EspecieId",
                table: "Raca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Name",
                table: "Name");

            migrationBuilder.RenameTable(
                name: "Name",
                newName: "Especie");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Pet",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdCliente",
                table: "Pet",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especie",
                table: "Especie",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Cliente_ClienteId",
                table: "Pet",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Especie_EspecieId",
                table: "Pet",
                column: "EspecieId",
                principalTable: "Especie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Raca_Especie_EspecieId",
                table: "Raca",
                column: "EspecieId",
                principalTable: "Especie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Cliente_ClienteId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Especie_EspecieId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Raca_Especie_EspecieId",
                table: "Raca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especie",
                table: "Especie");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Pet");

            migrationBuilder.RenameTable(
                name: "Especie",
                newName: "Name");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Pet",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Name",
                table: "Name",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Cliente_ClienteId",
                table: "Pet",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Name_EspecieId",
                table: "Pet",
                column: "EspecieId",
                principalTable: "Name",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Raca_Name_EspecieId",
                table: "Raca",
                column: "EspecieId",
                principalTable: "Name",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
