using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiCliente.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNasc",
                table: "Cliente",
                type: "Datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNasc",
                table: "Cliente",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime");
        }
    }
}
