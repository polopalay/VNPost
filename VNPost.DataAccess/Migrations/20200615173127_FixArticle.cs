using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class FixArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "Title" },
                values: new object[] { new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hội nghị Cụm Công đoàn số 6: Các giải pháp nhằm hoàn thành kế hoạch sản xuất kinh doanh năm 2020" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "Title" },
                values: new object[] { new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hội nghị Cụm Công đoàn số 6: Các giải pháp nhằm hoàn thành kế hoạch sản xuất kinh doanh năm 2020”" });
        }
    }
}
