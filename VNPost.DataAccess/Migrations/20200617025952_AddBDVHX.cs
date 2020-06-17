using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddBDVHX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 16, 2, "Bưu điện - Văn hóa xã" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ColumnistItems",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
