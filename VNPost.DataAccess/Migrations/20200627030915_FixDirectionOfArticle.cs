using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class FixDirectionOfArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "770bd0f5-29d7-47bd-9d68-a7ae240671f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "419a934d-9089-4555-87b3-567dc41ad557", "86418387-129c-47b8-96d7-978093f50ecc" });

            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Link",
                value: "/Admin/Article/Index");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "7240f6d5-8be1-4066-a732-b9540c20a111");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bd477ad-7ada-433a-9be0-086a3dd108fd", "138c669f-7639-4c59-941c-4240d7ba1a55" });

            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Link",
                value: "/Posts/Write/Index");
        }
    }
}
