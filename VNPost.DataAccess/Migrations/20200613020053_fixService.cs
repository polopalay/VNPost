using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class fixService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Services_PostId",
                table: "Services",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Posts_PostId",
                table: "Services",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Posts_PostId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_PostId",
                table: "Services");
        }
    }
}
