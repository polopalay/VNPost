using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class fixSt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Link",
                value: "/Posts/Write/Index");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Link",
                value: "/Posts/Write/WriteArticle");
        }
    }
}
