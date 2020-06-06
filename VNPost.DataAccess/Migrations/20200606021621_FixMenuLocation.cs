using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class FixMenuLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "MenuLocations");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "MenuLocations");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MenuLocations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MenuLocations");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "MenuLocations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "MenuLocations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
