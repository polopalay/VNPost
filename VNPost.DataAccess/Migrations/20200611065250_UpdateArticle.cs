using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class UpdateArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionImg",
                table: "Articles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "DescriptionImg" },
                values: new object[] { new DateTime(2020, 6, 11, 13, 52, 49, 585, DateTimeKind.Local).AddTicks(9930), "http://www.vnpost.vn/Portals/_default/Skins/VNPost.Skins.FrontEnd//img/vnpost-logo.png" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "DescriptionImg" },
                values: new object[] { new DateTime(2020, 6, 11, 13, 52, 49, 600, DateTimeKind.Local).AddTicks(5450), "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fanh+tin+tuc%2f2020-1%2fThang+6%2f20200608-m07.jpg&size=3&ver=6" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "DescriptionImg" },
                values: new object[] { new DateTime(2020, 6, 11, 13, 52, 49, 600, DateTimeKind.Local).AddTicks(5540), "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fanh+tin+tuc%2f2020-1%2fThang+6%2fbuu_dien_2_cfzr.jpg&size=3&ver=2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionImg",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 13, 43, 35, 199, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 13, 43, 35, 210, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 11, 13, 43, 35, 210, DateTimeKind.Local).AddTicks(1650));
        }
    }
}
