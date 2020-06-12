using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class FixItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 12, 10, 38, 48, 480, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 12, 10, 38, 48, 495, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 12, 10, 38, 48, 495, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "Key",
                value: "Ra mắt nền tảng mã địa chỉ bưu chính - Vpostcode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "Key",
                value: "library-video");

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { 13, "library-video-description", "Ra mắt nền tảng mã địa chỉ bưu chính - Vpostcode" });
        }
    }
}
