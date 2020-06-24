using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class FixCURD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "9933836d-9083-4360-8acf-63577cac167a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c39412a-ccf5-41d3-a0a3-29fac7eff19d", "b16be6b0-207f-4ac8-ab7d-cdd345b24dc3" });

            migrationBuilder.UpdateData(
                table: "CURDs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Update");

            migrationBuilder.UpdateData(
                table: "CURDs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Delete");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "24df3682-6fd9-42e4-95df-a4cff79ac6a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d08e4013-2c3d-41ba-8c52-acff5b6acbf0", "1fdd9b91-1c08-4a92-9277-b5a8231039b4" });

            migrationBuilder.UpdateData(
                table: "CURDs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Insert");

            migrationBuilder.UpdateData(
                table: "CURDs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Update");
        }
    }
}
