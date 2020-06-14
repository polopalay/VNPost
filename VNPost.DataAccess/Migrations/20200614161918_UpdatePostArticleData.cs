using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class UpdatePostArticleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Author", "ColumnistId", "Content", "DateCreate", "PostId", "View" },
                values: new object[,]
                {
                    { 1, "", 1, "", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 2, "", 4, "", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 3, "", 2, "", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionImg", "Title" },
                values: new object[] { "http://www.vnpost.vn/Portals/0/anh%20tin%20tuc/2020-1/Thang%206/anh%20upu.jpg?ver=2020-06-13-091631-810", "Bưu chính đẩy mạnh quan hệ đối tác để đột phá thời COVID-19" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DescriptionImg", "Title" },
                values: new object[] { "", "http://www.vnpost.vn/Portals/0/anh%20tin%20tuc/2020-1/Thang%206/chi%20tra_anh%203.jpg?ver=2020-06-13-094031-953", "Đẩy mạnh quan hệ đối tác để cùng ứng phó với đại dịch COVID-19" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DescriptionImg", "Title" },
                values: new object[] { "", "http://www.vnpost.vn/Portals/0/anh%20tin%20tuc/2020-1/Thang%206/Chi%20Huong%20phat%20bieu.jpg?ver=2020-06-12-144406-523", "Hội nghị Cụm Công đoàn số 6: Các giải pháp nhằm hoàn thành kế hoạch sản xuất kinh doanh năm 2020”" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionImg", "Title" },
                values: new object[] { "http://www.vnpost.vn/Portals/_default/Skins/VNPost.Skins.FrontEnd//img/vnpost-logo.png", "Bưu điện tỉnh Nghệ An tuyển dụng lao động" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DescriptionImg", "Title" },
                values: new object[] { "Chiều ngày 8/6/2020, tại Hà Nội, Bộ TT&TT đã tổ chức Hội nghị triển khai quyết định về công tác cán bộ. Đồng chí Nguyễn Mạnh Hùng, Ủy viên Trung ương Đảng, Bí thư Ban cán sự Đảng,...", "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fanh+tin+tuc%2f2020-1%2fThang+6%2f20200608-m07.jpg&size=3&ver=6", "Bộ TT&TT kéo dài thời gian giữ chức Thành viên Hội đồng thành viên với ông Nguyễn Quốc Vinh" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DescriptionImg", "Title" },
                values: new object[] { "Bưu điện tỉnh Nghệ An xác định hướng đi mới đúng đắn cho Bưu điện Văn hóa xã (BĐ-VHX) qua việc triển khai cung cấp các sản phẩm hàng tiêu dùng đến tay người dân, đặc biệt là người...", "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fanh+tin+tuc%2f2020-1%2fThang+6%2fbuu_dien_2_cfzr.jpg&size=3&ver=2", "Nghệ An: Bán hàng tiêu dùng qua hệ thống bưu điện văn hóa xã - “nhiều lợi ích thiết thực”" });
        }
    }
}
