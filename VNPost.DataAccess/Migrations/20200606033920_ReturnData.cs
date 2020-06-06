using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class ReturnData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Value",
                value: "<p>Tra cước</p><span>DỊCH VỤ</span>");

            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Value",
                value: "<p>Đánh giá &</p><span>KHIẾU NẠI</span>");

            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Value",
                value: "<p>Tin</p><span>TUYỂN DỤNG</span>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Value",
                value: "<p>Tra cước<span>DỊCH VỤ</span></p>");

            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Value",
                value: "<p>Đánh giá &<span>KHIẾU NẠI</span></p>");

            migrationBuilder.UpdateData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Value",
                value: "<p>Tin<span>TUYỂN DỤNG</span></p>");
        }
    }
}
