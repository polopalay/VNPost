using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class bottomMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 9, "Company", "TỔNG CÔNG TY BƯU ĐIỆN VIỆT NAM - VIETNAM POST" },
                    { 10, "Location", "Địa chỉ: Số 05 đường Phạm Hùng - Mỹ Đình 2 - Nam Từ Liêm - Hà Nội - Việt Nam" },
                    { 11, "Policy", "Ghi rõ nguồn \"www.vnpost.vn\" khi phát hành lại thông tin từ website này" }
                });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Mạng xã hội" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[,]
                {
                    { 31, "", "https://www.facebook.com/vnpost.vn", 8, "fab fa-facebook-f" },
                    { 32, "", "https://twitter.com/buudienvietnam", 8, "fab fa-twitter" },
                    { 33, "", "https://www.linkedin.com/authwall?trk=gf&trkInfo=AQEcHBePbUPbnwAAAXKW4SzYfqas88PMwWIydrQUKt7vRdlRm_Thesf7HIcEsfHSkUXiZuX_nMjyj4IfViiABffUTA0XRALzYNn5xU6ph_mz0P_XK4651j2JANKqojtkFw3fRAk=&originalReferer=http://www.vnpost.vn/&sessionRedirect=https%3A%2F%2Fwww.linkedin.com%2Fin%2Ftt-dvkh-529b25197%2F", 8, "fab fa-linkedin" },
                    { 34, "", "http://www.vnpost.vn/desktopmodules/vnp_webapi/rssfeed.aspx", 8, "fab fa-instagram" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MenuLinks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MenuLocations",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
