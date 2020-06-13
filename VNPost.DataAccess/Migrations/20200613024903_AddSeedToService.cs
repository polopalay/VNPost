using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddSeedToService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[,]
                {
                    { 1, "<p>Toàn quốc và trên 100 quốc gia và vùng lãnh thổ khắp thế giới theo thoả thuận giữa Công ty và Bưu chính các nước thuộc Liên minh Bưu chính Thế giới (UPU) hoặc các đối tác khác.</p>", "Phạm vi cung cấp", 4 },
                    { 2, "<h4>Khối lượng:</h4><br/><p>- Khối lượng bưu gửi EMS thông thường: Tối đa 31,5kg/bưu gửi.</p><br /><p>- Đối với bưu gửi là hàng nguyên khối không thể tách rời, vận chuyển bằng đường bộ được nhận gửi tối đa đến 50kg, nhưng phải đảm bảo giới hạn về kích thước theo quy định.</p><br /><p>- Đối với bưu gửi là hàng nhẹ (hàng có khối lượng thực tế nhỏ hơn khối lượng qui đổi), khối lượng tính cước không căn cứ vào khối lượng thực tế mà căn cứ vào khối lượng qui đổi theo cách tính như sau: Khối lượng qui đổi (kg) = Chiều dài x Chiều rộng x Chiều cao (cm) / 6000</p><br /><p>- Đối với bưu gửi quốc tế: Thực hiện theo thông báo của Công ty Cổ phần Chuyển phát nhanh Bưu điện đối với từng nước.</p><br /><h4>Kích thước:</h4><br /><p>- Kích thước tối thiểu:</p><br /><p>+ Ít nhất một mặt bưu gửi có kích thước không nhỏ hơn 90mm x 140mm với sai số 2 mm.</p><br /><p>+ Nếu cuộn tròn: Chiều dài bưu gửi cộng hai lần đường kính tối thiểu 170 mm và kích thước chiều lớn nhất không nhỏ  hơn 100mm.</p><br /><p>- Kích thước tối đa: Bất kỳ chiều nào của bưu gửi không vượt quá 1500mm và tổng chiều dài cộng với chu vi lớn nhất (không đo theo chiều dài đã đo) không vượt quá 3000mm.</p><br /><p>- Bưu gửi có kích thước lớn hơn so với kích thước thông thường được gọi là bưu gửi cồng kềnh và có quy định riêng phụ thuộc vào từng nơi nhận, nơi phát và điều kiện phương tiện vận chuyển.</p><br /><p>- Đối với bưu gửi quốc tế: Kích thước thông thường đối với bưu gửi EMS là bất kỳ chiều nào của bưu gửi cũng không vượt quá 1,5m và tổng chiều dài cộng với chu vi lớn nhất (không đo theo chiều dài đã đo) không vượt quá 3m.</p><br />", "Khối lượng, kích thước", 4 },
                    { 3, "<p>Tùy theo từng dịch vụ sẽ có bảng cước giá khác nhau kèm theo phí dịch vụ của các dịch vụ cộng thêm.</p><p>Bảng cước dịch vụ chuyển phát nhanh EMS trong nước</p><p>Bảng cước dịch vụ chuyển phát nhanh EMS quốc tế</p>", "Cước phí", 4 },
                    { 4, "<p>Toàn quốc</p>", "Phạm vi cung cấp dịch vụ", 5 },
                    { 5, "<h4>a. Giới hạn kích thước của bưu thiếp:</h4><br/><p>- Kích thước tối đa: 165 mm x 245 mm, với sai số 2 mm.</p><br /><p>- Kích thước tối thiểu: 90 mm x 140 mm, với sai số 2 mm. </p><br /><p>- Tỷ lệ tối thiểu giữa chiều dài và chiều rộng: dài = rộng x  (≈ 1,4).</p><br /><h4>b. Giới hạn kích thước của gói nhỏ: </h4><br /><p>- Kích thước tối thiểu: 210 x 148 mm.</p><br /><p>- Kích thước tối đa: Tổng chiều dài, chiều rộng và chiều cao là 900 mm, nhưng kích thước chiều lớn nhất không vượt quá 600 mm, với sai số 2 mm. Nếu cuộn tròn, chiều dài cộng hai lần đường kính là 1040 mm, nhưng kích thước lớn nhất không vượt quá 900 mm.</p><br /><h4>c. Giới hạn kích thước của các loại bưu phẩm khác:</h4><br /><p>- Kích thước tối đa: Tổng chiều dài, chiều rộng và chiều cao là 900 mm, nhưng kích thước chiều lớn nhất không vượt quá 600 mm, với sai số 2 mm. Nếu cuộn tròn, chiều dài cộng hai lần đường kính là 1040 mm, nhưng kích thước lớn nhất không vượt quá 900 mm, với sai số 2 mm.</p><br /><p>- Kích thước tối thiểu: Một mặt kích thước không nhỏ hơn 90 mm x 140 mm với sai số 2 mm. Nếu cuộn tròn: chiều dài cộng hai lần đường kính là 170 mm, nhưng kích thước chiều lớn nhất không nhỏ hơn 100 mm</p><br />", "Quy định về khối lượng / kích thước", 5 },
                    { 6, "<p>Tất cả các điểm cung cấp dịch vụ của Bưu điện Việt Nam trên toàn quốc</p>", "Phạm vi cung cấp dịch vụ", 6 },
                    { 7, "<p>Mức phí bảo hiểm cạnh tranh với nhiều chương trình bán hàng hấp dẫn.</p><br/><p>Liên hệ với các điểm bán hàng của Bưu điện trên toàn quốc để biết thông tin phí bảo hiểm chi tiết.</p>", "Bảng cước dịch vụ", 6 },
                    { 8, "<p>Tất cả các điểm cung cấp dịch vụ của Bưu điện Việt Nam trên toàn quốc</p>", "Phạm vi cung cấp dịch vụ", 7 },
                    { 9, "<p>Giá cước được thỏa thuận tùy theo từng đối tác và theo sản lượng giao dịch.</p>", "Bảng cước dịch vụ", 7 },
                    { 10, "<p>Trên toàn Quốc!</p>", "Phạm vi cung cấp dịch vụ", 8 },
                    { 11, "<p>Dịch vụ thương mại điện tử hay con gọi là E-commerce là hoạt động kinh doanh, mua bán các loại sản phẩm hàng hóa/ dịch vụ diễn ra trên môi trường internet, đặc biệt là thông qua các website và ứng dụng di động. Các hoạt động diễn ra chủ yếu theo 3 hình thức B2C, B2B và C2C</p>", "Đặc điểm dịch vụ", 8 },
                    { 12, "<p>Tất cả các điểm giao dịch trên 63 tỉnh, thành phố</p>", "Phạm vi cung cấp dịch vụ", 9 },
                    { 13, "<i>Theo thỏa thuận trên cơ sở đơn giá thị trường</i>", "Bảng cước dịch vụ", 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
