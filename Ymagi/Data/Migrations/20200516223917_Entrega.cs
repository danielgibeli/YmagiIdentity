using Microsoft.EntityFrameworkCore.Migrations;

namespace Ymagi.Data.Migrations
{
    public partial class Entrega : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Produto_ProdutoId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Usuario_UsuarioId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Usuario_UsuarioId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Produto_ProdutoId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Usuario_UsuarioId",
                table: "Recebimento");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Recebimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Recebimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Entrega",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Entrega",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Produto_ProdutoId",
                table: "Entrega",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Usuario_UsuarioId",
                table: "Entrega",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Usuario_UsuarioId",
                table: "Produto",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Produto_ProdutoId",
                table: "Recebimento",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Usuario_UsuarioId",
                table: "Recebimento",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Produto_ProdutoId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Usuario_UsuarioId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Usuario_UsuarioId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Produto_ProdutoId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Usuario_UsuarioId",
                table: "Recebimento");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Recebimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Recebimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Entrega",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Entrega",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Produto_ProdutoId",
                table: "Entrega",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Usuario_UsuarioId",
                table: "Entrega",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Usuario_UsuarioId",
                table: "Produto",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Produto_ProdutoId",
                table: "Recebimento",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Usuario_UsuarioId",
                table: "Recebimento",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
