using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class UpdateLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Link",
                value: "/Identity/Account/login");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Link",
                value: "#");
        }
    }
}
