using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ymagi.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Membro_MembroId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Membro_Osc_OscId",
                table: "Membro");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario");

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Osc",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "OscId",
                table: "Membro",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Fornecedor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Membro_MembroId",
                table: "Fornecedor",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Membro_Osc_OscId",
                table: "Membro",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Membro_MembroId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Membro_Osc_OscId",
                table: "Membro");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Osc");

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OscId",
                table: "Membro",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Fornecedor",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Membro_MembroId",
                table: "Fornecedor",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Membro_Osc_OscId",
                table: "Membro",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
