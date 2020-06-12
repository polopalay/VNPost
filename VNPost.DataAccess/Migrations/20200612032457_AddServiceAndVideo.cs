using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddServiceAndVideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descrtiption",
                table: "MenuLocations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 12, 10, 24, 56, 747, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 12, 10, 24, 56, 756, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 12, 10, 24, 56, 757, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 12, "library-video", "https://www.youtube.com/embed/iPEvFyikq-g" },
                    { 13, "library-video-description", "Ra mắt nền tảng mã địa chỉ bưu chính - Vpostcode" }
                });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Descrtiption", "Name" },
                values: new object[] { 10, "Hiện tại chúng tôi có những gian hàng mua sắm online với đầy đủ những sản phẩm tiện ích, đa dạng. Hy vọng sẽ đem đến cho quý khách hàng những trải nghiệm mua sắm mới mẻ nhất. Hãy đến với hệ thống mua sắm trực tuyến của chúng tôi để tìm cho mình những sản phẩm thiết thực nhất.", "MUA SẮM TRỰC TUYẾN" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 39, "SÀN THƯƠNG MẠI ĐIỆN TỬ POSTMART", " /", 10, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fImages%2fPostmart+thumb.jpg&size=2&ver=28" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 40, "LỊCH TẾT", " /", 10, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fLich+2019+(4).png&size=2&ver=31" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 41, "DỊCH VỤ DATAPOST", " /", 10, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fDataPost+(2).jpg&size=2&ver=31" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MenuLocations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Descrtiption",
                table: "MenuLocations");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 22, 35, 6, 544, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 22, 35, 6, 560, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 22, 35, 6, 560, DateTimeKind.Local).AddTicks(5950));
        }
    }
}
