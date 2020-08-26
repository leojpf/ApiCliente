using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiCliente.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_ClienteId",
                table: "Endereco");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Endereco",
                newName: "clienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_ClienteId",
                table: "Endereco",
                newName: "IX_Endereco_clienteId");

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Endereco",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Endereco",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNasc",
                table: "Cliente",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Cliente",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_clienteId",
                table: "Endereco",
                column: "clienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_clienteId",
                table: "Endereco");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "Endereco",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_clienteId",
                table: "Endereco",
                newName: "IX_Endereco_ClienteId");

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNasc",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_ClienteId",
                table: "Endereco",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
