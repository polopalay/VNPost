using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddSeedToArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "<p> Nhiều tháng vừa qua là khoảng thời gian đầy thách thức đối với Bưu chính các nước hoạt động trên tuyến đầu chống đại dịch toàn cầu. Nhưng đây cũng là thời điểm thể hiện nỗ lực bền bỉ và đổi mới của Bưu chính các nước bằng việc mở rộng cung ứng các dịch vụ xã hội, tài chính và thương mại để hỗ trợ chính phủ.</p><br /><br /><div><img src=\"http://www.vnpost.vn/Portals/0/anh%20tin%20tuc/2020-1/Thang%206/anh%20upu.jpg?ver=2020-06-13-091631-810\" /><i>Bưu chính Costa Rica</i></div><p>Những hoạt động đã tạo ra nhiều mối quan đối tác mới và phát triển nhiều mô hình kinh doanh mới. Điển hình là mô hình Bưu chính Costa Rica hợp tác với các công ty cho thuê xe tư nhân để chuyển phát thuốc; Bưu điện Việt Nam với chuyên môn về bản đồ đã hỗ trợ chính phủ trong việc tra cứu bản đồ dịch về các trường hợp nhiễm COVID-19, và Bưu chính Azerbaijan chuyển phát thực phẩm cho các tổ chức từ thiện.</p><br /><br /><p>Ghi nhận các giải pháp năng động của các nhà khai thác bưu chính trong việc ứng phó với khủng hoảng kinh tế và sức khỏe toàn cầu, UPU đã xây dựng một nền tảng chuyên ngành để tổng hợp và đăng thông tin nổi bật về các giải pháp điển hình thiết thực về đổi mới hoạt động kinh doanh các dịch vụ xã hội, tài chính.</p><br /><br /><p>Bưu chính các nước trên thế giới đã tham gia diễn đàn này của UPU để chia sẻ kiến thức mới, và những kiến thức thông tin này đã được bưu chính các nước đóng góp thông qua những tin, bài và các tham luận chuyên đề. Đây cũng là một nguồn tham khảo hữu ích trong việc thể hiện với chính phủ về vai trò của Bưu chính là một dịch vụ cần thiết.</p><br /><br />");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColumnistId", "Content" },
                values: new object[] { 1, "<p> Quan hệ hợp tác hiệu quả giữa Bưu chính các nước, các cơ quan quản lý Nhà nước, tổ chức phi chính phủ (NGOs) và tổ chức doanh nghiệp thuộc khu vực kinh tế tư nhân.</p><br /><br /><div><img src=\"http://www.vnpost.vn/Portals/0/anh%20tin%20tuc/2020-1/Thang%206/chi%20tra_anh%203.jpg?ver=2020-06-13-094031-953\" /><i>Bưu điện Việt Nam thực hiện chi trả lương hưu tại nhà trong dịch Covid-19</i></div><p><b>Đánh giá chung:</b>Quan hệ đối tác hiệu quả là yếu tố sống còn đối với Bưu chính các nước để đa dạng hóa các loại hình cung cấp dịch vụ xã hội mới. Áp lực khiến Bưu chính các nước có giải pháp ứng phó nhanh với đại dịch COVID-19 nhằm hỗ trợ người dân và Chính phủ càng nhấn mạnh thêm giá trị của sự hợp tác mà trong đó, các bên liên quan cùng nhau chia sẻ mọi nguồn lực vì mục tiêu chung. Trong bài viết này, chúng tôi khai thác vai trò của việc đẩy mạnh hợp tác đối tác để cung cấp các dịch vụ chuyển phát trang thiết bị y tế, giải pháp bản đồ số và cung ứng dịch vụ chuyển phát bưu kiện là thực phẩm của Bưu chính Costa Rica, Bưu điện Việt Nam và Bưu chính Azerbaijan. Việc xác định rõ trách nhiệm, xây dựng các kênh hợp tác và xây dựng quy trình triển khai là chìa khóa của sự thành công trong các dự án này.</p><br /><br /><p><b>Nhiều thách thức lớn gồm:</b>tìm nguồn cung ứng đủ sản phẩm trong vài ngày đầu tiên, đảm bảo quy định giấy phép vận chuyển chất có cồn và tổ chức các địa điểm tiếp nhận và xử lý đơn hàng.</p><br /><br />" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "ColumnistId", "Content" },
                values: new object[] { "Trung Kiên", 4, "<p> Sáng 12/6/2020, Cụm Công đoàn số 6 gồm công đoàn các đơn vị BĐT Nam Định, Thái Bình, Hà Nam, Ninh Bình, Thanh Hóa tổ chức Hội nghị Cụm Công đoàn theo hình thức trực tuyến nhằm trao đổi kinh nghiệm, giải pháp để hoàn thành kế hoạch sản xuất kinh doanh 2020. Dự hội nghị có Phó Tổng giám đốc Chu Thị Lan Hương, Chủ tịch Công đoàn Tổng công ty Trần Đức Thích.</p><br /><br /><div><img src=/”hhttp://www.vnpost.vn/Portals/0/anh%20tin%20tuc/2020-1/Thang%206/Chi%20Huong%20phat%20bieu.jpg?ver=2020-06-12-144406-523 /” /><i>Đồng chí Chu Thị Lan Hương chỉ đạo các đơn vị tại Hội nghị</i></div><p>Tại Hội nghị, đồng chí Chu Thị Lan Hương đánh giá cao kết quả hoạt động sản xuất kinh doanh của các đơn vị trong cụm công đoàn số 6 trong 5 tháng đầu năm 2020. Đồng thời chỉ đạo các đơn vị cần tiếp tục phát huy trong thời gian còn lại của năm 2020, đảm bảo hoàn thành các chỉ tiêu kế hoạch mà Tổng công ty đã giao. Đồng chí cũng lưu ý các đơn vị cần đẩy mạnh hoạt động sản xuất kinh doanh để đảm bảo đời sống cho người lao động, đồng thời xây dựng môi trường làm việc thân thiện, vui vẻ, đoàn kết với mục tiêu cùng nhau phát triển.</p><br /><br /><div><img src=/”http://www.vnpost.vn/Portals/0/anh%20tin%20tuc/2020-1/Thang%206/Ca%20don%20vi%20tai%20diem%20cau.jpg?ver=2020-06-12-144523-527 /” /><i>Hội nghị Cụm Công đoàn số 6 được kết nối qua hệ thống hội nghị truyền hình của Tổng công ty </i></div><p>Chủ tịch Công đoàn nhấn mạnh, song song với việc phối hợp cùng chuyên môn triển khai các chương trình thi đua, Công đoàn các đơn vị cần phát huy vai trò của mình trong việc bảo vệ quyền và lợi ích hợp pháp của người lao động, thực hiện đầy đủ chế độ, cơ chế, chính sách chăm sóc người lao động; giám sát việc thực hiện quy chế dân chủ cơ sở trong đó quan tâm đến hoạt động đối thoại định kỳ tại đơn vị nhằm giải quyết những vướng mắc phát sinh kịp thời, tránh để lâu, vượt cấp… để người lao động yên tâm công tác, cống hiến và gắn bó với công việc, đơn vị.</p><br /><br />" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Nhiều tháng vừa qua là khoảng thời gian đầy thách thức đối với Bưu chính các nước hoạt động trên tuyến đầu chống đại dịch toàn cầu. Nhưng đây cũng là thời điểm thể hiện nỗ lực bền bỉ và đổi mới của Bưu chính các nước bằng việc mở rộng cung ứng các dịch vụ xã hội, tài chính và thương mại để hỗ trợ chính phủ.");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Quan hệ hợp tác hiệu quả giữa Bưu chính các nước, các cơ quan quản lý Nhà nước, tổ chức phi chính phủ (NGOs) và tổ chức doanh nghiệp thuộc khu vực kinh tế tư nhân.");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Sáng 12/6/2020, Cụm Công đoàn số 6 gồm công đoàn các đơn vị BĐT Nam Định, Thái Bình, Hà Nam, Ninh Bình, Thanh Hóa tổ chức Hội nghị Cụm Công đoàn theo hình thức trực tuyến nhằm trao đổi kinh nghiệm, giải pháp để hoàn thành kế hoạch sản xuất kinh doanh 2020. Dự hội nghị có Phó Tổng giám đốc Chu Thị Lan Hương, Chủ tịch Công đoàn Tổng công ty Trần Đức Thích.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColumnistId", "Content" },
                values: new object[] { 4, "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "ColumnistId", "Content" },
                values: new object[] { "", 2, "" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "");
        }
    }
}
