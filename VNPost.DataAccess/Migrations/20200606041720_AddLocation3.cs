using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddLocation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[,]
                {
                    { 13, "fas fa-map-marker-alt", "#", 3, "Định Vị Bưu Gửi" },
                    { 14, "fas fa-money-bill-alt", "#", 3, "Định vị chuyển tiền" },
                    { 15, "fas fa-map", "#", 3, "Mạng lưới bưu cục" },
                    { 16, "fas fa-ban", "#", 3, "Tra cứu hàng cấm gửi" },
                    { 17, "as fa-search-plus", "#", 3, "Tra cứu kỳ cước KHL" },
                    { 18, "fas fa-qrcode", "#", 3, "Mã địa chỉ bưu chính" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
