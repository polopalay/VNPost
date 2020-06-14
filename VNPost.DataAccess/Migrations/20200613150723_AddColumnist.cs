using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddColumnist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "ColumnistId",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreate",
                table: "Articles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Columnist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Columnist", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ColumnistId",
                table: "Articles",
                column: "ColumnistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Columnist_ColumnistId",
                table: "Articles",
                column: "ColumnistId",
                principalTable: "Columnist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Columnist_ColumnistId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "Columnist");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ColumnistId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ColumnistId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "DateCreate",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
