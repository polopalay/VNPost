using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddDataToBottom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Bưu chính chuyển phát" });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Tài chính bưu chính" });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Phân phối - Truyền thông" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[,]
                {
                    { 19, "#", "#", 5, "Bưu chính chuyển phát Trong nước" },
                    { 20, "#", "#", 5, "Bưu chính chuyển phát Quốc tế" },
                    { 21, "#", "#", 6, "Bảo hiểm phi nhân thọ PTI" },
                    { 22, "#", "#", 6, "Thu hộ - Chi hộ" },
                    { 23, "#", "#", 6, "Đại lý Bảo hiểm nhân thọ (Dai-ichi)" },
                    { 24, "#", "#", 6, "Đại lý ngân hàng" },
                    { 25, "#", "#", 6, "Dịch vụ Chuyển tiền trong nước" },
                    { 26, "#", "#", 7, "Sàn thương mại điện tử POSTMART" },
                    { 27, "#", "#", 7, "Truyền thông, quảng cáo" },
                    { 28, "#", "#", 7, "Phân phối xuất bản ấn phẩm" },
                    { 29, "#", "#", 7, "Dịch vụ Viễn thông - CNTT" },
                    { 30, "#", "#", 7, "Dịch vụ phân phối hàng hoá" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MenuLocations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuLocations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuLocations",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
