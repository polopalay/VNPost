using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class UpdateLogin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 4, "Login", "/Identity/Account/login", 1, "Login" });
        }
    }
}
