using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddLocation4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Tra cứu - Định vị" });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "BottomMenu" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[,]
                {
                    { 8, "PostAndD", "#", 4, "Bưu chính chuyển phát" },
                    { 9, "Money", "#", 4, "Tài chính bưu chính" },
                    { 10, "Comunity", "#", 4, "Phân phối -Truyền thông" },
                    { 11, "News", "#", 4, "Tin tức" },
                    { 12, "Email", "#", 4, "Email" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuLocations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuLocations",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
