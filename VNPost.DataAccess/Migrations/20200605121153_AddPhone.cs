using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { 7, "PhoneText", "Đường dây nóng hỗ trợ" });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { 8, "PhoneNumber", "1900 54 54 81" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
