using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddSeedDataToCategoryAndPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 22, 23, 23, 881, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 22, 23, 23, 893, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 22, 23, 23, 893, DateTimeKind.Local).AddTicks(290));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 13, 52, 49, 585, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 13, 52, 49, 600, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 13, 52, 49, 600, DateTimeKind.Local).AddTicks(5540));
        }
    }
}
