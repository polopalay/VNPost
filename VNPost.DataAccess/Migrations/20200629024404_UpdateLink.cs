using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class UpdateLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "cca15ff2-7608-4a56-ac69-7aa919fc83d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdadf717-103b-4dec-a71b-a2bfe3b3080a", "4a27e3cd-5502-44e9-af78-45bfc06c2571" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 12, "", "/Admin/Article/Index", 4, "Tài khoản" });
        }
    }
}
