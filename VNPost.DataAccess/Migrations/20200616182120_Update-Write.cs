using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class UpdateWrite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Link", "Value" },
                values: new object[] { "/Posts/Write/WriteArticle", "Viết Bài" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Link", "Value" },
                values: new object[] { "#", "Email" });
        }
    }
}
