using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class FixPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Là dịch vụ chuyển phát nhanh thư, tài liệu, vật phẩm, hàng hóa từ người gửi đến người nhận giữa Việt Nam trong nước và các nước trên thế giới trong khuôn khổ Liên minh Bưu chính Thế giới (UPU) và Hiệp hội EMS theo chỉ tiêu thời gian được Công ty Cổ phần Chuyển Phát Nhanh Bưu điện công bố trước. Chi tiết xin tham khảo tại website: www.ems.com.vn");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Bưu phẩm bảo đảm là dịch vụ chấp nhận, vận chuyển và phát bưu phẩm đến địa chỉ nhận trong nước và quốc tế; bưu phẩm được gắn số hiệu để theo dõi, định vị trong quá trình chuyển phát.");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Là dịch vụ giới thiệu, chào bán bảo hiểm, thu xếp việc giao kết hợp đồng bảo hiểm thông qua mạng lưới bưu cục, điểm cung cấp dịch vụ của Tổng Công ty Bưu điện Việt Nam.");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Là dịch vụ cho phép khách hàng nộp tiền phí bảo hiểm, vay trả góp, tiền điện, nước, cước điện thoại, tiền đặt chỗ, mua hàng qua mạng, tiền phí phạt vi phạm giao thông, tiền thuế, tiền lệ phí hồ sơ xét tuyển ĐH,CĐ, tiền cấp đổi CMND, Hộ chiếu, tiền đặt vé máy bay…tại bưu cục");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Là dịch vụ chuyển phát nhanh thư, tài liệu, vật phẩm, hàng hóa từ người gửi đến người nhận giữa Việt Nam trong nước và các nước trên thế giới trong...");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Bưu phẩm bảo đảm là dịch vụ chấp nhận, vận chuyển và phát bưu phẩm đến địa chỉ nhận trong nước và quốc tế; bưu phẩm được gắn số hiệu để theo dõi, định...");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Là dịch vụ giới thiệu, chào bán bảo hiểm, thu xếp việc giao kết hợp đồng bảo hiểm thông qua mạng lưới bưu cục, điểm cung cấp dịch vụ của Tổng Công ty...");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Là dịch vụ cho phép khách hàng nộp tiền phí bảo hiểm, vay trả góp, tiền điện, nước, cước điện thoại, tiền đặt chỗ, mua hàng qua mạng, tiền phí phạt vi...");
        }
    }
}
