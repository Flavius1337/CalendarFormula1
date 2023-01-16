using Microsoft.EntityFrameworkCore.Migrations;

namespace CalendarFormula1.Migrations
{
    public partial class pretfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Pret",
                table: "Cursaa",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pret",
                table: "Cursaa");
        }
    }
}
