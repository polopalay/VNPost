using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class updateArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "DescriptionImg",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "View",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_PostId",
                table: "Articles",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Posts_PostId",
                table: "Articles",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Posts_PostId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_PostId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "View",
                table: "Articles");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionImg",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
