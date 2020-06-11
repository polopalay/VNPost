using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddSeedToPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Img", "Name" },
                values: new object[,]
                {
                    { 1, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fDichVu%2f02+-+Buu+dien+Viet+Nam+-+Product.png&size=3&ver=5", "Bưu chính chuyển phát" },
                    { 2, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fDichVu%2fA022_C056_0106MU.0000339-edit.png&size=3&ver=5", "Tài chính bưu chính" },
                    { 3, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fDichVu%2f02+-+Buu+dien+Viet+Nam+(5)-+Product.png&size=3&ver=6", "Phân phối - Truyền thông" },
                    { 4, null, "Tin Tức" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ServiceId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Chuyển phát nhanh EMS" },
                    { 2, 1, "Bưu phẩm đảm bảo" },
                    { 3, 2, "Bảo hiểm phi nhân thọ PTI" },
                    { 4, 2, "Thu hộ - Chi hộ" },
                    { 5, 3, "Sàn thương mại điện tử POSTMART" },
                    { 6, 3, "Truyền thông, quảng cáo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Posts");

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
    }
}
