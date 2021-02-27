using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class UpdateV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "ee2a3908-953c-41df-bb07-c25fe92fa8e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "588a4bef-a063-40da-99de-65c53c70ff80", "4ca193bf-3c6c-44b7-b3ea-4ad7388bec0e" });

            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Link",
                value: "/Main/Search");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "7f8da33f-120e-4a02-bd93-de952f9764ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bc0a395-d618-407e-ae7b-4b39335934c6", "9008a39b-413d-4169-8ae6-0a563b10de90" });

            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Link",
                value: "/Admin/Location/Index");
        }
    }
}
