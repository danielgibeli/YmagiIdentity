using Microsoft.EntityFrameworkCore.Migrations;

namespace Ymagi.Data.Migrations
{
    public partial class Recebimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Membro_MembroId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Fornecedor_FornecedorId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Membro_MembroId",
                table: "Recebimento");

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Recebimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Recebimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Entrega",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Membro_MembroId",
                table: "Entrega",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Fornecedor_FornecedorId",
                table: "Recebimento",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Membro_MembroId",
                table: "Recebimento",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Membro_MembroId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Fornecedor_FornecedorId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Membro_MembroId",
                table: "Recebimento");

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Recebimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Recebimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Entrega",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Membro_MembroId",
                table: "Entrega",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Fornecedor_FornecedorId",
                table: "Recebimento",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Membro_MembroId",
                table: "Recebimento",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
