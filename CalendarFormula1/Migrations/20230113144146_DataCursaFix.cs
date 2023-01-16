using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CalendarFormula1.Migrations
{
    public partial class DataCursaFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "DataCursa",
                table: "Cursaa",
                type: "float",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCursa",
                table: "Cursaa",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
