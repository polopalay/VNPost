using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CreateDate", "Description", "Title" },
                values: new object[] { 1, new DateTime(2020, 6, 11, 13, 43, 35, 199, DateTimeKind.Local).AddTicks(3820), "", "Bưu điện tỉnh Nghệ An tuyển dụng lao động" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CreateDate", "Description", "Title" },
                values: new object[] { 2, new DateTime(2020, 6, 11, 13, 43, 35, 210, DateTimeKind.Local).AddTicks(1580), "Chiều ngày 8/6/2020, tại Hà Nội, Bộ TT&TT đã tổ chức Hội nghị triển khai quyết định về công tác cán bộ. Đồng chí Nguyễn Mạnh Hùng, Ủy viên Trung ương Đảng, Bí thư Ban cán sự Đảng,...", "Bộ TT&TT kéo dài thời gian giữ chức Thành viên Hội đồng thành viên với ông Nguyễn Quốc Vinh" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CreateDate", "Description", "Title" },
                values: new object[] { 3, new DateTime(2020, 6, 11, 13, 43, 35, 210, DateTimeKind.Local).AddTicks(1650), "Bưu điện tỉnh Nghệ An xác định hướng đi mới đúng đắn cho Bưu điện Văn hóa xã (BĐ-VHX) qua việc triển khai cung cấp các sản phẩm hàng tiêu dùng đến tay người dân, đặc biệt là người...", "Nghệ An: Bán hàng tiêu dùng qua hệ thống bưu điện văn hóa xã - “nhiều lợi ích thiết thực”" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
