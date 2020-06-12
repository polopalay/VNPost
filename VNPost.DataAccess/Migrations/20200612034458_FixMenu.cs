using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class FixMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 12, 10, 44, 57, 717, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 12, 10, 44, 57, 730, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 12, 10, 44, 57, 730, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "MenuLocations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Mua sắm trực tuyến");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "MenuLocations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "MUA SẮM TRỰC TUYẾN");
        }
    }
}
