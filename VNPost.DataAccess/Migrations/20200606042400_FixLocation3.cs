using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class FixLocation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Key",
                value: "fas fa-search-plus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Key",
                value: "as fa-search-plus");
        }
    }
}
