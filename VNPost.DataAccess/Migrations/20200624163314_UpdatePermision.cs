using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class UpdatePermision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "d2ba4c46-ec9b-451a-9971-9c1ee4fe92e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a3cb8de0-71c7-4194-840c-9c772b7a4b61", "ac06ad5f-0676-4cdc-9b52-43c67b245583" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
