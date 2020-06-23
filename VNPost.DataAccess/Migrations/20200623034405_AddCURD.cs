using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddCURD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "debac651-70f9-4bb9-a979-6428d56bbbf5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8e171e6-591e-4f77-b89c-10f5fc0afdbc", "4110671b-847b-48e2-bced-62356dc8e1f7" });

            migrationBuilder.InsertData(
                table: "CURDs",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Create" });

            migrationBuilder.InsertData(
                table: "CURDs",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Insert" });

            migrationBuilder.InsertData(
                table: "CURDs",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Update" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CURDs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CURDs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CURDs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d23c51-re38-4831-wqa2-2e3f21c23ewd",
                column: "ConcurrencyStamp",
                value: "9d93fed2-8e54-4c92-b3dc-a1c236b2a36a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01b96c14-de28-4831-afa9-3d1f84b93aed",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d882fc4a-4485-43b2-8dde-d94bc192feaf", "0d93973f-c47d-47fc-a5f9-6994bdeb95c2" });
        }
    }
}
