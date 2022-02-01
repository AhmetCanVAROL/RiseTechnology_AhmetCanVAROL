using Microsoft.EntityFrameworkCore.Migrations;

namespace RiseTechnology.Entities.Migrations
{
    public partial class Mg_Database_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "KISILER",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "KISILER");
        }
    }
}
