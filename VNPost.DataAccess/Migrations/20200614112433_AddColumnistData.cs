using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddColumnistData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Columnist_ColumnistId",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Columnist",
                table: "Columnist");

            migrationBuilder.RenameTable(
                name: "Columnist",
                newName: "Columnists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Columnists",
                table: "Columnists",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Columnists",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tin Vietnam Post" },
                    { 2, "Bưu điện - Văn hóa xã" },
                    { 3, "Người bưu điện" },
                    { 4, "Hoạt động Đảng - Đoàn thể" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Columnists_ColumnistId",
                table: "Articles",
                column: "ColumnistId",
                principalTable: "Columnists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Columnists_ColumnistId",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Columnists",
                table: "Columnists");

            migrationBuilder.DeleteData(
                table: "Columnists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Columnists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Columnists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Columnists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Columnists",
                newName: "Columnist");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Columnist",
                table: "Columnist",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Columnist_ColumnistId",
                table: "Articles",
                column: "ColumnistId",
                principalTable: "Columnist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
