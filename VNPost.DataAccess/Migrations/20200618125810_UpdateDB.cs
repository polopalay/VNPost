using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Value",
                value: "Bài viết");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Value",
                value: "Viết Bài");
        }
    }
}
