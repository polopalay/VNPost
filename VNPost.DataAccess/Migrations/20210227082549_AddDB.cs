﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPost.DataAccess.Migrations
{
    public partial class AddDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Columnists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Columnists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CURDs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CURDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Descrtiption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColumnistItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ColumnistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColumnistItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColumnistItems_Columnists_ColumnistId",
                        column: x => x.ColumnistId,
                        principalTable: "Columnists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DescriptionImg = table.Column<string>(nullable: true),
                    GalleryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuLinks_MenuLocations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "MenuLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Items = table.Column<string>(nullable: false),
                    PointAway = table.Column<string>(nullable: false),
                    Destination = table.Column<string>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    CustomerInfo = table.Column<string>(nullable: false),
                    OtherInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parcels_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DescriptionImg = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    View = table.Column<int>(nullable: false),
                    ColumnistItemId = table.Column<int>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ColumnistItems_ColumnistItemId",
                        column: x => x.ColumnistItemId,
                        principalTable: "ColumnistItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: true),
                    ColumnistItemId = table.Column<int>(nullable: false),
                    Create = table.Column<bool>(nullable: false),
                    Update = table.Column<bool>(nullable: false),
                    Delete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_ColumnistItems_ColumnistItemId",
                        column: x => x.ColumnistItemId,
                        principalTable: "ColumnistItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistricId = table.Column<int>(nullable: false),
                    ParcelId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Districts_DistricId",
                        column: x => x.DistricId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locations_Parcels_ParcelId",
                        column: x => x.ParcelId,
                        principalTable: "Parcels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13d23c51-re38-4831-wqa2-2e3f21c23ewd", "773b4670-cd1c-4636-b01b-4db9286136b8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "01b96c14-de28-4831-afa9-3d1f84b93aed", 0, "b887d344-7483-4077-9bfc-3d3c7489d41c", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENVfYO/ByyafuleVAgUNZiUlG+Vyi645v0VP2+KuzBuUxIrzqh2Hy0RwzJf21yFrAQ==	", null, false, "6ff9cebf-7f8f-4658-99c9-537105c35e30", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "CURDs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Create" },
                    { 2, "Update" },
                    { 3, "Delete" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Img", "Name" },
                values: new object[,]
                {
                    { 1, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fDichVu%2f02+-+Buu+dien+Viet+Nam+-+Product.png&size=3&ver=5", "Bưu chính chuyển phát" },
                    { 2, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fDichVu%2fA022_C056_0106MU.0000339-edit.png&size=3&ver=5", "Tài chính bưu chính" },
                    { 3, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fDichVu%2f02+-+Buu+dien+Viet+Nam+(5)-+Product.png&size=3&ver=6", "Phân phối - Truyền thông" }
                });

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

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Description", "ImgDescription", "Title" },
                values: new object[,]
                {
                    { 9, "Chuyên trang thông tin doanh nghiệp", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACEAAAAhCAYAAABX5MJvAAAACXBIWXMAAAsTAAALEwEAmpwYAAAABGdBTUEAALGOfPtRkwAAACBjSFJNAAB6JQAAgIMAAPn/AACA6QAAdTAAAOpgAAA6mAAAF2+SX8VGAAAEgUlEQVR42mL8//8/w0ADgABiYhgEACCABoUjAAJoUDgCIIBY8Mr++8XAwMQGZ///+5sBSIBwLiO7QDbD/3//GBiZ7Bn+/nz9HyjOyMIN1/r/5xsGhj/fGIDycDFGLhms1gAEEAtpbv4nwcjGa8jw/38N0CFiQGNBRocArbwMxEdBdpMTEgABRMgRhUDMD2W/A1qoD8RJDIyMyDE5jYGJ9T/jf+aFQDc8YIBIgtyzFOjY2wyMhN0FEECMeLPo/3//4cH5/8/////+PGZkYpcEBgAjsiqQOUCSBW4/CPz9eQ6oxxko9QHhZS6s1gAEECOBcuI7EHMgpZGXQIe8BTqMCxH0/4EJhYGZkYlDGcURECAFxM8JhQRAABGKDlQXMrGJMwIxkVH9ndg0AhBARCZMsG9/EjAUJMcOxKwoWYIIABBAhBwBjOt/DP9/fYhiYGR9DjSbHY9DGBn+fX/CyCZowcAISqTEA4AAIiIkgImGkcWNgYlFDxjnQqAkh9sstvnAODtKahYFCCAiHMEICl0NRmZWPaAFnPid+98ISF0g1REAAURMmgAG869ihn8s94Ehwg4OGVxVwL+fTxiY2Z0ZGBhJcgRAABEVHYysPNbAAgmYLRn/MeC2AaiOVw4YamykhgRAABETEsBQ/lvJyMAqRljh35uMDEzlWMoLvAAggIhJE0wMv7/mAAupd8BUz45FHhhdP74xMrH8Auag98BwksGsof8j0hcWABBARIUEMCqACY5JA2iIMFruAJkKDH7GE/9/fallYOH+CkwTchBdf4FV6P/voCzO8O8vkPrJwMgmgNUCgAAiJk0Aw4LVG2i4LsRz/zECguEvo8L/vz8XABmXGP79uQUMtetAdbzAMk6TkZnzBEQP7nIOIICIiQ7G/3+/FzMyMn0C5g5OzNzByALMFU+B3r0BjK44oItDGJmAdQsjiyTDf7YlQPGzQEXt+LIuQAARFxKsPGLAKLkNDIl/WHzE+P/fX2ClxpYCbNRMBzoEWJsywyJLGUgCMZMNw9/v7kD2FWw2AAQQKOnjw9+BQfv3/59v74D1+H/s4C8wut8t+f/n+xns8kB9/4Bqfn/bgMsegAAiJmEyAU2oAVYbr4Exw4KlzfEdGPRaDMwc0ZhywPTx6+M8Rla+emBMmuKyACCAiKpFGZm5HgDj+ggOyV/AxAfLMcCa9h8wfTApgXLH/x9vi4EJ2gFY74Cy9ldc5gMEECFHMIHjl5FhC87k/e/P+f+/v04BNnxBvA/AkOkEJlRjYOgdBIaOLiMbfzHWtgkSAAggvGni399fr/4TAv/+fP7369NupDTz9N+vd6b/f38JR1N5H5c9AAFEoMn/2wWYK3gIFKjANseffwy/v7xkYOUFpQspRhbe7UAJFH3/f77rZ2QXwmoEQAARiA7GS8Q1vIANnz+f3jAyMgszsHB6ABOqMELu729g7prH8PfHbFzaAQKIhYEqAFwn3Pn/50sbsHqRAqYjROP4769zwJZ3FzBnfcelGyCAGAdDrxwggAZFXxQggAaFIwACDADSAiUSdEccxgAAAABJRU5ErkJggg==", "Thông tin Doanh nghiệp" },
                    { 8, "Hướng tới Đại hội Đại biểu Đảng bộ TCT lần II", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAV4AAAFeCAYAAADNK3caAAAACXBIWXMAAAsTAAALEwEAmpwYAAAF0WlUWHRYTUw6Y29tLmFkb2JlLnhtcAAAAAAAPD94cGFja2V0IGJlZ2luPSLvu78iIGlkPSJXNU0wTXBDZWhpSHpyZVN6TlRjemtjOWQiPz4gPHg6eG1wbWV0YSB4bWxuczp4PSJhZG9iZTpuczptZXRhLyIgeDp4bXB0az0iQWRvYmUgWE1QIENvcmUgNS42LWMxNDUgNzkuMTYzNDk5LCAyMDE4LzA4LzEzLTE2OjQwOjIyICAgICAgICAiPiA8cmRmOlJERiB4bWxuczpyZGY9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkvMDIvMjItcmRmLXN5bnRheC1ucyMiPiA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0iIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdEV2dD0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlRXZlbnQjIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOnBob3Rvc2hvcD0iaHR0cDovL25zLmFkb2JlLmNvbS9waG90b3Nob3AvMS4wLyIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ0MgMjAxOSAoV2luZG93cykiIHhtcDpDcmVhdGVEYXRlPSIyMDIwLTAzLTE4VDE0OjI5OjQyKzA3OjAwIiB4bXA6TWV0YWRhdGFEYXRlPSIyMDIwLTAzLTE4VDE0OjI5OjQyKzA3OjAwIiB4bXA6TW9kaWZ5RGF0ZT0iMjAyMC0wMy0xOFQxNDoyOTo0MiswNzowMCIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDowN2EwZjA0MS1mNzBmLThlNGYtODFlZC0yNzU4MDg4MzNhMjciIHhtcE1NOkRvY3VtZW50SUQ9ImFkb2JlOmRvY2lkOnBob3Rvc2hvcDo1MjE0N2RhZi1hNzg5LTVmNGUtYTc4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", "Đại hội Đảng" },
                    { 7, "Văn bản pháp lý và các thông tin liên quan", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACIAAAAiCAYAAAA6RwvCAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyJpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNiAoV2luZG93cykiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6N0E0N0I1RkZGNjU0MTFFNThCQ0RENUI1MDdDREUzNDYiIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6N0E0N0I2MDBGNjU0MTFFNThCQ0RENUI1MDdDREUzNDYiPiA8eG1wTU06RGVyaXZlZEZyb20gc3RSZWY6aW5zdGFuY2VJRD0ieG1wLmlpZDo3QTQ3QjVGREY2NTQxMUU1OEJDREQ1QjUwN0NERTM0NiIgc3RSZWY6ZG9jdW1lbnRJRD0ieG1wLmRpZDo3QTQ3QjVGRUY2NTQxMUU1OEJDREQ1QjUwN0NERTM0NiIvPiA8L3JkZjpEZXNjcmlwdGlvbj4gPC9yZGY6UkRGPiA8L3g6eG1wbWV0YT4gPD94cGFja2V0IGVuZD0iciI/PkbZPA0AAAPvSURBVHjavFhdSBRRFD737q5/+ZNthqWEhZqCYFnYDz1EREUvPvhgDxX5EoEQBUEQQREk0UsQ+OBTENhLWYkkvlQGglgSCYYiRVrmD2tappbr7ty+O3M3xnFmdsvJAx+ud2bu/eac79xz7rDw/U30F1YO7AUqgFKgAMhR10LAENAPvAG6gN5EJ/YncA8DqoEq4BiwzuG+fIX96v8poA1oAZoB4bpIHI8cAGqBU7QyuwfcBTqcbuAuD9cBjR6QIDVHo5oz4dAkAZcVAuSdFQO3labqgXA8IpLAVf2XL4V46VliSdlEWljJJY4JDa+SRWKik7RPrdargT9zE11zI1KniBgCSt+sk9AGGklE5kBm0YUAtMgxHWPE1m0nvgHJ9fmpQcz+ZWWWNdgRkcI8tyQc0QUiEBDzo8TS8ogXIdSBDEwetVFbEolQN2lDj4h+TuCWn04kYp6Ra72LCdhvStFaFUdjILOI+NYaPJJuDKRtJBbcjgWTnTNxcQYP+vQwsuAOED+N8CB7F6adNCPXfCknjBGptmaHb18DsYwtpA0/1icXkz0UeV6TmCzhCZYcJL7rBjyZS9Hem27ZJIX0MEakatkGk1lI2ocmhGVMDwXL2U2+ylvwYZqDRziJ0WcUfX1JF7k29oK4JBTEJpyUCW/NOoWqKkakXO2YS00KU2pE6kG6e25EJ2Zcs9NIgMQUdnTmJ152HsQr8dMIq//gAxLf+inafRHzRaxPyrXL/ap22G/bjBvykYvMfyHxvol44Um4O8f27VjeYaKSM8TlX/N4dpkBZKCY/YhwPyHx9W3sslx7r18VsHhBN3Sz8zoEfPyfdzSWd0jPCobUjrQfMV+q4KqKxuER1eOuZ40X5ku1jpRyVcrdTYvo4mXJ6z3hIUKvrEMF3NRPuLs1q4QoJegNEWwFFsvhieqDZRUlVmviThdBBg3YtgGhuPqQ23rWNm+88WMYJWDcOhziqr1zJcJSc4mtLfGGCPYTsTBpHR7iqsd090jqBr3oeWIzg7r4LdbPVaProlK/vhkZm9sKTbPXh+TAVbc95ShUlHe2fpc3YfkVIvF9GRG5dhdXLX+bc7MTAJEKb8Lya8IQ61KTa/fG/N2yPJ/8etFja/J1sXoj1AG7otdi7uKbVcu/pMmRtYHnH/WsexbjnXbHjGZzhybUuWNPrEuL9lxBpT1BIoyua7pvZQzQx4qpPtJG2s2jg2pNYXfAqlMtv5fHCNumErhgbp6tOdmgzhz/2+rNJJzONfWmlj/wHzxRb/eydkTC6vATUi1/sUckpCbuWD2RyNeABnXuWJVDeLzPEh3q3NGawGcJux3Ts88Sq/ah5rcAAwDazj74cjt0egAAAABJRU5ErkJggg==", "Văn bản pháp lý" },
                    { 6, "Chương trình đào tạo cho nhân viên", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAoIAAAKCCAYAAABF8LgVAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAADZaSURBVHja7N13uKxXXf/v1yGFkJAOhIRuKAKCIL33IhB6jUjviAIK+hMQ+QqioEIoivSEJr1IkSCgFKX3Ir2XUBMS0nPO749ngAROktP2njUz931d5zr7bMpe8/nMzH7Pep611oZNmzYFAMDqOYcSAAAIggAACIIAAAiCAAAIggAACIIAAAiCAAAIggAACIIAAAiCAAAIggAACIIAAAiCAAAIggAACIIAAAiCAAAIggAACIIAAAiCAAAIggAACIIAAAiCAAAIggAACIIAAIIgAACCIAAAgiAAAIIgAACCIAAAgiAAAIIgAACCIAAAgiAAAIIgAACCIAAAgiAAAIIgAACCIAAAgiAAAIIgAACCIAAAgiAAAIIgAACCIAAAgiAAAIIgAACCIACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCAAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgAgCAIAIAgCACAIAgCwJnZWAmAL7V5d9Ez+s7dV51MiWFgvrJ59Jv/Z55RneW3YtGmTKgBn5rrVgbOvb1/dWUlg5Ty4+uns67dXRyuJIAgsrz2qv559/dDqXEoCzLyz+vjs649W/6YkgiCwHP66una1b/V7ygGcjZOq982+vlO/mjVEEAQGt1u1Z3XB6s2z7x2kLMA2+mF1SvWa6omzfyMIAgO6dvWX1e8rBbBGHth06fijSiEIAmO4R3Xl6mFKAayDjdXDq/+qPq0cgiAwH7eu7jALggDr7atN9xI+pPq5cgiCwPrYubpx9aqm+wEB5umL1SeqP6hOVQ5BEFgb+1Xnr95T7VXtoiTAQI6rnlL9jVIIgsCOdUD1puqqSgEM7q+qD1ZHKoUgCGy/v6luUF1LKYAF8ofVS5VBEAS23eur2yoDsIA2Nh1d98Tqf5RDEAS23D7VC5rOAQZYZMc0LXD7iFKsn3MoASysv65+IgQCS2LvphnBKyqFIAictSdWj682KAWwRHap3tt0AhKCILAZT64eowzAktqjemP13OrCyrG23CMIi+Up1aOUAVgRX62uWR2lFGvDjCAsjicKgcCK+a3qw02b5CMIwsr661wOBlbThao3KIMgCKvqSU0LQwBW1UHV9ZVhx3OPIIzt76o/VwaAftS0XdZ7lUIQhFXwhKazOAGYHF3dtOm+QXYAl4ZhTLtlU1WAX7dP06bTV1GKHcOMIIxnp+qI6lClANis7zXdN8h2MiMIY9m9eo0QCHCW9qjuowzbz4wgjGXfpvODAThrp1X3r16kFNvOjCCMY//qPcoAsEV2ajqG7npKIQjCMjii+h1lANhiOwuCgiAsg9+rDlYGgK32hKYjODcoxdZzjyDM31WaFohcWCkAtj3TKMHW21kJYO5vXL+9pCHwpMonTRjTbkv2eDZWr6rurLVb+UvIjCDM1QHVt6pdFnT8x1Tf2cz3T2s6F/R4LYYh/WV1h818/xyzD6eL6CvVdavvaq8gCIvgHNVDq2cs4NhfMwt7L6jeoZWwVF7adMXwutWBCzb2F2V/QUEQFsgivQA/Ur2yOrV6utbB0rtadZ3qqQs05s9UD2w6ho4t4B5BmJ/nN82q7TT4OI9puoT0f23+MjCwnD44+/O/TfcU3mkWskb2O7MAKwhuITOCMB97VZ9u7EUiJ1W3b5oJ/IGWwcrbefYB9pbVeQb/8HrtptlBzoZ9BGE+nj54CHxfddfqrUIgMHNqda+mRW7/O/A49266v3EXLRMEYURXqC438Pge1XRf0Bu0CtiMjdUNqmc23TIyomfPxokgCMO5RXXlQcf2iOoftAg4GydVf1zdpmnblhE9S5sEQRjNhurEwca0qXpOdcWsBga2zhebZgdHXEj2B9qzBb+ULBaBdXXFpntrzjnQmN7XdD+NNwNgW52/+lhj7Tt4VHWl7HZwlswIwvrZrbrVYCGw6j+EQGA7fb+6evWFgcZ0QNPepwiCMIT9qv832JgeWT1Ja4Ad4JvVIdVHBxrTz7RFEIRRnDrYeB5ePU1bgB3oS9WHBxrPVav7aosgCCPYe6Cx/GV1mJYAa+CxTfcej3DLyf5NW3YhCMLcvWeQcfy8+qR2AGvkx017kY7ip1oiCMIIRtjc9Kjqnk0nhgCspcMHGcfVqoO1QxCEefrTap8BxvHd6rXaAayDe1fPGGAcN206exhBEObmD6rd5zyG46u7awWwjl41yDiO0wpBEObpmAHG8JXqc1oBrKMPNcYWVQdWu2iHIAir7MZKAKyzU5qO1py3Z1aX1A5BEObl5AHGsLs2AHPwjsY4ccQJSoIgzMV9qt+b8xie0LRiGGC9/Ve2rBIEYYVdtTrPnMdwZHWCVgBzsrH5b6F1ojYIgjAPIwSwfbUBmKO7V1+d8xh+VxsEQVhFH6u+oQzAHJ3W/O/Re502CIKwil5UfUYZgBXn0rAgCCvp3EoAyBxoCgAwLzesTlUGQRAAWD0/VAJBEABYTTspgSAIAIAgCCvjNCUAYEQ7KwHsMJc+k++fV2kAEARhudzpdF+fr3qWkgAgCMJyuk51q9nXF67uuiDj/rnWAbA5GzZt2qQKcNbeWO1eXb5p5m/RfLn6enVMdUftBObk3NVPm98k1InVubRBEISzsm/TFgd3q/589r0LLNHj+87s77+u3tC0uevR2g4IgoIgrLIDqotXb6r2W6HH/b2mex2/UP3I0wAQBAVBWCUPnL0p3b26+grX4b+q11QnVc/3tAAEQUEQltn9q+vOAiBndHj1zuolSgEIgoIgLIsDqzfPvr58Vs2flZOqz84C8yeqjUoCCIKCICyivZo2dX5PdZBybPUb53eqm1VHVccpCSAILg9HzLHsblO9rmkLFSFw6+1WHTyr37/N6gnAkjAjyDJ7YXVvZdjhnld9vPoXpQC2ghnBAblHimX02KZTQG6qFGvi/rO/d6/+UTkAFpcZQZbJbat/qi6mFOtiU9OJJQ+qjlQO4GyYERQEYU1cqrp09XqlmJtbVl9supcQQBAUBGFdXKV6e9PRcMzXUdXNm7abARAEF4BVwyyq81XPaToSTggcwwHVG2d92Uc5AMZnRpBFtHf1oeqSSjGszzbN1p6gFMCMGcEBmRFk0exXfVgIHN5lqw9WF67OqRwAgiBsj92b7j97b3UJ5VgIl6u+Ub2o2lU5AMZjH0EW5QPLS6vbKcVCulu1YfY3AIIgbJW3ZXPoRXfXplldR9QBDMSlYUb/oPJ2IXBp3Lp6Q7WTUgAIgnBW9mjaikQIXC63qV5Z7aYUAIIgbM45qyOqWyjFUrpD9YLMDALMnXsEGdFrm44sY3kd2rSf1+2VAmB+zAgymiOFwJVxu6bL/wAIgqy4czUtDLmJUqyUXywgsek0gCDIitqjaQGBhSGr6TbV4VlAArDu3CPICM/Bl1aHKMVKu8vs77sqBYAgyOp4ay4H86swuHvT5WIA1oFLw8zLLk0LQ1Y1BJ60BX9W0SHV6708ANaHGUHm5cUrEgI/v5nvvbz6xy343z6uuu1mvn/pJa/Z71XnrX7oZQKwtjZs2rRJFVhvF6leU115CR/bt6oPzL7+evXoNfgZT6suMPv6utUBS1jHjzbNDn7PywWWxrmrnza/SagTm3aoQBBkjg6q3lxdcYke03Orr8y+fucsxKyXa1bXnn3929W9l6iuH6xuVf3IywYEQUFQEGTxna96d3WZJXgsX60eOPv6P0d5PVc3mn394n41a7jIPlVdrzraywcEQUFQEGSxXan6yAKP/5TqmKYzkL9a/XjgsZ6n6V7C153u34vqstXnvHxAEBQEdzyrhlkvV6zeu8Djf391v6ZFDB8ePATWdDn1vbPxnrfpvsJF9T/V5byEAHY8M4Ksl8+1mKtdX1d9vHriEvTgCdUVWsx9+j5UXc3LCBaaGcEBmRFkPdy96f7ARfL+poUXd1iSEFj1+Or2s8e1aJfoL1Ld0UsJYMcyI8hau13TvnmLco7sj6qbVd9suVerHlBdsGnxzp4LMubjZ8H8P7ysYCGZERyQGUHW2hUXJAQe17QFzJWrj7X8W5Yc1bTNzVVmj/v4BRjz7k2Xts/pZQWwY5gRZK3sWj2yevICjPXYpnNu37bC/bp99dIF+bR8sabNuoHFYkZwQGYEWSunLUgIPKW664qHwJoWxRy6IGP9cy8vAEGQsR2xAGN8SHX96q3aVdUbmjZvfsTg43xQ9ULtAth+Lg2zFvaovlPtPej4NlYPbjoajs374+qwgcd3VHVw9XOtgoXh0vCAzAiyFv5t4BBY9SdC4Nl6RmNfgj2geoE2AQiCjOUq1W8NPL6HVc/Spi3ylOpRA4/vkk2riAEQBBnEnavLDDq2BwiBW+0fqocPOrYrVrfRIgBBkDFcr3FXnt6/ep4WbZPDmmZSR3TfplloAARB5miX6vLVQYON67SmVabP16Lt8qym1cSjbTx9oep3mt/N5wALzaphdpQDq+8ONqafVY9rWvjAjvHm6pYDjssm0+Pau7rG6f79nerTyrKSrBoekE/R7Ag7NZ0iMprvC4E73Eur32+8qwk/1pqh3K669Ozra8+eM79w1Olelyc33YcKzIkZQXaEXauTBhzXjat3as8Od9Pq7YON6TXVnbRmrvbuVxt937ItPxP6jdU7qmcr4dIzIygIsqT2abosPMoL7MTqZtV7tGbN3KJ6y0DjOa3aq/HuYVwFOzcdUfi71YW3o39faVrZ/99KKggKguvHYhF2hP8c7MX1h0LgmvtU06X3UezUNKvE+tq9enV1yHaEwF/075LVu5ouJQOCIAvi2tX5BxrPV6ovacua+3bTrOvnlGJl7dJ0Kfi2O/h30rubtqICBEEWwP9XXWCQsXy6aYPhT2rLuvhU9daBxnNwdVdtWTevqe6yBv+/O8+eV7+vxCAIMr6jBxrLF6vPasm6+pfqE4OM5YDq1lqyLt6yxrXevXp5dSOlhrVlsQjb40HV06rdBhjLD6tLVMdoy7rbs+lS8V4DjOWE2fPyCG1ZM69q/VZoH990ZOU3lH0pWCwyIDOCbK/dBhnHu4TAuTm2cbbpOVe1h5asmYtXl1rHn7d706zgTkoPgiBjuVDj3MNzRO4Nm7eR6n+0dqyZhzQdJbmeXpBZHBAEGc5lGud+rMdrx9xtqJ4wyFge0TRzxY51jTl9+Du5Ok75QRBkLKO8MZ9a7asdc3dS0yrSUwcYy1Wq/bRkhwf9y1a/PYefvUtjrU4HQZCVt3PjzLg8ItvFjOJz1WMHGctv5b6yHemCze8IuA1NVyAAQZBBnK968QDj+HLT3oEbtWQIG6uPV18fYCyvaDr6kO23U3XHpjPF58XRgSAIMpBR9hx6R84lHc2R1fs8T5fKadU/zXkMBzQdHQkIggzglAHG8NnqGVoxpL9rjGP+TtGKHeKFzX/Wfb/qnloBgiBjePcAYzi++j+tGNJnm1Z6ztu7tGK77VnddJDfFSdpBwiCjOGgOf/8U6qPasPQPtR0SXGVn6fL4IWNcZb4CY1zlCEIgqy8eW8RcnT1YG0Y2n2qn6/483QZnDDIOL5ePUY7QBBkDPO+CX+DFgxvpwH6ZDX59rlldZ2Bnk+AIMgAnlftP+cxnKYNC2GES8PP1IZt/rB19eqinksgCMLpXa5pQ+l5uq42LEQIvN6cx7Br02kYbL2rVo8aZCwnV9fXEhAEGcMIK/eO1YaFcKzn60I6V9OZwuccZDy75qxhEAThdHZWgoWwixIsbN8eP9B4npE9IUEQhJnHVD9UhoXw7eqJyrBwDh9sPP8gCIIgyDjmfdP2u6oTtWEhHF+9Z8Wfr4vm3NUtBhrPo6qjtAUEQcZw4WqfOY9hD21YKLvP+efv1xgbIi+KtzTdkzeCo5o2kT5ZW0AQZAyPq66oDCyQa1SPVIYtcq3BQvNrq//UFhAEGccJSsACcivBlrlPdfAgY/li9TItAUEQgLX3+00niYziG9X/aAsIgnB6j2/+iw/YOm+tnqoMQ9u1ukJ1wCDj+Xl1B20BQRB+3XHZRmLRnNK0ephxXaj624HG8x/ZNB4EQfB8XRoblGBY56weMdiY/kBbwC9WANYnCD50sDHtpy0gCAKw9s5VbRxoPPfKyUEgCAKwLt490O+B7zZtIH2qtoAgCMDaukF1noHG84/VJ7UFBEEA1t5fVecdZCwfaZqdBARBYMlsVILh3LO6/EDj+Uz1cW0BQRDOyklKsHB2q/ZShuF6cpXGWZ37jepPtAUEQTg7l632VYaF8vvVI5VhKNdsnC1jTqveWf1MW0AQhLPzwOpqyrBQXBYeyz7V3Qcaz07VfbUFBEEWw24DjMERc2wtJ5v8yh7VvQcaz5/4PQSCIIvj8dVHlYEFstGHhzP494HGckr1yswagyDIwvhe8z8M3mH0i+W4Of/8d1ZP1IaqDq4uN9B47lf9QFtAEMRzZmvcqulYLMZ37upmcx7DaZkR/IXXVzsPMpbPV/9XbdIWEARhazyusU5D4MwdVD1KGYZwp+p8g4XSD2kLCIKwLdxTtBhOVoJh3Lk6YJCxfLh6kZaAIMhiGuGy7PHasBD2H2AMu2lDu1WnDjSen1Vf1hYQBFlMH2r+91xdUxuGt1P133Mew0nVx7Siu87+jOCk6pNaAuPYsGmTe3XZat+rzj/Hn39Ktas2DB8Ef1rtOccxfL262Ir34cDq6U2XhkdwbI4cXGXnnr0vzGvR0olZbPgbzAiyiM+bo7VgeKc1/xWh3t/qggOFwKo/1hLwC53Ft8ucf/6+1Qu1YWgvbTrFYpWfp/O2x6wPI304eImXBgiCLL6vzvnn71xdRhuGdb7q6k2Xh1f5eTpvl6ouOdB4bpEV/yAIshRuMsAY9qourxVDelrTKRbzdtMV78N/DDSWT1ZfywbSIAiyFEbYkuPS1UO0Ykg/8zydu3sO9vifWX3JSwMEQZbDhkHGcbPqhtoxlFs0HQPoeTpfD22+K7ZP7x2zP4AgyJI4qjp0gHFctLpc878XjcnO1RWaVqrO2+2btqlYRX9W/c4gYzmt+lT1TS8PEARZHqdV3x5kLE+rLqIlQ/jt6omDjOV7rebChP2q32ucvdK+nPOmQRBkKe0+yDg2NN0PtYuWzNVu1d0b43Ls+6sfrGgfrlXdbZCxnNS0XYwFIjAwJ4uwrQ6qDqvuOFAgZL5B8IRBxnJo9YoV7MGB1RHVjQcZjxOA+HVOFhmQGUG21Xerdw0ylk3Va7Vkrkaq/6oeYbb/QCGwgT4kAoIga+TU6vgBxrGhunZ1Hi2Zi32bLkmO4CXV4SvYg3NW/znQeH5Uvc9LAwRBltvzqtcPMpbzVc/VknV3yeq91d6DjGeXpss/q+akWSAfxd2qn3h5gCDI8hvpl8+lmrYvYf08oLrsIGP5XvXqFe3DgwZ7P9/DSwMEQVbDExpnK5nLVG+orqgt6+JK1SEDjedr1etWtBePa3434P+6V1Yf9PIAQZDV8KHqOwON5yJNlytZWxdsOst2lFpvarpndRU9tXHujz2t+t/q+14iIAiyOm7cOFuHVL20uom2rKkrNdbinE0r2vPzNs2Aj7JNy39Xz/LyAEGQ1XJKY+3NtHN1pDC4Zg5pugQ/kldUJ69gL+5W3WiQsRxbvblpVhAQBFkhpzbO0WKn99bqrtqzQ92jetOA43rQCvbiEo21V99xTUc+AoIgK+a06p8HHNfO1W21Z4e686DjWsU9JC9aXWeg8Rzq5QGCIKvrh9VDBhzXrauHac8O8ejGuQx5eveovrVivdiraXXuKI5quj8QEARZUadWn6m+Odi4zlU9o3qoFm2XP63+vulM4ZF8rfp8q3df2g0aaw/P329asAMIgqyw9zbWLMXpPSszg9vqz6t/GHRsL6o+soI9edVAY3l79QMvExAEoerl1acHHdszmma22HKPqf5u0LF9tHGOOFxPf9VYs2/Pb6y9RAFBkDn6RPXVxr1M9A/VI7XpbO1aPbYxV4M3e359oel2hFWyc3Wn6pyDjOfV1Tu9XGCx31RgR7tL06WivQYd3z827Tn39upL2vUbbtM0s7v7wGP8YXWfFezN3zQdpTiC46uPVT/1koHFZUaQtXBS9drBx/jM6ovVTbXrDG7dtFn07oOP83Wz59kquWjTKSKjvG9/sXFvGwAEQebsfgsyzrdWt9OuaprJfeMCjPPp1YNXsD83r242yFiOa9wFRIAgyAB2ajHuxdup6Wzi26xwr67YdJn88AUZ72Er2qfjBhrLCdXLvM3B4nOPIGvllKbjpvaq/nrwse7edFbtj5o2TF6V+wb3rC5WvavaZ0HG/KhWc4XqwYMF4KO9xcFyMCPIWvt4003loztXdaHqQ9U1qvMveV8uWH24+uQChcBjq0/NPmSskp2ajpLbb6AxXd9bGwiCsCXeVN27aZXnItin+p+me+UeXG1Ysn7sMntcb64utUDj/m519+rIFXwNnda0cfZIr+mfe2uD5bBh0yanArEuPlNddgHH/ZamvREfuwQ9eEp1+cZZcLA1PtA0U7uK/rF6xEAfSq7Sap7mwvY7d9N2Q/O6Le3Epqs/CILMwWVmv8z3XNDxf7R6TvXCauMCjfscTecs37O60oLW/kfVtZs2kF4152jak3P/QcbzjNmHomO9pSEICoKwtX63aXZtUW1sWrl5i+p71Y+rYwYd64Gz8P26Wfhe5Evcl2x1N/4+vOmS+Ai38RxXPaR6ibcyBMHl+rQJ6+V7Cx4Ez9G0Cvp91VeaNl4+ZKDx7TQbzyFNi3T+czbeRQ6BH2lx7i9diwD82wO9T79LCITlY/sY1tMPmu5P+/fqqkvweK4/+3N49fXZ9/6j6RL4eo/hF8Hhbkv0fHlv00knR6/o6+WuA71OflAd4S0Mlo9Lw8zDBZouWV51CR/b9/rVjfRfq/5kB////3l1rdP9+xrVeZawjh9o2uT7Byv6GrlS04bNo6zs/r/q0t662E4uDQ/IjCDz8J3ZL5ZlDIIHdsbLxbc6k//eY5qOt/t1b+us9zD8rRV4fnyz6T7Mn67o6+McswA40vY+t/S2BcvJjCDz/GX3phX/BbPxTOqy6l5d3XmFH/9+TfdFjvJc+Fh15covC7aXGcFBfxnDvELQrZo2Nl7l19+v/1l1r1nxELihaaufkZ4LdxACQRCEtXKb6pXKQNNihDuteA02Vf800Hie37hbJAGCIEtgY9MRdK9TipX20ur+ytCLmo6UG8VrW917NUEQhHVyQtO2J/+uFCvpVdV9qpOVois17Qc5gsOa9g4EBEFYcyc37Rn3FqVYKa+u7lKdohRdttptoPFsEM5BEIT1dqumy1Esv39rtReG/LpHV5cYZCxfa/PbGwGCIKy5u81CAsvrxdWhyvBLN62uO9B4vlK9XVtAEIR5OKXpnrE3KMVSekX1wGxJcvr34StUFx1kPD+dvf4AQRDm5oTq9llAsmxeXf1B7j07vd+unjTQeD5efUtbQBCEedvUtIBEGFyeEHjnzASe3jlnNRnpuM9baQsIgjCSW2fT6UV3eBaGbM7G6vEDjecwQR0EQRjRvZpmlFgsH6huUN1PKTZrtA84z206jxUQBGEoJ1Z/WB1YfVY5FsLHqptU/1Wdqhy/Yd9ZSB7F46ovaQsIgjCqk6rvV1erPqMcw/p604kU16iOU44z9bJqn0HG8v3qE9nYGwRBWAA/r65XPb36tnIM5avVLasbZWXwWbl29VsDjeed1Zu1BQRBWBQ/qR5RHVL9UDmG8J2mhT2fU4qzdbvqUoOM5evVs7QEBEFYRJ9oulR8i6YVmKy/k6sbV9fK/Ztb4qZN97uOFOA/oC0gCMKi+lr1tqbZwS8ox7rZWD24adHDO6tvKMkWOWd13sGCKSAIwsJ7a9MpDY9WijX3hurh1XOq45Vji+1ZXX+g8bxO/2C1bdi0yd6hLKX7V79XPUgpdnhw+N/qH5Rim1ywsY5v27c6WltYJ+duOst6XifpnFidSxvOaGclYEk9b/b362d/P7u6uLJslzc03dtmBmnb7FQdMdiY9hcEYbWZEWRV7F99qNq72qvaRUm2yHFNM1g3q35UnaAk2+x81VEDjed+TUf/2eyb9WJGcEDuEWRV/Lg6uDpPdZ+my5ucuRNmNbpmdZlZGBQCt8+RA43lW02bsguBsOJcGmYVvXT25zHVFas7KMkvvbJpj8b/brxzcBfZjRtrpfCLqg9qCyAIssqeNPv7PtU9q+uucC2OnAW/F3parIk/qg4aZCyf6Ff3zgKCIKy8F1Zvqi7StIry7bPvL/OtE7/YfPs7TadcfCWLBtbKXavrDDSeL8zCIIAgCDM/mv1pFgar/qa6VdMGwBdYgsf47aZTQF5d/e3se6c1nd3M2jhX0+0H+w0ynh82zYADVFYNw5bYr3rx6f59yAKN/efVu2ZfH9q0Cpj1c6XqI4OMZVPTvYH31RbmxKphQRCWwsOatqOp6bLfpQYb31tOFz4+1nTZm/W3Z/XMpvtPh3nP1xYEQQRB2HEu0XSs3S8cOguH6+kx1adP9+93Z+ZvBPv3q9sNRvDwpo3VbRmDIIggCGtkt858deg7mvYx3Bbva5qJ3JyvKvuQPtp0zOEITqgu17QoCARBfsliEdjxbzRnFswusR3/vxuVdqFcqrrkQOP5UyEQEARhvoS51fHyptmPEXy++pSWAJvjiDmAHe/ogcby5ur9WgIIggBr70+qKw80nj20BDgzLg2zORdagsfwLW30PJnD82SP6qrVXoM8vs9Uj/ZUBQRBzsre1dVmXx9QHbEEj+ne1XebbpB3k/yOc6mmo/guWv3rEjyeu1U/mX39/rb/lJWbN20hNIJTms6QdnIMcKZsH7PaHth0nNr1Zr/AltEXmo6J+7J2b/eHhQdXD6gutqSP8Q3VB5uOYXvBNvzvD2jaQPpOgzye03zYZzC2jxEEGcDvVo+dfX3HFXnM/9d0ieyus1+ObJ3dmjapvvoKPebXzP5+3Oz5syUuO3uejeJe1eGevgiCgqAguNp2n/39yqZ97ParzruitXh/dYOmS2ZsmV2r/22cjZHX2/erY5q2X7nX7HvHb+a/t1PT7PPBg4z7pKbNy50wgyAoCAqCK+pS1TX61X1cuypJVe+pbj375c5Z2796W3UVpajq5Nnf92w6NeRLp/vPrth0rvMoDmk6c9obPIKgICgIrphLN83eHN40S8FvOrK6szB4ls5Tva66jlKc6S+U+1UfaFqM9M3GWUX98eoPq89qE4KgIHh23Ei8PJ466+ct276jzFbBTavXVn9QHaUcv+GCTSdjCIFnbrfqpbOw9Y5qz4HGdoQQCGwpM4KL7wnVDatrK8VWu0zT8Vuc0ZWqjyjDQvrvptlA+2gyIjOCAzIjuLhuXz27Or9SbLMjW45NkXfoh8PqrcqwkE5tWrUsBAKC4BK7XNNM1r8pxXY7sLpm9T9K8UvXr86nDAvpB9UfKQMgCC6nCzfNAj6+2kc5doidZoH6wkrxS69WgoV0avXPygAIgsvppU0zgZdXih3OyuEz+knTtjEs3nv5k5QBEASXy65N+7jdUCnWzIbZ6+BUpeiwpnOEWTy3mT2Xrf4Dtso5lGDYcHJY0+oqIXBtXbp6njJU07ZDNh5fTP8nBALbwozgmP6h+mNlWLcPQ7spQ/WrkzNYLB9s88feAQiCC+hZ1UOVYV2ZSWGRPbn6tjIAguBie2R18+omSgFsodc1zQgCCIIL7I+ajohzz+Z8nFMJKpfIF80p1Uer7ysFsK0Ej/l7SPVMvZib45tOY6A+0XQEE4vTr79VBkAQXFwPbTomjvn5UtMm3dRf5HiyRfHz6mXKAAiCi+sRTQtDmK+dlMB7wgI6uWmLKQBv+gvokdU/KcMQNiqBeiyg2yoBsCNs2LTJzhnr7CFNM4EblGII56l+rAy/dGD1XWUY2neri1cnKAUL5txNByXMa6HqidW5tOGMzAiufwh8thA4jHdWRyvDGfyker8yDO2OQiAgCC6eh2VhyEheXd2sOk0pzuCk6sbVG5ViSG+tvqMMgCC4WP6seoYyDOVFQuCZOrF6uTIM6ZXVN5UBEAQXw87Vw6unKMVQnl69RxnO0tuq5ynDcGx+DuzwoMLauXL1NGUYyj83bd3DWTu2ekDT9jr3UY5hXFwJAEFwcdxJCYbx9upT1aOVYqvcdxYKL1fdUDnm7tFNi808j4EdwvYxa+c51QOVYQivr+7SdDYr22b3pgU2t1CKIRzWdNsJLBLbxwiCQiDr6gvVvatPV8cpx3bbu7pM00KSiyrHXP189ksVBEFBUBAczB7Vh2a/MJfJIp1B+8fVe5uO4TrWU3KH26vaZfb1I6p7LMi4L7REPdjYdLvDodkLE0FQEBQEh3GB6vnVzZfk8Xx+FgC/XD1Ue1lwz5+FwYtVl1iSx/S31WO0FkFQENxWFovsWDdYkhD4d7O/n119W1tZEveb/X3w6b7+iwV/TNepDsqxgMA2MiO44xxY/Xt1pQV+DI+pPtp0yQlWwS2qq1ePW+DH8MnqljlxhPGZERQEl9YuTZdPL7xg4z5x9kvknrN/f0ErWVGXmv39qtnXi7Zx81WrD2sjgqAgKAjOx5WqjyzYmL9TXXP2t6PWYLJz04ro9zTN8i+KnzfNbH5GCxEEBcGt4Yi5HeNNCzTWY6uXVddvOrNUCIRfObVpdv8ms9fJCQsy7j2qN2gfIAiuv/vP3oQXwV9Ud6juPvtlB2zeZ2evkzu2OPcP7tPibOUDDMKl4e33nqaVe6O7d/Vi7YJt8tDqWQswzrdUt9IuBuXS8IDMCG6fP2m6SXtk/9h0r5MQCNvu2bPX0b8MPs4bVffRLkAQXHvnaVokMvLqwqdVf1Z9X7tgu32/esjgYXC36mrVvtoFCIJr64rVHw48vn+sHqlNsMM9pGmGcFQPqC6pTYAguHbO17jHOr2q6Sb3P9MmWDN/NHudjbpjwJMyKwhsAYtFts1lmlYVjuaNTYfQH69FsC72bFqgMeKCsfNXR2kRA7FYZEBmBLfNuwcbz8bZL6M7CIGwro6tPj7o2C6uPcDZMSO49W7SdDlot9F6qTUwN/9cPXiwMR3XNGMJozAjOCAzglvvuQOGwKdWO2kNzM1DGm+fwZ2qB2kNIAjuWD8ebDxPqh6do+Jg3h5W/dNA4zlX06IWAEFwB/n76nIDjee51WO1BYbxqOrlA43nuBbnCExAEBza+avfrXYdZDwbq49oCwxlY/WhgcZzteoJ2gIIgtvv0OpmA33Kf2j1PG2B4RxWPbw6YZDxXKm6lLYAguD2OXqgsZxYPUdLYOgwuHGQsVy/uqGWAILgtvvd6q8GGs/ttQSGd9vBPjwCCILbaKfqIoOM5QeNdQ8SsHkfrL4/yFieNftACyAIbqVdqxsNMpZPV1evTtIWGN6x1d0GGcvu2WsUEAS3yT7VUwYZy99VX9MSWBjfqN4xyFh+qh2AILj1Th1oLPtqByyUr1VvGGQsL8jxWoAguNVGOavzDdVLtAMWzsurIwcYxw1yAhEgCG619wwwhuOrD1c/0w5YOEc3LfCa976CG7NgBPg1GzZt2qQKZ+3b1QXmPIYvVL+tFbDQPjFAEDuq6ZQkmIdzN92ruvOcfv6JuT3iN5gR3LJP0fN0fPU4bYCFN8I9vsdpAyAIbrnDqgPmPIZTq1drBSy8OzX/rZ9cAgIEwa1w5aZ9BOfpe9UGrYCF96HqnHMewy7V/loBCIJb5pgBxnBDn+JhKexS/decx3CR6nCtAATBs3f96hKD/PIAFt8p1aEDjONUrQAEwbN31+riegTsQPsJgoAguBiOHWAMD2zavgZYDl+uHjHnMdy0eohWAILgWTtxgDF8s+lyErAcTqq+Pucx7Jm9BAFB8CxduLrCnMfwqer7WgFLZ4RjK10eBgTBs3CD6lZzHsOLmk4iAJbLB6t3KQMgCI5rhMvC59YGWEpfbP7byGzUBkAQHNuuSgBLa/c5//xHVzfWBkAQHNOPm1YXAqyFPavdlAEQBDdv3ieKvLM6QhtgaY1w64cTiwBBcDMuUP3lnMfgsjAstxdWn1YGQBAcz37VdZQBWEMfb9onFEAQHMxpSgCsg3mfI36cFgCC4Jj2UQJgjd202kMZQBBkLD+unq0MwBr7y+ogZQBBkLH8sHqNMsDSG2FRmFthQBBkMDspAayEu1TfVQZAEBzL0UoArIMfVKcqAyAIjuW+SgCskw1KAAiCY/l/SgAACIKr6UQlAAAEQQAABEHWzX5KAAAIgqtnY/X3ygCsk58oAQiCjBUEn6oMwDo5PCuXQRBkKOdWAmCdHCIIgiAIwHzsPeeff6wWgCAIwHy8RAkAQRBgNf2REgCCIMBq2l8JAEEQAABBEAAAQRAAAEEQAABBEAAAQRAAWBjHKYEgCACspjvmSENBEABYSc+pdlIGQRAAWD0/UQJBEABYTRvn/PN30wJBEABYf5et9pjzGP5HGwRBAGD9HVZdcM5juLM2CIIAwPob4f7AvbVBEAQA1tf9q5sqgyAIAKye/RtjNs7WNYIgALCODqguP8A4PlQdrR2CIACwfi5T3W2AcTy++pZ2CIIAwPo4T/XUQcayj3YIggDA+jmoutIA4zixOkk7BEEAYH1crnrfIGN5VvV6LREEAYD18dJqT2UQBAGA1XLX6sCBxnMuLTlzOysBALCD3KF64UDh6+PV32uLIAgArK1bV6+odhlkPKdVn862MYIgALCmDqneONiYvlfdU2vOmnsEAYDtccfqTQOOa3+tEQQBgLVzl+plg47tHtpz9lwaBgC21mWbLgUfVO064PiOb8xZSkEQAFhYB1YXqt5d7T7wOA+pTtYuQRAA2DEuVP179buDj/MD1Te1SxAEALbfE6t9qmssQAis+pfqy9omCAIA2+5hTYtBrrVg495L6wRBAM7epmqjMqykPZpm+X7dG6uLzL7er8XbXeQN1fO1VxAE4OztUt1UGFxJf1rdfAkf1/uqE7VXEATg7O1evV0ZWAInV4+snq0UW2fDpk2bVOGMTqh2m9PPPrXatzpOG2Al7F/9SBlgh/z+3EUZtp6TRQCARXZyy3mZWxAEADgb96reqQyCIACwWr5efVEZBEEAYLV8vrpt9VGlEAQBgNXypeqTyiAIAgCr5RPVvZVh+9lHEABYJJ+srl6dpBTbz4wgALAo3l9dVwgUBAGA1fI/1e2qnynFjuPSMAAwuo9Wt8lJPIIgALBSPlldK5eD14RLwwDAqD5cXVMIFAQBgNXy3upm1fFKIQgCAKvjA9Udq58qxdpyjyAAMJKPVTevjlEKQRAAWB2fqK5RnawU68OlYQBg3r5W/Wt1HSFwfZkRBADm6dtNewR+WikEQQBgdfywul71VaWYD5eGAYD1dlx1o+pgIVAQBABWx1uqO1Xvqo5VjvlyaRgAWA/Padoa5nlKIQgCAKvh9dXh1RuVQhAEAJbfidU3q1tU38sxcYIgALD0Tqg+X927+ky1UUkEQQBgub2u+ll1ZPUK5RAEAYDl9pXqabOvn60cgiAAsNz+pnr77OvvNh0NhyAIACywk5tO+fh196s+crp//0ipBEEAlsOp1X8pA9VLqiOUQRAEYHX8vLqJMsDqcsQcwOra4PcACIIAAAiCAAAIggAACIIAAAiCAAAIggAACIIAAAiCbLfjlABWxo+VABAE+YWdqn9SBlgZ/6wEwDxt2LRpkyqc0QnVbnP8+T+oDtAGWAnHVHvN8ef/rNq32qgVsJrMCI75iwHwegcQBOdgNyUAVsReSgCCIGc073v0TtMCWBnzviT75Mr9QSAIcjpPnfPPv1D1OG2ApffE5n8/8FMEQRAEOaP95vzz96iuoQ2w9K7T/G9F2U8bQBBkPLtXBykDLK0LVedUBkAQZHOuV91DGWBpPai6mjIAguB4dhpkHHeofkc7YOlcqbqF3wGAN4Exfbl67ADjuHJ1sHbA0rl0dYUBxvHI6lvaAYIgZ3RC9dlBxvLSpl3/geVwUPWcQcbyqeokLQFBkN+09yDjOHd1c+2ApXGLpp0BvM8BguDAPlZ9YJCxvLz6Qy2BhffA6nmDjOW/G+fKByAIDufT1ZEDjeeI6gHaAgvrjxvnknDVv1df0BZAEDxzo102eVZ1T22BhfOg6mmDjWkfbQEEwbP2jerYgcazS/XiXCaGRXK/6l8Ge689JquFgZkNmzY5ZvIsfLC66oDjukf1Eu2Bod2/eu6A4/rP6ibaA5QZwbPz5Nmn59EcUT2jurEWwXBuNXt9jhgCf1Q9XYuAXzAjePa+Wx046Nh+Un2uumv1Ha2Cufqt6vDq8tVeg47xq9moHjidnZXgbB01cBDcr7p29eHqGtUp1Q+qU7UN1sWu1XmqN1UXb/y9+X6gZcDpmRE8e3tXRy/QeP+1enV1YvV+7YM1cZ1ZCLzH7M+i2KM6XvsAQXDLna9pVnARPWr29yty6Ri218WqO1Qbqqcs4PgPb9rU2rFygCC4Fc5Z/WX1Vwv8GD7RGTePPaJ6q9bCWbpddZfT/ft3qssu8OM5uOkeQQBBcBs8ufqLJXksP6u+vZnv36PlO3bq5Gqjp+8OtUu105I8lv0781OELtI45wJvr7+qntp0ywjAL1kssuU+1nSv4D5L8Fj2qi6zme//b3XakvXtjdX/a1pdzfb5xXPm1U0rZJfBOZru9VtmP5m9fwmBwG8wI7h1XlndWRkW0hOaVle/RSm22q2bVqX/hVIspBc0nXACIAhup5tXz68uoBQL615NN82zZR7QtBKdxfT1WQh8p1IAm+Nkka3zHy3uCmImL2g6YutaSnG2HioELrxvC4HAWTEjuPUOaLrEeCGlWGjHNh3R9+HKi+CMDq7eM3uu76QcC+sr1dWbjpUD2CwzglvvqOoGyrDw9pyFHSHwN12vOkgIXIo+CoGAILgGjmm6vMjiP/8PVYYzuG/T5XMW21ur45QBEATXxo+q2zfdM8ji2qV6WfUgpajqT5oWQ7HYXt90AsoxSgEIgmvn2Oqu1QeUYuHd0muhc1S38VRYaJuqtzVtDG/PQEAQXAfHNB3fxmK7edMK2VX26Oo6ngoL7buzMO+SMCAIrqMH556qRbdzddKK1+CUnDS06N446yOAILjO7lc9VxkW2p2qi63oY79UdYinwEI7LLPagCA4Vw+snqkMC+vG1SVX9LFftmmrERbTU6uHKwMgCM7fIzIzuMhOXtHHfZLWL6zDqj9XBkAQHMNpTTOD7hkE1tqzm2YCbYoOCIKDuV/2YwPWzjOqP1IGYHtZJbh27l99qLpd9fvKAewAr2vayP55SgEIguN7XvWq6rXVjZQD2A5vbtos+udKAewoLg2vvWOaTq54d3WUcvhg5HGzlb7XNAt4ByEQEAQX00nVDasrVP+nHEP6/AoH9e9WX/IUGNJnqt9pur3kZOUABMHF9v3ZG/oTcyD8aJ5efWpFH/uHq3/1FBjKD2fvEzerfqIcwFpxSWj9fb16XPXv1WWqFynJEPZd8ce/j6fAMP6g6crBx5QCWGsbNm2yBdWc3aVpq5lzK8XcHDnrw9ErXIP9qjdU1/F0mJvjqkNnHxIB1oVLw/P3yqbZqCdVn1SOdXdi06XRo1e8Dj+Z1cEpI+vvE9VjZ+8DQiCwrswIjudfq8tV11CKdfHt6kLK8Es/bpodZO29p/p0NoYGBEF+zX5N9wk9SkhZc/eqDleGX3pAFo6spROrR8++fnF1rJIAgiBn5hLVAU2LSvxy3vEOrV6hDL/hPjkvey3cs+n2D7eAAIIgW+28s7+PqC5f7VHtrSzb5JSmmcCXK8WZuu/sw8dOSrFNjq6Ob7rv8v6z7/1QWQBBkB3litVTZ1/vXF1PSbbIO6uXZdueLfHQ6lnKsMXeXW2cff2wpk3KAQRB1sWT+9W+kA/KdjSb88SmPRzZcg+orjT7mzP6ab+6hH6i5xYgCDKKa1UX/LXvPbvaf0Xr8ZLqLU1b9bBt7lLdvrrzij7+71R/+mvf+0b1AU8NQBBkEVy02n0z379c0+rFZXObpq1hqr6S/fF2hN1nz6Oq36pevaSB98ub+f6x1bc8BQBBEACApeBkEQAAQRAAAEEQAABBEAAAQRAAAEEQAABBEAAAQRAAAEEQAABBEAAAQRAAAEEQAABBEAAAQRAAAEEQAABBEAAAQRAAAEEQAABBEAAAQRAAAEEQAABBEAAAQRAAAEEQAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAEASVAABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBABAEAQAQBAEAEAQBAJiT/38ANUMwUjNpHy0AAAAASUVORK5CYII=", "Đào tạo" },
                    { 2, "Tổng hợp báo chí ngành bưu điện", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACIAAAAiCAYAAAA6RwvCAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyJpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNiAoV2luZG93cykiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6NThEMEMwOTdGNjU0MTFFNTk1MEVBNzY0QzU3RjkwMkUiIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6NThEMEMwOThGNjU0MTFFNTk1MEVBNzY0QzU3RjkwMkUiPiA8eG1wTU06RGVyaXZlZEZyb20gc3RSZWY6aW5zdGFuY2VJRD0ieG1wLmlpZDo1OEQwQzA5NUY2NTQxMUU1OTUwRUE3NjRDNTdGOTAyRSIgc3RSZWY6ZG9jdW1lbnRJRD0ieG1wLmRpZDo1OEQwQzA5NkY2NTQxMUU1OTUwRUE3NjRDNTdGOTAyRSIvPiA8L3JkZjpEZXNjcmlwdGlvbj4gPC9yZGY6UkRGPiA8L3g6eG1wbWV0YT4gPD94cGFja2V0IGVuZD0iciI/Pg3tNXoAAAUDSURBVHjavFhdaBxVFD53djb/qSZpjKlJjVZqI8pqUGgwWrWCokLQvokUivggsf7gk0G0fTCCLwUhD/VFqSAKKRoL7YsPFcGU2lYjjVHpX2qtbTZNzc/mZ3dnrt+998zsT2ZnN3bbwx52dvbOPd893znnnjsi+cU6WoXEoN3QLmgntAPazP/Foeeg49AT0BHoaKkT2yWMEdBt0F7oM9DGAuPaWHv49zT0IHQYuh8qQ40U8chj0B3Q7XRtsg/6KfRwoQFWyMN90L1lAEE8x16es2RqKqD9rFEqn2yE7uGYGoAmi3lEAXi/zCA8ifLc/cWo6QsadB2kP58mOy8wX8/2hKi5jax7XiOqhjele22mpUPu6S9JXvre84yyNeYFsJ2VojuYR/+W1fkqibp2cs8fKJZ9xWtA/QaKdL1H6YNbs2NG2VTIpAdkW2B2VLeQO/ENuWeHsIZ6zAYmLcSyTBvswjZLcB0GKsy3iJhrN2l+J2eIKpvIbns6KJvUKoc8IL3+X5FKjV4m/jITWVESa+4i+6lDuLZJLk+TqGggcpZJLl2GkVntNbLr2LDCuUC0fAX378B8FeT88gG8+m0hens9IDGumAZHrJ/E2gfJOfo2Jk5xSINSu1qv0j25h0TLIySideRe/I7ELd0k588CGEAsTZFoeoDcU5+TaH+WxE13Gw9GqsJYU7ZjFu8dftkWrVvIHR8kOXvaADBrxCcTI+4ZBN0cjC9cBAsA6Kb1iuXVk/q+aH2caA7PK894zxcWZbvb4g0sI4kLWEGN8YbmmmNZmEwXDfeRhdXKxX+IatfDUzUkattI3NwJb9yPAQJe2owkWSK5cKmEAq6ly+ZdNJNlM3+QaH4I++hQhlPFvboGGGv9c9o4pWEoMWFipDFGEagGjnFy4QJZtz8PcJv4+eViQDpt3sozQOJHUTt2miyRKZ0Zcv48pQ89aTxjRXxQOms0fa6553DVtmwzFgGtvuTiZcTUmjAgHXZWP2GAKO7tWu1unZZCGJpUCioDWbGiwMjkv0SpOX0tqlvNeG+Md63+DwfSvGLTk4m/8eC8iXgdpIaeSM8nqAWNuSkIb8iJr8n59SMSt25BwdodAMQh58ibRIvxoo1RnBsaI+kE4mQcKfqwST1dpODlI28YKijAI+ru1DFyfng5L0tMgZMqu6qaw3DEbW7v2nK8gjS0NryoY8ObVCpqdBbJ3ObNWTSXKkuSVzPVNQuIjh0hwoCcs7nH7MkF8htoWEsCbpXSMa579LNwalp6QM0uE8Srp2bc5kY3N05mftcUiYZ79UR6wcfeWUmNqg8o5fqZKz+TM7IzeONVRa6yMQzICZu77emcphjBSvOoEdhjvBiRs2f8opYjvL9QahZjTvnjc0RV2KqmQiCU7RGbW37Vbb+UM//UcYqs2+pTYT/xVQlZ87+oUbZHvfQdzgcip37yM0NTM/ohF6q8Bk+Veh1XY+QcfzeAF2QNvBtS0IazG6P93PJvzwTsmM4Er1rKyZHwIr00ie5rsnCDpjJuJbX72LYPRPK5Y7PfpSFO5OSPZHW8oHuUwPhYRZso6u/khsqXP9mmDDpg9XHLH/V71k2vYJdt97OnTD2ranTegg6GnfR2cct/PWU32wk9YA1ktfzlPtukeP6BUk56SUYb55Z/Y5lAqJj4OJuOUt8GDPK544Ycwou9ljjM544DJbyWCKqYZXstccNe1PwnwACS0PTewGsMBwAAAABJRU5ErkJggg==", "Tổng hợp báo chí" },
                    { 4, "Văn bản quản lý tem bưu chính", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACIAAAAiCAYAAAA6RwvCAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyJpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNiAoV2luZG93cykiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6NDc0MDdCNjZGNjU0MTFFNTkxNjFBRTlFMzYwNTdCQ0EiIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6NDc0MDdCNjdGNjU0MTFFNTkxNjFBRTlFMzYwNTdCQ0EiPiA8eG1wTU06RGVyaXZlZEZyb20gc3RSZWY6aW5zdGFuY2VJRD0ieG1wLmlpZDo0NzQwN0I2NEY2NTQxMUU1OTE2MUFFOUUzNjA1N0JDQSIgc3RSZWY6ZG9jdW1lbnRJRD0ieG1wLmRpZDo0NzQwN0I2NUY2NTQxMUU1OTE2MUFFOUUzNjA1N0JDQSIvPiA8L3JkZjpEZXNjcmlwdGlvbj4gPC9yZGY6UkRGPiA8L3g6eG1wbWV0YT4gPD94cGFja2V0IGVuZD0iciI/Pq9cyNUAAAYrSURBVHjavFhZbFRV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", "Tem bưu chính" },
                    { 3, "Văn bản quản lý chất lượng dịch vụ", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACIAAAAiCAYAAAA6RwvCAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyJpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNiAoV2luZG93cykiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6NjkxQTQ0RTZGNjU0MTFFNUExQzg4ODBDMTA1NzU1MDciIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6NjkxQTQ0RTdGNjU0MTFFNUExQzg4ODBDMTA1NzU1MDciPiA8eG1wTU06RGVyaXZlZEZyb20gc3RSZWY6aW5zdGFuY2VJRD0ieG1wLmlpZDo2OTFBNDRFNEY2NTQxMUU1QTFDODg4MEMxMDU3NTUwNyIgc3RSZWY6ZG9jdW1lbnRJRD0ieG1wLmRpZDo2OTFBNDRFNUY2NTQxMUU1QTFDODg4MEMxMDU3NTUwNyIvPiA8L3JkZjpEZXNjcmlwdGlvbj4gPC9yZGY6UkRGPiA8L3g6eG1wbWV0YT4gPD94cGFja2V0IGVuZD0iciI/PhZuB0EAAAahSURBVHjaxFhZbJVF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", "Quản lý chất lượng" },
                    { 1, "Bưu điện Việt Nam vì một cuộc sống xanh", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACIAAAAiCAYAAAA6RwvCAAAACXBIWXMAAAsTAAALEwEAmpwYAAAF0WlUWHRYTUw6Y29tLmFkb2JlLnhtcAAAAAAAPD94cGFja2V0IGJlZ2luPSLvu78iIGlkPSJXNU0wTXBDZWhpSHpyZVN6TlRjemtjOWQiPz4gPHg6eG1wbWV0YSB4bWxuczp4PSJhZG9iZTpuczptZXRhLyIgeDp4bXB0az0iQWRvYmUgWE1QIENvcmUgNS42LWMxNDUgNzkuMTYzNDk5LCAyMDE4LzA4LzEzLTE2OjQwOjIyICAgICAgICAiPiA8cmRmOlJERiB4bWxuczpyZGY9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkvMDIvMjItcmRmLXN5bnRheC1ucyMiPiA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0iIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdEV2dD0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlRXZlbnQjIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOnBob3Rvc2hvcD0iaHR0cDovL25zLmFkb2JlLmNvbS9waG90b3Nob3AvMS4wLyIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ0MgMjAxOSAoV2luZG93cykiIHhtcDpDcmVhdGVEYXRlPSIyMDE5LTA3LTI5VDE0OjE5OjI3KzA3OjAwIiB4bXA6TWV0YWRhdGFEYXRlPSIyMDE5LTA3LTI5VDE0OjE5OjI3KzA3OjAwIiB4bXA6TW9kaWZ5RGF0ZT0iMjAxOS0wNy0yOVQxNDoxOToyNyswNzowMCIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDpkNjIzZmNiNS1hMGI4LTkwNGEtYTFhZC0zZDdmZDc0YTQwNTgiIHhtcE1NOkRvY3VtZW50SUQ9ImFkb2JlOmRvY2lkOnBob3Rvc2hvcDpmYzMyMzBkNS1jYTVlLTg5NDUtYTg1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", "Nói không với rác thải nhựa" },
                    { 5, "Tổng hợp thông tin thi đua khen thưởng", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACIAAAAiCAYAAAA6RwvCAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyJpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNiAoV2luZG93cykiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6OTIxOUQ2ODlGNjU0MTFFNTlCRjdCODcwQ0I4ODQ0MUYiIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6OTIxOUQ2OEFGNjU0MTFFNTlCRjdCODcwQ0I4ODQ0MUYiPiA8eG1wTU06RGVyaXZlZEZyb20gc3RSZWY6aW5zdGFuY2VJRD0ieG1wLmlpZDo5MjE5RDY4N0Y2NTQxMUU1OUJGN0I4NzBDQjg4NDQxRiIgc3RSZWY6ZG9jdW1lbnRJRD0ieG1wLmRpZDo5MjE5RDY4OEY2NTQxMUU1OUJGN0I4NzBDQjg4NDQxRiIvPiA8L3JkZjpEZXNjcmlwdGlvbj4gPC9yZGY6UkRGPiA8L3g6eG1wbWV0YT4gPD94cGFja2V0IGVuZD0iciI/Pronfv4AAASwSURBVHjavFh9aFVlGP+d95xrm9o1XUOzq83UpSTONtOkL5H6I/8ZtT4QotgfQTAqijIbWFsfwyAygkEDQ6iosFYtwQgyF0GjWUutpS6X0zaTWVdrNud155x+73veO++d52t084Ef9577Pu/zPOd5n6/3Gpl3Z2MCVEGsIiqJxUQZUarXThB9xH6ii+gg9sYVbMXgMYgaoppYS8wI4Etp3KSf08QOoo1oJdxQJREeWU3UEg/gv9FbxFaiPYhBhGyuI1oKYAS0jBYtM/bRTCLqNRIoHJUTm3VMNRGZKI9IA54rsBFZSmjZ9VFHU+fH9D9Q/fhjssYF5qPSarOyAWLB/b4S3JE/YXc+Cff41xdG/qybYa54BUZRie9e59A7sLsasp6RurqzASxyUrRWnyNwbggwi31hTEnBrHoRRvGsfCP4rH7netBeJTc/Zmq17jFDanKzwz64Be6JzuCcTy6AWLo+/4z5LH8PIilPyvXJpppcQ6rzljN/0YWNfIPTgYLF1fdBzF/nfS+rUc+BRDlKHuX6UHXWkApdMfPfIL0Hdvdr4SV3ylxiDkTFhlA+KUfKCyCpu0Lo3uFbtp2Db8I99qW/q0/+CPvAGxDXPQtjcnB1lvulnBCSulcJ3cD8ycnA/uF54MzgOFcPwd79DMSctQqBxH1qv5OJSudKobto8Bv9/QvsfS/nu/rnZp73KZjLNoYfCffJ/TFosdCtPJScX9+Hc/hD73v/Z3T1FpgrX2UzmBa8h/xyX0wqEznzRLgxh7fpAE3BWv02wLhQRvVsVZ/u6aO+/DGp1IrLaViTqewI8ywBp/c9uIPfAJcwzhJJLy3PpmGULIO49hF6arrHPwFL5Dzymx5ookkqpkJx1Z1eDSmiM4cHAFlNGZjSQOfIx2N8E6B+S4938Qw5e5KxsZnF6141cI3uvIfBeAjGtIWw1nwAc+aN7De3wP72iYk2wT6hZ8xYE6NY8pgyQmVS51OqYlq3f0oDT/F5vfpdrks+3ULi0n5LD7rRZiTnw1z4IOvHBjgDn8NgEzOXvwRj6lyYS59mCd8I+9gXMFJ3wFzyONyj22lYb1xDuiw9badDhmLPkMuXwx3qYwx8wmPYRgOY9ZOS3tqVt8EqXcH1XozuWgcx727yXx/XEKm7Q+iRf0ekRy5bpFLWSEyF+8d3Y0acHzCTqsMasrYUz/T445HUvTfbfduiuF2mqKwhorIR9p4mKt2dvz7YoSqpqHpB9R7Xv9P6UVvuGNCqR/5gQ9LeXUmUruRb0xtWkbcwOux9yqGJaSt4hLn8Ma4ZrbmjoqvvHTeMTWkXGPKTqp5G4lK4o/+w+3bDHdgJ5/ddELPXsHaUwJXzi2EqPskfQT1apzt+eJaz4+uyt/puG2HB2reJCqdDXPMQHDY+53g7xBW3wpGt/kALzEUPq/6j+EYGw4w4p3W1h930GvTI7z+ZldcyXTkIGXwHlvHzrfYMG4zNONmk+k8ENWo9oVfOyAuWMYM9Zd5dTNEqBmYK7nA/M+l7NrqPwiaxrCea/C5YYXffOj3ylxfoLtOjj6N5ov8GNOt7x0W5hEeNAXLjV8T2GH9L+FXMgv0tcdH+qPlXgAEAz4qvPjrNlwkAAAAASUVORK5CYII=", "Thi đua - khen thưởng" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 8, "PhoneNumber", "1900 54 54 81" },
                    { 12, "Ra mắt nền tảng mã địa chỉ bưu chính - Vpostcode", "https://www.youtube.com/embed/iPEvFyikq-g" },
                    { 11, "Policy", "Ghi rõ nguồn \"www.vnpost.vn\" khi phát hành lại thông tin từ website này" },
                    { 10, "Location", "Địa chỉ: Số 05 đường Phạm Hùng - Mỹ Đình 2 - Nam Từ Liêm - Hà Nội - Việt Nam" },
                    { 9, "Company", "TỔNG CÔNG TY BƯU ĐIỆN VIỆT NAM - VIETNAM POST" },
                    { 7, "PhoneText", "Đường dây nóng hỗ trợ" },
                    { 1, "VN", "data:image/gif;base64,R0lGODlhGwASAOYAAOgAAuAACtgAE9YAFdIAGdAAGs8AG8kAH8cAIcAAJb4AJ70AJ7wAJ6sAI5gAH70AKLwAKLsAKLsAKboAKLoAKbkAKrcAK/3/Av3/A/z/BP3/Bfz/Bvn/B/r/B/n/CP7/Af/9Af7/Av/9Av/2Af/6Af/7Af/1Af7rAP7tAP3lAP3fAPzYAPzTAPvQAPrJAPivAPewAPajAPagAPWQAPWUAPWIAPSFAPSAAPN+APOAAPOBAPN9APJ6APF1AO9QAO5OAO5DAO0/AOw5AO02AOwuAOwvAOwlAOslAOseAOsWAOoQAOgCAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACwAAAAAGwASAAAHxIANgoOEhYaHComKi4yNiw4NjowLko+RlQoJRAiYCpCYCwQtAQyYn5USQxk/FKaXiw8UshYzGjEVshQPjaeKC0k2Ojw7KRgoOTw4NUaUlo0FOx0bHR8kItIdNALNir2+EkgsICXkISpCE9zdr4wSAykXICEmSq2O3osQSiMeHxwYQOzxYreIwg0NLoLA2PACgiR8iRYcWCHDAIUEPU4AcDjQ0YMlPiDsWhChyBGOjCAmSoAyUcuUBDtVguSgps2bOHPiDAQAOw==" },
                    { 5, "Mess", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAADE0lEQVRYR+2WTU4bQRCFv8JSyA44AeYEmBNgToBzAvAmjFdxThA4QZyVTTaYE8Q+QcwJYk6AOUHMjiSKK6qenh+PZ+wxREKR0tLIkqen+9WrV69KeOElL3w//x4A7VKngvKbe2kxeS6DSxnQz9RQjlHq4J68NQbsGUjAcF1AuQD0kgbKB6BWcOADsJXzborQljOuywKZA6BXbPODK6DhD3hAGQAje7KUu/0/qTuGlAbCrv9uzAZNeeuYWbpiAP7yr3HUygWv6UiT6apDovfa5RSh49mZoryRlgNfuByAzOW3Fs1TBebOeqSDcAJM2eBoGRMhgC59/8Etm9TXibootNSZEzY5KDpTnNJnfAMs37WnRp4HRHtOA/sI7+XMpWZhSYxUuZAW52XzXWaf8wzBdDWRgL0iACOEQzY4yOZKu1TZ4JAZNxEzrkStBF8xNFp9JRwzc8a0IDjtMnHVoezlsSvaQw2ZBIu2HFMIYwk4cICEOxeJp1UvaaN8dP9tspPNtXYJA1SOzCMQ+nLmSjs8piSAoQQ05gAoTWnRXxsAHAN9CWiGACKEeSkIS6rGa8ZRZN6eq+koXK4tzzm9QXvOR7YidlLV8UkC2saAqfMdyrW0OC0jrrJ7vDGZs95KkNi69lwKrMfsGQNJXnNYKHtZdp83NyvvKj5dsWOGlj8xm4+M6BxxzWelc5UBlHXWdPQxiJCF3aQXRKZhIEp4+BIHNEa/+J5SaG7axQWdbUbfUwf3Cc2p1NDhPeMEpQ1so9xToVHUB5wYoZ4ASFwrG9wYYYAwSk9B7sIKu8ycuKwKohZu3w/Z5LTI/32K7lCGCYC0oYQQioaOYhkoN8D5qhYcl6KJPhZF0hEtbx2bBdy7RxeZebpFuj93u9EsGEMjZgzKpGvBB1IA3NSz9hBiJfWL6qrpJzPmxb4wJ8J15wCvZBOdzYcmVtOKVVE4ihlrStVrxH6jNZWAnXDLM5efgKzJWKrmU5ScPfSgLJWH7m/fuJ4NII3fg0km6QrTnBZvFWNzhxPrXwWwDpkG1lL+YgAisP8B/AE6nGKNmot1GAAAAABJRU5ErkJggg==" },
                    { 4, "Search-price", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAADGUlEQVRYR8WXTVYTQRDHf5WFYWc4gfEEwgkgJyCeQLKRZEVyAuEEZpfBDeEEJicwnMDkBOIJDDvxPWlfdfd8ZnpmwPd0dvC6u3719a+K8MzPzOginADHQBc48E/dAXcIK4SlvGddZUKeat8b/gCcNry7wnApI1Zl558EYCLOgWnhoQ2gRraZ/x8jHBXOzWkzkUHuHI0BTMR1zmvDJTCXERrync9c0+EXpxgugJf+wJo2vSxEI4CC8Q2GfshwkcSC/GSK8K4MohbAXDHG8NFfXtLmtBjGJrVgZswzEHMZMtB7lQCW/oFvQAfY0OY4ZNzMuEA4lyH7IaAchKGnhVkNkKX2F4L5frBR0s7o0+a2DNQ7pDWjNbGSIb0gQM57w42MytvOfOKAR774KCV8MiyPbi6lLQ7DAFf0MXy2Lwpv5YxFqfczKzqvECY8WtHp0qIjZzvtaq97x364P7gMA7icquDcy9DWQOlnIoxlDHgcgFaVPMJwWwWQHhpZuS0HiCPgxCioeNnLvmDVubu/B9Aa+M3CpsF9K1pMqmZABiDchmZmh4kLU0UEYs/MzBappk1BthgOgyqZprcSwAlHQ4AEJLLFeuLToTK885nIFqjOlU1VF6QK2Ga/qfolj7t6CAF89eN7WVUDOu9VBbVdBjJiXnQloxXaiguM3QvcmDa8LkuBH+fuXWFSrYSR7es3sWqVArhB008mnuG7QoTmfyb8DjLUXtYJLSyxYzgYhUwR2qKt0oOc915d66dh2udbWvRC7WVbC7pByXaDTSXbrW4+RU+ZhnptTYtB3Z4XqJXUuObeS3XdMEovpa9uEcZyxk1V+jKp0fVMJ2XseW6wlQL46i4znrWpOZ/zgmXp6I3sxuzGc0KzO1V3AGqM39vlM5Xd+GntlvxSmg+P3huXtXIOoMZ4shH57hj7Fq3KhBqessc0JGQJQFPjWWu2rVr0ebT5VRHSz/0wabEO7RDZNyzAc4w3KcAmZ+R/GrdqXFiXs9CVW3AT75qckXilKhz+J8ZdBNKBEzP8M+MOIF2pOhgW7DFuOvubhLjuzB9Hh2lzHqyLfAAAAABJRU5ErkJggg==" },
                    { 3, "Logo", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAgYAAABQCAIAAADtFSo0AAAACXBIWXMAAAsTAAALEwEAmpwYAAAKT2lDQ1BQaG90b3Nob3AgSUNDIHByb2ZpbGUAAHjanVNnVFPpFj333vRCS4iAlEtvUhUIIFJCi4AUkSYqIQkQSoghodkVUcERRUUEG8igiAOOjoCMFVEsDIoK2AfkIaKOg6OIisr74Xuja9a89+bN/rXXPues852zzwfACAyWSDNRNYAMqUIeEeCDx8TG4eQuQIEKJHAAEAizZCFz/SMBAPh+PDwrIsAHvgABeNMLCADATZvAMByH/w/qQplcAYCEAcB0kThLCIAUAEB6jkKmAEBGAYCdmCZTAKAEAGDLY2LjAFAtAGAnf+bTAICd+Jl7AQBblCEVAaCRACATZYhEAGg7AKzPVopFAFgwABRmS8Q5ANgtADBJV2ZIALC3AMDOEAuyAAgMADBRiIUpAAR7AGDIIyN4AISZABRG8lc88SuuEOcqAAB4mbI8uSQ5RYFbCC1xB1dXLh4ozkkXKxQ2YQJhmkAuwnmZGTKBNA/g88wAAKCRFRHgg/P9eM4Ors7ONo62Dl8t6r8G/yJiYuP+5c+rcEAAAOF0ftH+LC+zGoA7BoBt/qIl7gRoXgugdfeLZrIPQLUAoOnaV/Nw+H48PEWhkLnZ2eXk5NhKxEJbYcpXff5nwl/AV/1s+X48/Pf14L7iJIEyXYFHBPjgwsz0TKUcz5IJhGLc5o9H/LcL//wd0yLESWK5WCoU41EScY5EmozzMqUiiUKSKcUl0v9k4t8s+wM+3zUAsGo+AXuRLahdYwP2SycQWHTA4vcAAPK7b8HUKAgDgGiD4c93/+8//UegJQCAZkmScQAAXkQkLlTKsz/HCAAARKCBKrBBG/TBGCzABhzBBdzBC/xgNoRCJMTCQhBCCmSAHHJgKayCQiiGzbAdKmAv1EAdNMBRaIaTcA4uwlW4Dj1wD/phCJ7BKLyBCQRByAgTYSHaiAFiilgjjggXmYX4IcFIBBKLJCDJiBRRIkuRNUgxUopUIFVIHfI9cgI5h1xGupE7yAAygvyGvEcxlIGyUT3UDLVDuag3GoRGogvQZHQxmo8WoJvQcrQaPYw2oefQq2gP2o8+Q8cwwOgYBzPEbDAuxsNCsTgsCZNjy7EirAyrxhqwVqwDu4n1Y8+xdwQSgUXACTYEd0IgYR5BSFhMWE7YSKggHCQ0EdoJNwkDhFHCJyKTqEu0JroR+cQYYjIxh1hILCPWEo8TLxB7iEPENyQSiUMyJ7mQAkmxpFTSEtJG0m5SI+ksqZs0SBojk8naZGuyBzmULCAryIXkneTD5DPkG+Qh8lsKnWJAcaT4U+IoUspqShnlEOU05QZlmDJBVaOaUt2ooVQRNY9aQq2htlKvUYeoEzR1mjnNgxZJS6WtopXTGmgXaPdpr+h0uhHdlR5Ol9BX0svpR+iX6AP0dwwNhhWDx4hnKBmbGAcYZxl3GK+YTKYZ04sZx1QwNzHrmOeZD5lvVVgqtip8FZHKCpVKlSaVGyovVKmqpqreqgtV81XLVI+pXlN9rkZVM1PjqQnUlqtVqp1Q61MbU2epO6iHqmeob1Q/pH5Z/YkGWcNMw09DpFGgsV/jvMYgC2MZs3gsIWsNq4Z1gTXEJrHN2Xx2KruY/R27iz2qqaE5QzNKM1ezUvOUZj8H45hx+Jx0TgnnKKeX836K3hTvKeIpG6Y0TLkxZVxrqpaXllirSKtRq0frvTau7aedpr1Fu1n7gQ5Bx0onXCdHZ4/OBZ3nU9lT3acKpxZNPTr1ri6qa6UbobtEd79up+6Ynr5egJ5Mb6feeb3n+hx9L/1U/W36p/VHDFgGswwkBtsMzhg8xTVxbzwdL8fb8VFDXcNAQ6VhlWGX4YSRudE8o9VGjUYPjGnGXOMk423GbcajJgYmISZLTepN7ppSTbmmKaY7TDtMx83MzaLN1pk1mz0x1zLnm+eb15vft2BaeFostqi2uGVJsuRaplnutrxuhVo5WaVYVVpds0atna0l1rutu6cRp7lOk06rntZnw7Dxtsm2qbcZsOXYBtuutm22fWFnYhdnt8Wuw+6TvZN9un2N/T0HDYfZDqsdWh1+c7RyFDpWOt6azpzuP33F9JbpL2dYzxDP2DPjthPLKcRpnVOb00dnF2e5c4PziIuJS4LLLpc+Lpsbxt3IveRKdPVxXeF60vWdm7Obwu2o26/uNu5p7ofcn8w0nymeWTNz0MPIQ+BR5dE/C5+VMGvfrH5PQ0+BZ7XnIy9jL5FXrdewt6V3qvdh7xc+9j5yn+M+4zw33jLeWV/MN8C3yLfLT8Nvnl+F30N/I/9k/3r/0QCngCUBZwOJgUGBWwL7+Hp8Ib+OPzrbZfay2e1BjKC5QRVBj4KtguXBrSFoyOyQrSH355jOkc5pDoVQfujW0Adh5mGLw34MJ4WHhVeGP45wiFga0TGXNXfR3ENz30T6RJZE3ptnMU85ry1KNSo+qi5qPNo3ujS6P8YuZlnM1VidWElsSxw5LiquNm5svt/87fOH4p3iC+N7F5gvyF1weaHOwvSFpxapLhIsOpZATIhOOJTwQRAqqBaMJfITdyWOCnnCHcJnIi/RNtGI2ENcKh5O8kgqTXqS7JG8NXkkxTOlLOW5hCepkLxMDUzdmzqeFpp2IG0yPTq9MYOSkZBxQqohTZO2Z+pn5mZ2y6xlhbL+xW6Lty8elQfJa7OQrAVZLQq2QqboVFoo1yoHsmdlV2a/zYnKOZarnivN7cyzytuQN5zvn//tEsIS4ZK2pYZLVy0dWOa9rGo5sjxxedsK4xUFK4ZWBqw8uIq2Km3VT6vtV5eufr0mek1rgV7ByoLBtQFr6wtVCuWFfevc1+1dT1gvWd+1YfqGnRs+FYmKrhTbF5cVf9go3HjlG4dvyr+Z3JS0qavEuWTPZtJm6ebeLZ5bDpaql+aXDm4N2dq0Dd9WtO319kXbL5fNKNu7g7ZDuaO/PLi8ZafJzs07P1SkVPRU+lQ27tLdtWHX+G7R7ht7vPY07NXbW7z3/T7JvttVAVVN1WbVZftJ+7P3P66Jqun4lvttXa1ObXHtxwPSA/0HIw6217nU1R3SPVRSj9Yr60cOxx++/p3vdy0NNg1VjZzG4iNwRHnk6fcJ3/ceDTradox7rOEH0x92HWcdL2pCmvKaRptTmvtbYlu6T8w+0dbq3nr8R9sfD5w0PFl5SvNUyWna6YLTk2fyz4ydlZ19fi753GDborZ752PO32oPb++6EHTh0kX/i+c7vDvOXPK4dPKy2+UTV7hXmq86X23qdOo8/pPTT8e7nLuarrlca7nuer21e2b36RueN87d9L158Rb/1tWeOT3dvfN6b/fF9/XfFt1+cif9zsu72Xcn7q28T7xf9EDtQdlD3YfVP1v+3Njv3H9qwHeg89HcR/cGhYPP/pH1jw9DBY+Zj8uGDYbrnjg+OTniP3L96fynQ89kzyaeF/6i/suuFxYvfvjV69fO0ZjRoZfyl5O/bXyl/erA6xmv28bCxh6+yXgzMV70VvvtwXfcdx3vo98PT+R8IH8o/2j5sfVT0Kf7kxmTk/8EA5jz/GMzLdsAAAAgY0hSTQAAeiUAAICDAAD5/wAAgOkAAHUwAADqYAAAOpgAABdvkl/FRgAAUFtJREFUeNrsfXe8XVW19RhzrX1uepNOSANECSGgSFMgNDsgqCjCk2J97ylFbFjo2JVi+Z4NxScELFT1PaUjJRSBJKAUCb3XhLR79lpzfH+sfW5uQhKSgDzBM3/3BzfJPefus8ssY445JiWha13rWte61jXAuqega13rWte61g0JXeta17rWtcUs/it+6Pn36Kb96/m3tjKygS8eciaCMpM7zeRgzopWDeHOd3Wjb9e61rVuSPinM++9N1+9A9P8CskZ+aJ2UojscDA6MsxdNFKI9G5E6FrXutYNCf9stvABXDUl+nxnLUTABBD+QsMMSmDJIYeIkCwZxRxDgMJQvvESWDcgdK1rXXsZ2L+Sq8oL/YY9k55xR0AQYcgB+QW+qwiSJMVWbZaDk2YymVzE607ngPW691nXuta1bkj4ZzJvp+t25fy7LbVItSkAGSHzhb5xH/RE5aDMnClkBEk26ac2cuvuTda1rnXt5WL8F5lLyLcdiTk3GaOrTYYSJSQKMK5cWBA9uCVzkwFuMoVW1kJCpgHEQrkptLDuB23tPbp3WNe61rVuSPinMsGRDBEEIAlN88BIrWKd1GkXCyDgqE2V3BksA0Fw1oYIsHuHda1rXeuGhH+qgADKxQzFvhhQPjXJF/CmACBlkoJBOdOCHDCSfT/Qta51rWvdkPDPEg789mMx5y901pFVqmUBcDK4e/lmUcK/4hUC3WSQiQ4jXZbpRpoAYPW3Y+zHuuGga13r2svRXrEkVAF6+Cy763s5ClJLdDapu2AEpIwmJKzkKRMy3Cwww5nF6PAsjxYwdCLXO6B7V3Wta117mdorlnGkR36jGYeiIpEBOA0gIJRgACeJVWKgJpDBKPcgs0rqFWVAHroBtvxfWE/3rupa17r2MrVXJHAkf/IK+8u7PbnTGASwQxVdAuNfFcjfvNUbnq3UYwruWSEG5FwNsykzaYO6t1TXuta1bpXwz2Rz79RNH8oybxnpVFMclBDY73st/scVNY/tKlVgqC0rKiilONi2urQbD7rWta51q4RlJOoQAD76h3T7kXH+PRj1Rmx8PIZs+o/+PA7Zvf8v1/MMIhxwKALUyosZUQBdMCeCQ2QJKS6ZgjOTgItmWmtPDtmgezN1rWtd64aEpUeEOs+pZvynHv9jnTwGiPSUq9d8ERM+9Y8rTaRERggQRAEOBgiryDUVxKayKLWEWBNBAGVgYaAGd7euhFHXuta1bkhYRp4Of/yCOOOw1H4SoJmRzHIDHQpDN8PkkzB4Il/swOCAweGUZcJUWseKFMCEZmJ5pQKMRDdVoAMORAmiiJRRmUDWROhqnHata13rhoRlWHsOZv6nP/k7T5UFF7PELPTAEt1Ay5ZDbet/gRt89sWsD/J8XPdmzr4tG5wKoHKZSnMAJEVRSy8W+v56CWxJBCUTnSY6ZXTJ3FWiXO2TfhLW26s7k9a1rnWtGxKe41hR8/EL0/RDqUdNAxJyrKEIGFFLpkA4ApBJc4cN3ViTv8shk/hiuFS/8SB79DwPLreAALgkZxMUSK4guciWPBnmzA10xOzOigGwhF4bfYBNPKl7A3Wta13rhoQlggEw/wH89d/55LRMwZktVwgiJJk7GbKyEGhOIcEQUlVHmmPc57DBvyMMfUHxYOYn+fDUnN1igDvQCQWQWOinq0I2FRHcEnNNRs8VzFHlKoUErLO3TfpB9+7pWte61g0JiwUDuvy+/9Lfvx7a83J0egXWMFMucE2mAuANbmPODIZWVi88GnKuouK6NukHNnLrVVAcEpBvPTjee3o2mBGZMs8GE+F9FCFJIlca8U8Gcw80OiTJgpQDgTV2w+Y/7946Xeta17ohYfF4MP8B/e0T/uSVIdGDiy5jTAYpB1Al0Q7ZMtzM4J6JFlXLAJAM8AU5tpA9jvlk3ujwYENWqlurh07nzEMzSNZCCEAGKBW4CCg9AEhadYU7wOGGCO9NsQpDJnGrP5gN7N46Xeta17ohoXHFEnDvqenur1S9TzmNNLpAJiGCGZnPkQ/qEx91dxJkNLngQsvI2tph0Hr2mh/hVVuu+HHkp64K8jqIGdGYyxDBC/D+fcEjIxsy0SKZDfAMC+5eDX8dQnckrWtd61o3JPTZ3Ad0+yfy41dF9CbFSKsNEiOT3BhMOZPsD9+LixxuB9wPLtEcLgcqxGweHBr7IWz4ZcYhy3fdCSBoykQQRCaoAuDMhvBinBkHAKeTpgwLjmweuozTrnWta92Q0DhiQH7Pj3DX1+FzzeGQPNCSZDAFyQETssHUEuq+4iB01teQBFVLwZQRzBXgWa0cahNIk1yDxlUbn4RR2y+rJawFD3HBLNBBy2qbD5ZlZJdJtJWdUy7CqPQsa3iqlAcSdfRWjURFMYzg0EmvPLZpViIikVnOA7uE2q51rRsSVghR8TR3ejX9sDRvRkxVbTla5erNwaokGR1O0WKos1pwb4D8RXhRISCRhLuZScjKsBA8mpBDHRSzPLFdocrysNbunPRdhKFLeqlnb/dp75CeDs6ECuw1RCA7YKCkZbu1Zc4ldAoXkHQILoMrWHKSRDU0bPUnG7ThK+/yS9Iz1+qpK4IzTfikMZrF7lPRta79y9oK4iDCY3+0a3bNc2eSTLFm5VQdYMGTQnSkiB4SrNskHSQtG4qTLblncEQxOALMAUnRYsUotBUyXAk1qQqVEYHRHvkdLn+9Fs5a7EDSs37Dbsqzs5ANsjowmOAQkA0iA8BlfC0rKvYFDLrLMgJMjEwh0ClVr/2RDXqFShhR1rMW6/vzvf8vhtbLokooSYakvm+6j3HXuvZi2YqmhLrve+ZOxKRMCskg1YExB2dtIebcS5pGbFat9nYHSLfF400mSKoRhVB0wExKtIAke/wPPvc2enbmBAQiS9b7pB78Fdb/XOPQ89x03TvZ+0RgECSBkIskDQZYFmF5WVPKy/t0XBT7nADkUjAG7/HJp2CtXV+5RaJp0BgbNMnHjgbAF6cN8482h5usryjsgl1d69pLHBIEB0K2FIreWzDSlSoMdOslDDkGJAc4cket/1m32lBBGZ39xpIC0HCBVEJFFov2BABw1Dbhhj2TNXpyyRQYyBy8ZP1wzcW03ePcWxKRhUg6aECGSrHjdDDAtax6wJYRKpwoRNW+iTaSJtW0nk2+xbXf8wq+/A7YLYfg/jOSAe0H4mtPNv6zN9Ap0yNTecthSXVYd5964verblDoWtdeUuCIjOP+Q1UmsqVgRIIzxF70mpBNVO2WJa/v+y7/8o4w/9HibciiCmeAqe+b8gAzAFU5AMpgVTYYHZlCVSUYagdrLkCR2r5+P8y9JSNEkPQsmSyTNNGREYRguYykLR04cmKpX+WoAgJpIjo9D+tZZz+tvR9f0Rwju/Oo3gemYvS+rdH7VA+eqbu++DIAjp78n/bM/8TQjeKY/Xjfr+LtX+4+xl3r2ouXcq04FDv/Dt387z53OmWODGSi5UokAkPOWVVpyAazUWmjQ+KYj8EJE2TOmooEywaCzioCNA5X0NN/Tje8m65CGDKozJrZhp/FhE8D6NOgfgFYgS87BKacgwJCEcCuJP/nT5eX5i4f+u/00NSYKwVAGYpCHWxgVltINmxLbvglmBHwx/6Hc24lzd1lHhBQyyuTxOGv4ajdEKCFs/LCB23A2FCNBgky04MbDHX9tD371wD6qK0a1u/TV6YnplmoTZZgxoQcTJJRg0bbWvvAln7VUpobH/xlXc+Oiu4eIiWHspsCWr72ezlorCsFRJ/9Z3tiGjJhKTME1bAAIIOhtS5G7yu60mw88zcbPE4D1oSC0CzaBgDL+ekr4QPD0Nd6a6hBmPM3PPoHMbtF+gL4YLM2QqvOiXFIHPPvSz/m247E3BnKWcFABwQFZQTKrcJaexuRHzrdcuKozfXqE+gQQboydMcXNPcOA7Xeh2ytt3cdUNdensBRsUGv1rYX8e/fwF3fiNlACJlGlAycgXWyyITs6TH+7Sjc/xtscqKGbyolQwXUYFMWgAmI8AZDIjJVhVwbBib2mqqMNoxEDe+ELKOXrQV9wqUvuCRqwiGJHC0keSSJCpKXBTovvwg/7+Hq8WvdYA4vl8aQMwNTshZYgYEgnp1pNx6YkUgWGXEnzZil6A4z3/ZSDp5kD/7a7vy2V4Px+tM0fDtAdIO5y+L8W3HDu5NSeMvjALI/w798yPSkZTgVUlBFeQKYQq5SVYPVOvss/arc932/7ZsM7mIwuUxSoAneBqoHz8R2NwQmLXjApu2ZmQJCbYgJCMxQFloAFNQzQmu8lXNv4w1vTdWouNHXMPo9RHQUsXQiK1y7d0ZObzgnvupNkOXr3448R2LIA8mFySAyuVdWQRIDx37suQecZ8/UnGuD3Fw1UhQ9eEBIOZO0EVtr/U+Fh85Iz1yP2dfGwRtp3f3oBC0/+F+879SAjNXfyTW68aBrL/eQABiIDT6LtfbyGR/W3FuCkrNyADkxGjwyuQyszJxp3vXx2p3yhM+EDQ4H4IhWYoAARgA0hxNGRyBrmDmSAbI6uLlMVH76z7zTuXhdUNrUL5xoUt41KUWaO2gZChq6KdbclS9PyWsfuJ5WeyMQXa65t6KeTQ4KI1+XLUHC4EmlnZPTk2IbqsK6e6eB44KyI2TmSkGzvuWizZ3BIRORAbil+emad2Hyj8I6e5UJcSv0ruQxmGDuic/+LafHAgPW3s8HjTa4G6MyGHDnVxSjzX9gmZXN41ezggaMi2vtI7lVFXJ2eXzm6vzUNVxwf0abqNB7v4iglkbvbQNHi/K6xcpbzvrOYxFYzfkb13iHJ5HB0lzNPITtezDhsyV5EQGrMjKM0ejJEGvP8ypFjNoCw6cgwNwJ9Cjmx37BeQ/hqeuwtJBgwzfO1isL7iHOuRGpFlsYtTndCbBntBh801+Gv+yuZ6ZrxuEcurmGTUrP3hRu/5JBechE2/QHMGd37rFrL/eQ0GTnQzbUtpfgrh/4XccH1CFVijBJUh3RSgFyIAfrqRHCXd/E4/+TJ33XhkxsfDDhKDPG1lQJ7sJAhJwyWkKWsiG4Q6yfvtqevGYJjQotAoJWHWIBUDrRUZahwOyghkzG+P8wvFy5+TZ6H4zeB4Igu36P/NRVGjERrz87sCyJcwLKLlTRg0fU6+xTjXxTH9PI3XH3NzLqMPchOHNgoDzXNIQZH8eTl2HS94QMg3vtPbJ2MLTJoNQOgZbcx747jthOyrFDXgp//zpzO1TLFLtVIB02YBw2+AxRCxWLs7zzG3jq8hRHRRrclKOAxKR13h9GvomQUZAgVH//mpNt5ZZA1G7RPVsIuvNbfPZhTTxacaQpk0yRzAk5MgioKNXyatiO7Vd/tqXS1wLgNudKn/9AroZUS30AXnMCICIZAq7bKz15OVfb2jc/J5i7DExMYGto2vIcu3xztmenm/8tbvE73vA+c9WDx1VvOBdxcNf1dO0VExIAICBg/U/62m9PN3+Ec2dkKQgItMxsbTCQhCtwganCnOl+9c5h7Kex0WfLdmSSEIRMEgUm4MLsbCkIicGUlU1UqFRn2IuE4WjJ2AYAlpjKDgfrWTNv/bvwMpcwElwwSDBCkYguB2kkREGkQQkGS9npKO10UGWVRc4ttDJzMAVHJsOITSH1zp1ePXKmLbzXXjcVYYhCDAlGSRWpHAbCwRBcIBJ7H8YDp2dacHDNt+ahm9jQiVxmipEAkNmZDRWye6A58nof4LiPh2pIo4OC5EiGYHK5wyiY0w0UlYUWTZBCj7UTB4zQ0Ml84go+fHr97E2trS+ADRcyswXF2nLFkg14bRWCVdkVwLu+CTdRGLBeGH+EDRm7zMdGBCtHzQCGYHKaC24wZFeQ6DGO0BvOaV+/t/U+mK/YNFjlNrKafCpao7p+p2v/vGnlC3rxoPXjtpeEDT9fKYOBkpvkFjy4J0OQBwBZFnP2+76pq3bAM7cJuchekMEhMBCALHjI5mWKjRap5rXPbQA8H2hkS/2SSpexj4NkgEFmYCWqWj1vcU54+UvaEWYsrCyANZRh2UQ166MBc2Nwd7AVFQuAligiCLTgUjaZuznr4MjVUG19Xs/o/dwdT17rV71Jc28LOdPldLgAg3qjTEjBDYg+/2Hd+U3+/Vs+6xv5kT/6Xd/i09cuO4i1PMDk8iBAgSbKUhgwmtUQuJEUcjIjWiKThbLXDp7oXibOq+yQ6Mysc6yUnrUtz8aY/bKpmv83v2zTPH8mEEDPlivvFEWsDJ7ptCwo3/VN/f0bvPPrevBM/f3reuAXyznLAkxVlgc3OgEjUibAiiBLg2bYZrbZqcxOGpVsm99iyGT31PU7y09qVDAAwaGmg/iCIIGuvVQhobHxn+b208PIbU2OjBBCtjpqcBsJxjoIkKLMXXNvzdPehLu+jfoZ0RzZIGQIJlYZnuEMwdUjtJGTB+8bfu6LB309gKK5tLSvvPQv5iV+TMpC7YCq4bbl+WHIxq+Y69o3Q27eMlTy0tKHuQMQUg4BrIXsAuRW9lkQzDGhokBzQysX1k4Yro1PiRsckaHcvjtf+1Z/4sIy06dAoY5ihieZl8mTwWtwg8/ZhE9z/c9FepVdSsv2rr2WLbsFc6LRVCeC7vgWbthTt30BkjPEHKm2gcHL8junRWOEpxQo6xGhgCpno1umAE480Sb9l8PhC8O0vfXgVHOnguhCnQHmOnh0b6N85PGf0Qaf0oaf84GjFeIKPBvZUGdaKuMxPsBQw+iUo5VAwcOobcKrtjWEPHJrDd5ETGRXMmT5964Xxa3GQ6kgCt2+y8soJAAYNBZbnquJ37Geoa5asmwLWyAVghMIyiFBDg8eeOfXfNou9uT1JkCxNhAp+wLSglzZK0jeUnAmX+JWWDxCcOW+tGhkoYwvFDPQJn4fQ177CluibFa8fwZAK9eaySBZyAMNAKIjkq7S41eWcqIqqz0QsoKzeASUyezjPqPJ3zWMNJ+Le35AIiFSoFeCAqsgGTKyh57R2PBTacPPcv1DHVSoPCzn5NKQaUWdAqQ8Z0gMqp/6s9/3Q8FKp4qIkgjPBmUklAOLIoS2E0RytRIaga1MYs09+IYLaEPcH9EtByeLYJCJqIITMTiTsUdFCmXDT3ODI7jBZzFwgiQoLAedgzIYhEFEIrKzhoGqIFBuUuys9WubakvGAUSQYndX9/MVCdbH9jOxLMFit0r4J+8lLP3JXu/AsPruacaH49NXZniW0zJSsGiOHHPMIaeQo0zzZ+W/vM3GfFwbfCrGVwEWUJWNOzTL3g4CrBLkyCtL/jHB2Sdm15SgJAOtTjnElpCz5lcYlMGArE2+jzXf8kp7riSasnKZ767olCAEBrCW9QYgy3nb51UNBUN2GEVUJBINI7aMQPDKa1OSKQhiQFzzfRi6SbpmjxjmtN3pGfBMhtZIeaIZbzvKW8MIKmdaJWZRlpLVy75eYbVM+uyZfv1ugZbAwJZSzfruVqJXVpOVhFYCIEq3Hxni8EwnYgYotLJly4EGRDNAls1NMpFsceS22uZs3HoIn5hRKbplUwaSGLLkzNXDZ/DpKwtiYapkic/OgIRB45d7uwcA8IXwHESgAlJiKCteQyaCMwdnCoKhR+iFu5nUmdjv2tLPqwAWEUuoMECM6J6yl2NIAIABrwpbnp3uOzXcdXxuzw4eECSvASRzeqDJFaOSw/yeH9ljf8TG/0+v2oKUk5IIFdlUc0GKpK/kzeDs3Fh9GxpICgleWahzrhgDBmaZomvj73Pd97/y4gEASzQEZ8sEyMoJpdxpHPb63BqD3lmYdysTnTnCZFTKIVQ5DrLhm0ECE2IIqpLJ4FYgncGbxJ2mt6ftFufORHTCg6IPek17+CZh7u2Ye3PtDPSowbCF2ZOxygOHhLV3W+bRjn4vH/+D5XnhyeuFFMVkOXpLTHVgtfY+rUIMGLYNhr6W8//G2bfCBDlJyZMhkmYj0jrvNtQ0GpQBmoHuLpA2eJI2Oy/fsp8eu0oKhAERkK3+Tj7xe8570Oc9DLqH3pAq0Yxy9vrqu9oywa5CWcshVDBzo8EBBIECrOQaCCERkg9gTk4wlEPLeHloSf1fxQRAVqhfTgt9eV0XO3qJQvI/SEiy91FM/1B+5ip4hCnDW145kwltwiBSwUPbUlTLRu+ds+Ohs0jCCH8xD0l9EYLZZRFI1jJvix7W/jdMOuUVWHqXjsuDv06993LAaK67d0c4BKQgKwO/eGaGa77QhhhI5MpDtjAIwzYFrIY4+yp7/HJrracxHyRq9yAzE8DafR4fOIvz5+TXfDqAVIYMC+/HgvsTI9EORtTuJiLyVW9MWCZiIgHIfGaa5AAcFuSJbhhoPWti0NjiHcpH0Nx7VD/kSJGQu9gyF+IoDH2tzCnD3Hvy47+Gchj/uUJUyihbliC1/b4fxXYb67zXB69jCmJC78M+756AltBLxBq1UcwDtNrWy3XbZcQm+8O/1vwHNWDtMPoD5R/KJ6XnbAFKYogP/BoL760HrVWt82+Aa1lj3F1b0vs74K5IvkwnR7sh4TmgYHrotPi3r6X8aBSzwbJ5cArmAos2ntfZgpCrbNmsAY0FoHzvnYRhVT6bq2zFoWCCW4U8n2EAc1poHLDu+7HJd7s32j/yyVZu+JqJiwYVnhsSMgEXC+aTmKObW6KMCJDaTC1WL7/AjJqoOqehKnB4gGeYFQWwcnM7xK6ea//zVtoH6lPMRFnF2D1DL/uQUC7wwqdwy4F84qrMGJSyFXFTS4GhXphiVRW5bLiK6lyJBwVC1CIgaKVy5MVISp2QkGlBdGZJYfXd9LqfdZ/Df+iDDTjd0MAAyy78G4pRyQqbJXdoKLON63y5YgZCZgqIgktm0s8uve0XF91q8tetv8Y3PjIFXUe3OI2w0AdunvXM4T++2IlNJ6x18ke2F2qgK3f7SgkJzZPxwBn5jqNVP8UGxqEI00BibvYWQuaLehRNaPEmNjTdBKkMN1VDNtaWv2cc2r38/9ASoQkEdNFWyfd1wKKXp99cVOB2PsDPLpz54VP+2KQ6bvu95bW/+MSbQQcCkEFK9i+XpQiJimAGTBnkjLse3/GIs5+e3wuzkHvfsc2G//2ptw0b1NN3XstZkjJLF3/VypDy/1W8t5aL/i3+np0NLCb0J9AvlrmWVyzRYhKcsIbYJmCpNJvFfleTUTWeHc+HsGjRq0XIvZTpL032RYze17a7VqO2o4JygYaUuKCOIdhCOU0oX0t69pW/YAV6EgljX+qR5SYEB4dtoi1/140H/2izInULiKs6maVGJZfKL88zUGi1GYLQPu3imQd970+ew/BBwyavvzrVPv1Pfzvg5D+BAUQi/1WXw+UIIecAB8P0WY9P+cJZs+cloD1utQGZ8YJrZ+34mV8/PXehlKUsmRNSLkTjVWjTq7kxvUNtWhGXkjs+1wVIy1vwntkZtYMDIMw78WCZmQ8AeGhmaSFlAXQroBkA0psjdZUhvhIOnHJkwCVJBiddVIYkT32gy7J/rcAEqdC6JANfoiph0bn1B6bytqOynmF2M0tZIWTIgAB4YYu+wIfDiAw5QZeBlGDmUPCQW4PD9jcjDu+67H+0veuE886bdhu9JUNwv+67B2w+fhTJTvacmrbhsgEllUynD0p6GdYJLnMiAL+88G/7n/InwUcOHHD5CXust9ZqOx3525tue5iVf3DHST8/5M2ls0A5+a9GRnLIBIi6fMZ97znhgqfnJ0k/P2yXD+60yUGn/OnnF/3VaBMnDP/zVz4wfGAL7ggFbDJiVdUpOwr9K1i8Ck4JDA4ZtCL9TfWl6k6QYjOk0j9zbf6orM5FZ+eP7ENTXSDBTtGwWGXQPDvuMAhlh9iSB7C8k1ByboJyNxald3uJMVra6A9wu+sxfJtASDI6FFQ6jICBfeTRJbL+5zv5fS8pEqpWeYxOR05m7qTg1eDwhgsQh3X99UtgT82r6T0kIWbDs/PmNPHAS8coQmn5sZ9KHdGRlykiYgZE4ZeXTN//5D9IadiQgZd+9T0bb7jOiCG8+Lh3v379taVw2iUzDjzlQnT6Z/96CKNAEPXpF9++6xfPfXp+VubPD9t5/50nAfjZIW/58A6vcU+3/P3J7T971jPzF6Zg3ll9qFW+M4xwEL5iRQIoAwPgBgoGZC3/EzVgEZrh64KWL44JLvojqdI1KyXIIrfuaAqEPo3O5FARU8kd5U64zACjGKSsTtFBgYJj2RV2M6grAmZWoqz+b9p2PSPiludr4++jNcIAOknGnJd6vvoGC7Dcxet9Idc9iTkky6o9WlSsssxMHIGtzsXQTbr9vJfGKgfdHYqeLRkZEjrjEsqizAorddl3IKOveCL3zxgTMuiH/eTyA755MRGGDx5y1Ql7TVp/tQCI1cjB4cKvvWuz8WsA+O8/3brXCec/M6/+F6TeywjHTy+etf9J/yvUlv0Xh+/6wZ03AZxUlv/48LcdtPNGYpx57+M7HPGb+c8uJCQyN0tNVn6quQH1s2AreL47qksEihhAWN40NVl2frDZzygAy81+rETFouZCFwVfdNdndmZdpGAq7Q8P8GZDpbEBqSQ2ZK1ykP48eUbTUOmg9abmAF5a4GjxE10/wzuPyvf9ks182vO4++f+PVD+abFyzAQP9AxagkczcN33Y4MjOGDdrqd+yezI06+86q8P3f3wvLsff4rghV95904Tx/Ytqsvok7ddDnDkTemosmb75Wf3Pjr31Ev+GgT39u5v3HDz8atTJiYoAiL15Fz/wQV/gXKNsNOktadMGv2vOZB11Bl/BnvkC18/YZ3dt16fLMsXXYBAg75z3vTZ8xN93vabrb/TxPUWwSkrv2NRyiSb87yCt5Y6mX6DdGVxmQyojvJ/yQnYgT2XT5tzSc4Q+sNCAspUDVx9gLoK0tPpjRdwquk4FNzJRVuEuC67f15mLcnQYHdsYPv/y5DQnIz6YZs9S8sNZnpOYCil43MPnmY1U3QQVUIvoscBk9EahS6v+SXHTYS8xSem3nTfE5PGvmr69/YFXApk6YM5g63QRfEsCy/XOkGZFBBRNstKgFHIRlOGAqxNxAwLcHUaDyq6wotcixcdXxY2btFsXJ4f8z7kivCyHq4DZLvL+nVmio460DcLVoBsNLutoAyEQuPu5xOXmbqhaOIXJ+hSeQcGykWDVDp7bOShaqjqe6YbvyaAnmBV54MsOmABTFIscAByg3trZRsK6owsrfhrhYYS1o8h/Xxknk5nuKNAzGUlu8qNAIoSaJ31w50QshhFOwNVv3ix6E364lynA9cEPHGZfTg1Vxx9IqJqKhXplemQ+pcOSMS/hPzkkVOvOe70q4NbLjd8J2r2/4Z5occBAOmJpMuC5Y3Hr3PMPlvtvvWEgIWOyhDkOHbqVUefdT08A2ZUvuDQ53TlyhBvyoyl53fs6dcffdZVgchZsAD4qEHV9FP2XWvNERECbMoXfnPF9AdIODKB/LvDuTzfJlOe8sWzL5/xYLl/SfoFh67UOdnlc7+5/NZZyQYyJ1kCKziKdko/iLLx103ljyyE140beeLHdtpuk9FOhiaTAuGSHX3WtGN/eVVUSAXR/N1hUGeKQhBgu51ISgTcgluO86geyUgG1QkwC56zmbnMmIRIUWhD0X9/SL/xXSv54C5f+O3Ft9wDOBS//5HtPr77Fv2f9SUYjcggIYPcq91PcRlZC7j0q++dssmYvk8BOlFWHWbB6Hb+dXfvcfw5EEADYUg3nfS+jddfL/Z7qjo+SP1hXkmf+fEV3z7/L0Z4ZhXwh6/sXSFNOeJsgGUz0lEf2PbID7zBwCbmCVO++JvLZ9wLWnCHLMeIjnI4aSiqvYFEgqLoIRWddyiEy07Y49gzrrnklkch7x8Iueipt+W2ByjTlE3WvfSrez9/L2H3k+Aw+uRxa/7s0F0mrr/GcsQLm2l86Kgzbzzul1eVeLDDputd9pX3LA3n6BwyQfiex//+vGl3SD20tmQ7Txx90df3qBGrhshadtk3Tl9AObHHnn7NsVOvlUTLE9df66rj3zN0yIBOoV0bqmU3PYzwE8+f8bn/+mMdBkDcadIar9QqdfFODv5V5IiLv/YgNnpSbqybvzdaWRoRWnDBkyzIDcjZceush/c64Zyrp8+SKkOAMpnQBADr3L5lm/NiMCgIMIbmPJPmEKQcYWRtsp986s1rrDk8NsmHU46iBwR7XiqRgWDsIIrC8vtJHThS/TNlTzkEdzN3IZTN2kG9pYlnwaEsyxKaX8TymMHoN9379B7Hn3Pvo3NDZ3qyAFlkaQQisWTs3nmkm/NDlgrWQpaVy6GBKn+nlEhYlDsYpGZKU57EDEAsW41qqUiPgEgiMjIU6NGoT/z48p2++KvZ89vwWk1+l4S0qLEZmqkQozkzzRepuvb7FIRJucDNGQZg963Hvmvr9YMMzJCEuP/JV8QmXtYZHefrICg60XzUy2Y+8J3zboyAyypqv5022mXSulDB3CVEAELzu8hQMvTgTgY6My0b4G0iGQVlYWFp68Kl3CISnGYGF0MIKQNw9lDtDmQQyUAZZLIYFEgRCRFwRXdkp2CsAQIePROEVswzZCfdoZvueWjHI86eeuFf4XDv2wvvHUpnatBOBmeAatLETtqhcuYEuBc1dTjJcjaFfOmM+86bdoexAmsyGHDJrfeefe39sZRHbK5RXxFAQIoEZHRkGOVx5t8f3/4Lv4XapRgyVFAut6sLULtJtaQEI/zUi2/59I8uz3Eg0AYcanWVpF6xlpEi4QoweiCz6A5zKxN8ViEnEVBGKLPj4ZJbHiWDC2KoYU6sHCG48KCDlSYyFD+x26bv2urVLZlQLwJw/5HhsPDwysOTy94Ih4J56AUzgADLbAFOmtUuRsshOOG9FrxBjRk9Q9Iz8+rLbrlXKz8/L3WU28qWDvUWBqGRdKPKwRLZaU4ZLUqNQLgpiRVJsBDhS1A0o6vsDEK8fMZDYw/88WW3PtT5lZUQYJToyFQjiu5Fz0Uy1Ms94BiUwQzZTz/11qFDeigYM+E3z3rsS1NvIAmPAQZlJ2Ge4abQgRpw+KmXyZBMBg4aMvA7H90JnrNlPR9SL3eVhal0IAjRnbRI9JQbioJZclaA12pbSI7kgQLq5iTWZoA7cypyvoELk4reYUQqeUpGFWlVWfhEsmZpp6YVu68JCTJ6NXvBgv1PunCPr/5uzoJcYDLJyv0Gxj4B14ZOryaPaUhFLF1iGgIIkhkwZjrmze094JRLQw7ZE4ye67Je7OMn/mH2/OSIYDs29ZD1r88Wy/qZAZ9+9+MHnHKpOnVSZoMBGtpgyyGwJhnlN8568sMnXSK0HQ4PMDhTd5vHKxE1azZThj9+de+dJq2VwCgHCafYtO7kTrPZcxdMOOjUZ+bVgMRet8K0E8oG5DLPs6JRwYvHQ8oeIlVLfPcb1yccNCL0VRtlzmiV+ljL7dHRm8rDFYxwBaMYgiW5E6VQ8QuPfx9DhjILEGQVlBKrIAdres+N9zz26f/6k0JPaebd/cRcrqQMJ0kyCKKbMUx5zdp//MZ7YzOGKlLuReeIDSGk0yztQ8vYdBStUwBlUp4LbOAOB33u3LzzEeceuc8WR+27jckAJSjSih6fucHK6lGSltWDZUQFednqE5zZ4KMG8rTDd9nz6As8ImQy8AfnTvvwlI3GrT0c8IzCHmcoUgAy0E8+/6ab7noEMiK48vc++qZhg3sEhsKgXEZaISibgSKt5B5+waF9HYsO8puarbEkYZ12RcqyQPvhRwc8PvcNpMsTrQKQHNGUs3/61Gk33fWgPFjgZuNHffvDOxC1slmIropoS6L50MErREmXGRyRdYIBlegXTLtji0/c/5svv2ezCasLME+wCNUsdW1ZdV5SL4N7M7OGZgsgO7NmDHSpguGos66575GnCpwxvKf17ALQlQ2Pz24f9O3/PfvI3YBWX4He9+D0hQSSZbQr0JD9tAtvDVk/+dRbJQVZKUCJViqaY4rOPP2e2bt8/lcABTO5k0juFroh4RVpVnxvVAIQwKZnaBmIKAITZnQMHzJwkw3W/POMB2Ay7wlqunmSqERfsXjQPL6dNVg05bIgNbsM6gxHLnKXlEsvutyxsthoWZXjKGr7zE6LEiAFaMfNRpdWrUOmUFMRuRmDNQGgJZV38GYxNfq3+1a4SiDcAyHPlkIZRyooPEgDHDQXmITKCJXtz01HWQ21UFZ6rgwmwEIn8BmLMBjro391wwXX3vnbL+w1Zs2hocRvUkI2DwgAiLa8MtqyWJO0kgPIEBIktt7xhg3ftf1rz77q9hwE9znzbf/v/+ny4/YSQ0ANjzB30pxu9Zx5fvTp1xrojPK886TR+02Z1IcvFaGKZVV1wQGaZWUD5WhGF8sAQAZDQ80qOploutcyCzQIrx275kQr61C0CJyhAz50UADAYPJ6xKC43aQxBicsA4ZED2WseAWvacjznAMTKtBR9gO63fVk7+sO/vm3PvLmT+0xWQ3jpyogEmGCzMyR4bAC5AHyZNZqUoAi5eck8+W3PHTK2TfToqiQ9LNP73TZjEe+e95fKEPI511/+3lXb7rHtmPVtOxzJwZ0MgZnubPMkLUQ1mNmP7vk1snrDzt4921BgAHKYJloo8in57X3PO7sZ+fPEyoiuQdahaD43M3GXXvFFAqlkoSMngl3sFQKZVDWgSJG3fIEgDI3SLXROwxnKsSV4n0XV+gUQoZC2ZYEEs0kYkdrpOR6L7qaDysCDUkHLqCB5YNJ7Sgy1DmEdsEjyuyro2omOOnWTMbViDSTUmGDtOArK9beTNLISmSwWHW8FR0iIORG5ctRoXZ3ILCk9h2CeXmA1VkX7m5kgrIM6609sEG3GJn8L3c/vfmhp11w7SyoYQZRHhDKdJO8Yp+6yLJuFfbx91gpGfGT/5wyanCk2hWQk66Yef93z5tOF1TBKJg1dMjq4B9d+uy8XneD1zT76eHvkOVOr8WXc/+QFAOUC/dHjIviroEM5eyRROEuqS14bRSaISY3OWoQTkq5nDrAgNhqJuQlhMwqdIa7TCIiSFjpw6xYccqBzSdm3HyDUU2Px7MUP/2TS7f//Jmz56cGI+p7hZriALByRV0gWuUgvUNGklH0//zhZTlUwkKT77DJ6D23evVR/7btyKGDRArmbgee9Lt5c3shGV3q7I1fFNQLlUvMvvkG64G1lAN4yE9v+PmFM0FQmQgqGiDQ3DkLdvnCBfc+PjvJQB81ZAjNmHKZl+tWCa/YQoHUTfc+mWkwVkgJZUsOsnkrK5MwnDPt7otveYSoJQPD+msNy26hOEwRroKurGAvv9lWBMoDLWU3q6OjbRjQBys1P+L9RbdWqvpZflBKUJCRXhrdBskDLTDnBMXguUKiC1a5jAHytls0oZOeI6pmdoQguaHKxWWtTEFTwl5Fq8GQe+974LFjzrye2WC9tVnLWSieddaG64z84M6vJjr4ipXHtgEdMiw0QSQrFL5TsIwDdtp0g1EjD/np/zw9L8sM8Gfmtvc64Xef2G3yUfu9acSgSFZCzggVndHlUcGXWfAxODJlZI4eYNGBkcMGnnroW9913PnJMmKOmV+eeu3+u246bGAQRTeZkbhy+r2nX3q7YgZiSPFLH9hyzGoDMkHKkCMrMS6n0BRqs+BeKF3+5dOvD2VwKrusYPFZtOB+5L5bwlpSYc8EMAExgEQA3WBk6DAhaiC06UAM2d286YcH6xCmyqwDqhUedjGz7A4Kav/miPcc9qOLz5s2CyKNUr7y1ofGHfjD87+0x3abji0MLsppgKxMTcmdpkVUCgaTmvlr6LjTb/7rPU9FLEioRg4Y/JPPvk2wUQPiiQdut/8pF8INMcyZ2/7AiX8654u7AYW80B8i7hN1Mygc+d6tjp56zYxZTyQKng/87iUT1h7xpkmjqUakPsAP++kVN9/1EAEFbDp23d23GXP8L6cxOjy0m83gi01HLP6U9/3j4hMUWoT3deTNF9Fbm/5KP1Swj/zaLM7jkr+oj4zV926FGSEs7b9aeS7yc95kccRysY+6NFBkyRcu7UcWp75wyX9dqgf8R45LMH32h5clCl5GFAPLojS24K5AemYmKlMOoB3yztftt9MkIYNKiKFMjJNYGdkAksoeYDkAJoVsPgANbt4fVOESM4YviiXGSC/jTRnc+YhfX3Hrgx0tSSfpFsM7vls6LZd8Za8dJo0BgzWrC8hOhzejgrJ5FoOHFrByI1El7NVeg9FtwF1PtI8543J6Syzcx0yE0oefsvGa++30GiszrmQtRBZOZ4YUEMUyrBCIBJeJmQFe7/vmDSZu8MEPnXz+jFmPOQYG1El+ygU3/3nm3T/51B6bjRtlcitVUg4gOn2IpQd0goI7ghkBD5IY9thmgz22ffX5195BKSHMnj/3gyf+77lfentp3he20r+ddLGU4QFI6639qqPf/3oglMFauEFtaHmjiKJ5ziz9CfoJZ17TmcpiI2PUgYWO3PeNRVZXJN2w2L1jVFERLZ2GCkBIMsVsIoNyQmG5FsfVzDWQHVm652dqNMS7QPl9j84+98u7n3LejENOvVxpAdhDcfa89g5fPu/o977uqP3eJNAY5KmvWDeae+rfCiugkYCb75599OmXM1YptRDyf+65yfhXDSnI4Qff/JpfXPLXi299MHo7Gc+/9q7fX3f7O7d6NZhUyhSG5iFSAILY66Fn1JB4xdf2nnDgD59ckAgS9buOO//Sr+49ecLqJdM78OTLT7v4r+UEjF9t1BVfe9fJ582AyRlNIBW3/+KvBrh/dPct3rPNhAwzgd5WiN8994azr7tn+0nrHbvPVso25UtTwcGXH78bjBB+eeHtp146E/CEMMBz2xiKlIfrkq++578vvPXUi+9MVve4hJgtOc1kQApuJ39k240mrPPWz/5qyPABPzvsHSMHVwRroHKJ2PmIqZnx8hPegwZ/biZfLr/lgS//8poe+hlffPdqQyBUQKLoNBOnHPHrYUOq87/0rs5koScwQrPn1h888Y9z5y286Gt7oyHmozONUZ4Q/eKiW0+79G9Z3jIuoIW0wNiTqJ02GXPQLpuMWWMogJvueeS0C/86/Z5nLAuqnT3ZrEe9Y1cfusmG6x2w04aDBg9oIWVhxr1PnX/VXX+eeU8OES4wSz2vnzBi+0mjd9t6fYe95Ygz3aJlSpKRnmVBqgM5af21T/rwDi8aduRVIoiE0LLsORYKTkVkBacqlDzGswV755YbHLDLa0EHKCESgAWkPv7+ihXYcncESkSO0Wt6KtikLcoZFo3YPF+wWcKbPF9wKkMTajxhgLsVPKHQQym0QpqXQwANKo1zGQLgCqCsgMuSKqTkdGvJ60JKWSmYq2Ecmbkys1RV8FbR5BFzIeoACHLBjRBV+rRV4edacsbQOKxOl0Mig1sGEGSGsPmEEZec8P6jT7/mlPNuziQsQXbjPXN2/NwvT/zYrgfsvBGVjRVMECKXza0RQOtA8d4IoQEAfnb4m9ff/+6n5ye6gdV5024//5rX7L7NhNLyPW7q9fc88WRZl2fEzw7ZMbMyqUxauQkq4PsyegkwKJKFniMoNHNtLIdRmjkhih190DIy57AgZCqDVXOHMBQhuwZmo3tljmQIDjK0IDMJJjbONBFxJRJLiUZXBhsZ74P32GTbSaPfd9zZ9zy5UF6DkSkfe9Z151036/wvvmOdNV5lZiU3QDYxUw4XjY5m7W0ZSTvoxD94CCHJgm8ybr2j99kWDdpmQPzaR3fa6tAzkmcyycJhP7ryjZuOHTVoQKfF1fkvkoWsHCX3UA0bxAu/ss8OX5767NyFVOvp+e0dvnjm9JP2H7vWsJ9fcsdpF043RAeGD4q/+dI7hw3qyRJYmMYyVxy/+rAzLrztulkX7rLpQYMG9xik0HpmTu/RZ1z79EKc8L6tkI3EFTMfIdqw3QtV4O+PP3PZLfezwRNdFlDXlVUZInDXE89e8be7kaPQBltGl9OZiQilJ+b7ROLS2x8Qw05H/Oa/D9910phhES0hk3bpLQ+Brka4o4FWxXDsL6/58y0Pmtnnf3LRTw55KxspzUSvxeryW+4OVn34pIt/csjOBggWJKf2PP7sS//6KLLB2+hs5uoniORmuPfxuZfe8iDImLOc3gqhVoaumvnwzXc9fu6Xd4fq9x77h1mPP1uGREQDFcCc2sF68kW3DR8UD9x5I2QLwT73w4suvOVBoiXPNAvObLr81vtOPP/mWT/+yLg1h156y6PKjmhQXXYyGtoOQqYXZ3dYKOKv8vp1r15r2IBWuS9hMWOhgUGeGcUU3O58/JkHHpmXwQuuveOyGfdc/vX3Txr/qs7UKlwqxQRIKronmhWIG0VrxVwinGz2hBGqwWzKjphi1S8OWGe/mJM9zgWNnKQAqXi853jepqnrjdxJTbQ60wmZDB3mkjpcJpAZjJCV0cTKjSZJls1jps/PrR5IoIUsFjUDpkWDuTLQFUIyyAzZjZWltOKRoN9+DnkGaQocPiC+fsKrHDDFbCBqeSGjhtePG6VGVc1VJh7oQrRFNa0VpVDR+qJzMiu4/8hBA07+2A5TNh934DfOn92uAITsc+b7QSf+77nT7vjpoW9bbWAB5nNWWEZBExbH/5rJgfL+Iwa0fn7Y2/b4ynmCYLVx4AEn/+muSQeNHDLgnieeOvHcmxrkmemQd241ZdMx/Wops7IBaVE8WFKPSKX1XUas3UTsNGldL5eSFj3lEJiKK2ikGsBQgIaS0PRfCVDAvc7t0wxUlhmZBtMoCXXzA3Ep1f7yLm0zgNio9AFA3GLcajd+/4D9v3XhBdffHpw5JPfWTfc8sekhU3966Nv33HocmOUekHPoHKIns9LnToSdeN5N02c9AkYEuPtJH39j58xEukS9fsKwT75zs1MuuAGokPJdjz17/NRp3/7QFMKJ7B2agTF6NhjhOSUA1eQNRv7i0HfueewFsIUknp0f3v2Vs/fZefNP/+hCWtOxOudLe246YXWqHZjp3ofFxZM/vMP519z1zPy53zn/xmP3fgOCOXDYzy57ZkHec+sJW00em8stGUzecoebAhCQTPalfbY5Zp83ZOYAc7KwBoT2Uftse+Q+b4AHwnY+4teX/u3+i766186bjHVmQ3DUdIOiOabPenSHz0399Zf22H7imMrgjpaxVlXOCAWHmdlpF91xycz7XrfR6Btvv+9nF9+x786Tp0xcxwzusZHzYOXiTy++ZYeJa+2360ZUBHjML6Zd+rdHkDPNxBbk1kx4lKUlpXwLWVZl33by6MtO2NuZCyx1+E+uOOm8m+fOf7bgzrMeewrAJV/Ze8dN180ejVkIRt/h8+f8+dZ77334ScAU3IGsFmB+wSHCQqLloEE/v/COex59ojzQ6fxDSUD56pkP7fDFc9y99/efjUUQxdKLBBkVJod/48Addp60jvpUuiQoiAV/tCIusNkhv5h+15NumDOv/tb5N/z3IW91FNfvZi16QV2yynKNAvosGlmzQnwQiryXuQ2lN7tg3N2CmlFVJCAKElpINaoQUsrBMhHI52Th3nn8Sk+vIZoAKXRmnQBv5Fn6doZYh3BSKEfCxV/bS8AOXzj3yhl3AYCiZeTfHSxkomowOycsSA0YKpi5w0m1YfIcVfX0q3CeBy9arGcbIpTk1eYT1rzoq+9BAx93UFEXWDsrlPXgZdK5g8ha6Ss21F0uiUk2/RjBkIE93zB+0x8c9O7jzv3rrEfrSCpY0vnT/v6Gg//7nC+8S55okUpamUKHZFkjvds2Y3eaOPbSmfdLA+X+9Lx5x5x19UkH7XT4f109e/78CGZxxKABR+23Zf+4uCL04gb/LWxd0sQ/fvX9oeOoMxCQhNg34CYLQtvYKruxDAmFAvRSqEJpKSWsYeig8Nsvv+W0S8d95od/fmpBhiciPz03vfuECz6528RRgweGEFQjJrlVcDUKHAYi3vvws8efcT0Y4HWmIcSdP/sbgLTkItGS1wiZaJnnTGN0Szzx3OvfueUGO00aLRolL4MOvoBl5o0eIzJSAHbfatyph0856KRLqexq33j37Bt/dGlloUabiT8/7M07bDKaAtBKHmASBgA5G2zEkJ4vf+BNRDjpvBvve2Jeht33yNzTLvxrTPrOh6dEwagIhZQMtbEOoAhSHvyKW+47Zup1x515w1FTr7n/sTkOkZleiB80KJVGmoeo4EosBWEJkoIDm2+4xpxn228+4jdnXDQDiDRre0fejxRlZk/Ny0ee+WeL/OZBWx22x+sV/CunX0FmKZvVgowgbOSgaMT+p1w4fdaTIC6/9f5jfn3d5HFrRFE0ssSDMjMV0KzFCO6J5jUZHDVlDjIY3LMFT23rUSNqUlEDghGIwUCS7gkMBgAeCtvPguBMRjvy9Ku/csb0o8649rgzrzvq9BvuffSJ7SdPGLfmYNFZCABUOyAjgzmqXYKU9KJ1+yXJW7GM0kpFMxwMbmVo0xrRA6QRg1tEtOSy9Mgjz7gnoqIEWJJZn4Q1A2B9SV9nGrKgsuXXQMpuNcjaGtZdRk9m4TjG4mgCDYHMzHEgFAJqKQt1sxNKGS6pZMGlMyhD8GaSISf2LN5qXtwdMDYYiyBaGeWlei1nsVIwoQ0XUJWJYTjAkOUFVika7fIoMyFCPQi1Za0SN8pMigpgbsZoKZRdYAQ8gRRbVtQ8UZctswZZs28W9KXvCyuixyXwC3WQgRi/+tCbT97vP/bYsjQCFEnhviee2PHzZ8Xm+seVvn8US1T+6WFvHjG0B3BZTfLk39589OlXnn3NnTIlmmL108PeOXxw7GgWL9pj+LysBApQLsN0LkYsWpdkcCASbgqpgxY0mZxEEai0XMbBP1gXy+AkgtEO3PE1F35t3y3GjoIxulOS/JTf3XLiBTdm0CNSZeYZVkhopfPhB538P08tmG9ZpMwTFSSXUR6NlCeymd1xC6XZlQ1A/NiJv3/m2YVQLtLWWYhhQCnsKFNuB0YoGnjglEkf2vE15kVLNYmqSaDnmH23+uAuEwnUQGaHH+69QC5+O39qj8kT1ho5d/6CI8+YZtIxv5pG8uA9J49dY3DdYTnL6KgSK3ptyAthyPzzLQ8efeYVx55x9XFTr7/3safNCYYiypoRRQusW4pCSgZDAIOVChjRFWG48dv7/NubN3aEg0656KAT/1jueAPd3cvck/Ip519//6PPbjdxvZ02HnfUfjuMaA245NaHfn7JbWSoSwHokqXNx6/xpX22Dd675wm/u3nWw3sef8HIga2fH7KTsxVyHwkSUNXw1WDuMot0kbr0lntb7zyZe3zHdvuOveN7p1xwkyO+akikNyvanKluql/BqcAoCdE8R9FRJrAwYvBApx135jVfPv3q48+6+pjTrzl26tXHnHXDLp8/6+a7ZxNOwGmAhURQ5lURsW2c2ItSJBQzT1AzPgYnMpQclghnbhgaMCBKvR4j0HKZmako5gqRKbMFT8EMPk8yGNmg8w3cUuryjl5Q6MlJrOmIynCY2hG59OeKdLt8vjNDAWpHJngEA1CVSUsywBb1DAweZK5ehkDB1RO4sA9F7bfrqmmeuDpTTZ3lPFKOYq56kBPUBkwmKMPkzM2zyObjkEGoaWUgI1t2w4AkXzUVMKeSAaipJEW6UU0lQYsFKZfJKSJYZ79X2aflzEWErn8kWLyKghiECLp7IiHipI++6dKvvmfU4EqoweCpNWdBnRWfV+F/qQzmgggbwrg1hh39/i1hiDkiR5gd86sbAFgCwSkbr7HnNuOX6Dit2BCii9YswAVg5cMGLcJqIDfQA9rIbHSXmmPzprBb9sa9F1W7bWlKzOVY3EhuPn7wH7++z7+9eeMcKkERNcU5cxeanHKkmtZSLisaAOeJ5914yS0P0eXBZMGtBfcQAV+ootpdZTBLFZSUIQTKgpzOux6bc/RZ15NB2QULhtSAnknozLwgOyRLPzxs19222UA0uEiFnA/aeaMvf2BrdDpsJlVITKAZZXJGR2XAaQfvuN3nz/3FJbeNX2PEaX+aMWxQz5c/OIW0qCwPNHOwggdlWQVHDxAcH9x1o/133pisIvJrx61WNvw0D3NBFV1tQMgx5+JlBEnBLYfo8iT6zw5+26Rxaxz+k8t+cektM2Y9SsK9YMDZFe5/bN73z7k55Dx73sJdvvDrTBedwNFTr9tr6/WHDx4AZFhgRqYdtc8WV9989yW3PrTFoWdkt1MPfvNmE9amUq4gd5hI60wesbNm1GVEjuPWXv2AHV+dmC1UtdWtmmQ4ZI9NZUR2qR09tEQJVHajIUAQeqGYCmkZJvqph77t0FmPEMrBqBQU2uKnf3zJjPsemz1njmME3GkALEdRlsMCY0uSNUM9L1oV7NL0ex6NUAItQE4qN8GCaGdUSBfNfPLym+9DCIaiLBMAMyE3tHAFgytIZIjHnnGNo2ilBdAXE8hspiDsypkPwVswttVG6MmkcmToo6lZjkP6HH5CPnbqjW51B+5qpHoL+FB7DqEKbvc+OlcqHTnPCEuAS33/Fdjw/lXkd0xCYezAM0IMtTLt8pkPJbBaJE/jsdHAoGfEyq6753HJUYWcMpKso320TIaVlt5UkLsIoDXr8bnHnnFNYFXbQuTK4G7BlQLNkMTKPBfGPOUedMDOk8auMTR15q3JJbughTokT2YRotGA2hkpTZk4+p5TD9j9uD9ddsvdxuBIYKYHhZVLKfqwuIwkxoN32+Kca2dddutD0T2LKo0jCyNa4eefejtcYHjOMqvnxWLMQM/GzpKZo864Coqg00nK6UUiNigmypjMBVkKAHynjcdNmbwu8H+2hK6J7kpAhDRqUM8vDn7LXltscMDJFz07/1kpgS3L7lWAO7CQFBzB8Ezv/ONOv56SrAUs3H7imOP22TpbVM6wGFAXUNo9uqXKK0N6bH7vu0/4vTdDG9X3zrlury3Hbr/pmEIGIJwo85WZqFDGyp1gZaxPO2y3Hb9w1o2zHiJ84vg1fnro29DhZxlrMsjpwTqS24hUAu2Nk8a8e8sxv73+ruPOnEaLn9pjmyE9gGqqUsnv2JO0kHAgyLwMW09Yc+R2k8YYXe6wqDIxzwrKROEPtCw4UZh8Xlp/BcJXvVAhkg6Ew3Z/3fg1hx904v/8ZdaTCCmoR8iAueG4s65+YsE8hNb0WU8V/NsdCHb/o7NPPHfa0R+Y4jSDKxQNNf7myN0nHfzLBx559qBdJh345olZno1gRYtSRmEo9qHPxZNBwdLoNQceue8WQBByZ2OPZQLZFUTGomjJchJl2bOFkNHyoKo8IsBf7nr8M6dO22S9Yad8bEpBSp0y+fChA4kBsIa8B7jcJGdy9UTkxBBL1vViIUeSwPjpH11qHj0YkMtMpZqJ+iDUYEUPAcwCve0hbLDWUBcMCMqwkGlZDotQIuyYqVeSQYU9hKxC6jErLKUGQTZ2RNpbVvurBvYUJ08TGOBafWAyROOChBZCdczUKx2JJsgkFspQidqEuxRLoCqu0QT3DjQR+qVv1nlG2eE+WwfUZtO3Tu6BcOx4xG8rKZlZtmxuZlKCk6SzyDU7Q7DUdmuJmLDG0OcBrJfhASM9uVnQPQ/PPnrq1VSQaoYW3INSjiQqZZeFQpUpeBfNd9h4/LjVh5YIyueA74uojeWJY5WRTZUBYiAweNCQS0/Y69ip1xx35jXOxDwQISkFhJXrVLm7mQePMM8BPz9s10kHnzl3Xq9C2zw6Qnb/5HvfsN7qPUKiQqfvir6G//Mm3iwCGaWHg3TsGdcTtUQY6SbWjcenB8bsXj61I1HBPsAdJq/7f6Karr62ELJbDH0tZ+Bd246fvsH79zj+7Bmznggutw6xRZUsUEjQh7592dPz51swoYbHXx78tnXWHmbKzYxx0WAqOugSio688lH7bnH0GddHT47gFvY/6X/v/smHzBwIdDoquBnN0NuQL5hJCnHwYF38lb03OPC/xqw18uKvvxdAswqaBCrAa1qnce4yjzQrP/KNj+/62+vuze7rrTPiyH0nAwCqDA9MUDD0muCoDAmKyQDDl8+4/KgzrnHkwMrhIlqef/eV9+666RgIUKChRpKFCrmJ/zAC5gs8tthsAXKn7bnl+mO+ss97v/q7ex59JltZL+XXzHzopxfeMWxg6/5ffHxIT2UlM4WddtFNB5x02TFT/3LQLq9fb82hygwplQ7qsEE95x255wmnXfPtj24HtQNottDq/j3J5vFDn7qnPFGmhSW6UM1OCaqOCCkoIoxbY/jdjz2x8+fPy2hDVREOlqeihT90aAXBvV59SM9l0++88mZ974KbGejuxuzWgmfKTYWvICLCYEIwKAdZkGCwiBovBumo3LKWez22MjLlcgtg9kyryjSuWXQsgAbkkIjKWQ0fED+5++TS5DQwAx/e+TUnTL1KSrKALMUe5LrUBmXWlMG8I9cOGhgsO0C3TGrS+mtuuv6agMNMnmmQ2b67Tjr32ntTEZ5zgU4PLAGSDhXgMUNWLjYUO2qiNd0O3et1Sy0R0Dc9A+80aMuAmUsKStkMAqyXqEoIUmhD0b0GzGiuXhrkbfMKcA8tAWv2hHduO6FQfdQRG1+yjbz0/U45ISCYlCpVdSg0xEpowzxZCzmE7Ag5eSbkjM3uR1iIGaiDVUsR0TAiF4HQsnqxAlN0idY0jUpfOOiL+261/eR1P/SdP816cg4zg6W8ksCRsXBjICkojFlj5PHv2/qQH18WcpWNYHuz9Vc/6n1bFRQQ7OyIbyTfnr9WUIOgJilQ5hbpECNICDSHt1DmwTJzrImWLCuLsGb7ct/80jJCzouHHWkxIgM7zC/ERrqEJNqGKNi6awy/+aQDDv/J1d857xqQ9IiOmIiI30+785xpdxpjGVw46n1vXG/tIY07crdCjCiNPEWScDM6GI583xtPvei2hx9+2kGD3/PE/GN+dcOR792KAUACnEzecMYKdyY0jA74sEHVE7/6z4aYh5qoOoudAVowIS8kBpRVnbFoX0Acv+bgb35khwum3X7Iu7YqCIaXyhRRjp1eu3aKlRGOQNZj1xg5ZeI6DTGO2XJJsmCyNYa2AM80AwjfcvzqQdWAgaHEg7IhQ2HgDpusJYUiuWOUiNevP+rGk99/4IkXPrUgERR50c33TZm01l5bjx86IPbfH/LBXSaffc0D8+YvPOea2/9jjy2qgB02XW/S+NXkMKTNx7zqV0e+DQpOmbjdxFdnS1Cft7V+N4wBmDBq1M6bjJk0bpSJWQzmCRaQs4XojDQIJ31kyonn3QSZwoKQohvpcqsi63XWGnHAThs7lUMcs+bwo/fZ8pJbHy5KYx6CcgpUZpw8frXtJo1p1sC5SA0fMuyNm46RBy/ZMeiMLw5sJAPp1oJ3GB2BWRkWkSUDlZWDcZBTRGvbiWu/YYPVPrHH1uuvNkisTVUmA3zMmkP/dMI+3z3/hstn3jd7fkIZ5M0qkpmkqSDhAq1qfIHVCdX4tYdPec263/z3Nxd/QQAW4YL5u7Z89dlf2P275153yV8fgxdXqA71PAhic0/L6HJLkchead5G6499z1ZjP/muLdFZbF4cNRfvwJSGDNknKC8DMys0nCLCzSQPdMVyDxjlclhVONWZAOqxa4zYZdNx//7O148c1NMEIbE/GXypRKPF/kYZDgWvzeFsjtZjh+JZ51CUGqyzSjGACU5lCFVhF/bnWS4N3y7MvGj0ogVU2rCRzLQpm6x94/f22//Ei867+g6PnSV1KwyJdNSSBAbRKfvknpv/+vo7rpr5MFBD1ckf2pHKCA3FsnjgvgnE520vUzAk5h5Ft5y94ZaFsmlJmVKwsKDcIcwBXAgEg5xIhanJ5+GClbrKtMzh1JXFYpeoA/s+pgkoWY4Q6DD71kff+KZN1zzwpP+ZOycJyEqFCfih7/yxqEPFjNFrDT10r8kd1Y5CBMxsJjMiWRDUQBVNXPvFwW/Z8QvnRO9NrIzpmF9eue9OG2+wxlAAUUqwiFyj1Yz5UbEourv1P0dEpWaLEGg1FEXQWpKIGEXKiywtOrvcEsXMENC36AgFmS17ssjQ7N9R3az4Yd9d27dmBM1GkTI31DRPO70gBqqs7CCCF0agO9xygTwLm7Gz9sjLpj31jfj37dhrdsw1S5o6F9uRTaEmqk6SkCGrLcUyFyN2uIDNnqmG6bhoXDp19pYICM3OkCIIFBpMpMOLF8VkTY+7nARpESDuZOjbJs9mA1/f8qlF8ck7G/H+7zZKrsLCwudpTi4OIDx348rz/rrF1sIs+z1X7LCXUlWs1Kl47u9agd9e5DH75maNjmRF66K02zIbvm5qpgOX0Z4tFA8odk7d8yIzi33GvtE5dIaDX/j1XfE3ec519A4wu1jk6PuxhgqIFGiFw92seOvaS9MjeYVuVftXt1Vz8c8V3V2l93mu//U+ZexV9kd9m81XtgP/AqPdUh+QjvNa/jQ1aWUIS51kqxmYlQMWm8WT/XKUZVQe3pleZqf3Hpb7uTpTHQ1rszOGQu/EofDcsPHSAvHojJUsC6ZpCyQqulRGjrsR4aWyruzdKzMYrPyO8qW/atXiyhIv6vubVXLNS3qulc1SlxrqVioM9AWApVYJjkWFMTrYtsqiElQwJ5DAoCj60WdOQw5lpnrHSevtsMm6bPi5uWE1L+Mg++JBvx2cfG751S9kWv/Nm514oH6O2F7Ke7LvCPu4G8upP3566Z0PP/x0AmHcbMLae245vvtcd0NC11a17lua/1rBV71IBxD6OyYAL4wp2L+npxdwtA6Efjny85yNpW4pWcK1ldkI9jnfwpjvfE9W7qC1iQGGzBwQ7NhfXNvRdJPta1MmjYZDZGBc9ueyJc5tCbF9Q2HP8areQZYWQ8nKP5X9zx3OzKoXCiseZfvHuUULwJ8DCS6CyITT/zTz8pkPlrH5HSeO2fMN47tVwktm3X0Jr7QSYdWS6L4ns//3WGGO+fNl2avybkscRidBtv7eZKXesM+NrmCMXKIm6CukOsGgOc9iIT2UiYh+3ysbIQ2QZOr0XyPFLAJBsgw4TJmQt/uFLpfyYrpmWoLxouVeRAPi4qhd6osT5bUkgbyqj/9iWxBWSLtiKXFrKZevL8hlDhC9LMRW9LwySzu61q0SuvZCk/0Xd5tNUaPrIOC5z4mvbHTpf1Qv8Ag7awhXOgdaarmw+PeL+AD96ZAEC6XPGORtWE9iJkLwBRkDgYbJW3bYBYCdiZQ+t/4cpSDr55GxRPcYi7V/cjPhu6hcs36OuO8HX0h9YKt2aZbKLFi8YiCJlrehKlh2hTK42n20uyGhay91ebFUIOIFxJjFKImr3ONdzgtX8A1XtR3C5zqs52a7y3vzQijKoPUICAgUvvnRt8x5ttfMlH23bTYyeseLhw41zfrnyyUGcEmfaEsFYfqBS16Ivf2gIe9IHfQH4lYFOFoR5G0553+JE9u/PO2Lef/+rs23mzze1SY5efwaq7QfpWurmj91GUdd61rXuta1F1Q8dq1rXeta17ohoWtd61rXutYNCV3rWte61rVXuv3/AQBKs32R1ZYQpQAAAABJRU5ErkJggg==" },
                    { 2, "US", "data:image/gif;base64,R0lGODlhGwASAPcAAMq6u//19v709awAF//3+KkAGv3p7NUAJcIAIKoAHpYAGu8nSvI9XPV7kPiUpfaUpvmruMaJlPesuuGlr/i3wv3N1ePS1f74+dkAKdkAKtgAKtEAKcgAJsQAJb0AJLQAI64AIacAIaAAH5cAHb0fQOwoUO48X78xTfJuidpje8FYbcNidfR7k8Z2hvejtMaDkMeSnMikq9+UpPrN18rGx8IAO7IANpUALdQ6acZAcs11nc+Iq8+avNG309Ta7zlcvEZnv0Jerh9FpidNqChOqStQqy1SqjFWuDRcvjdfvjJVqzhgvzpiwTlhwDhevDlfvT1jwDdZrT5kwUBmwUFnwkFmwUNow0JnwkRpxENowkRpw0VqxEZrw0dsxElsw0ptxExvxkxvxURjsURksU1wxkxuw05xxVBzxiBJpyFJpyRMqClSrCtRqzNdvjRdvjdgvzdgvjhhvzpjwTpiwDtjwTpivjtjvz5nxD1lwTxkwDxlwD5mwj1lwEFowkNqxENpw0Rqw0VrxD5gsD9hsUhvyElvxUhtxEhuxEtwxUxxxU1yxmeJ0m2N03yZ2ICa1WaJ0meL0m6R1mWDwHOU1XeW1n6c2X+d2n+d2ebd3f/29v/4+P77+8vKygAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACwAAAAAGwASAAAI/wCNCEojRsgYNIOIRFGyJsiNAQUiSpwYccgVM3YU2UlUBYwWLoWc7HDwoKTJkw9aGCGzxAwSM28S6ekCCE8ZHhAk6NzJU0IENXPAuDnjBkwdQ1T6EDpiA4GHp1CjehjBBlGTMHHAzEG0hwsWKYZ6VJhBtqzZGTGGUAk0hwuTLXi6SLHi54mOBizy6t3LYkWRQ3S+LDFER+6WP3eA1DiwobHjxxtCDAG71Y6hKV60ZOESx8emz6BDf+aUBgqcPG3yJOGzBM8SOT9yMDBBu7ZtEyckNYJ06ZGlRZUYUZoUyRGOBSWSK19eggQmAZqgSycQIFMm6Beya9+enUYHDODDi0zHkEFDhvPo058HkQKF+/fw48uHr8KCgfv48+vfnx/ABw4ABijggAQKKMIEFCSo4IIMNrggDDK4IOGEFFZoIYUvJKDAhhx26OGHHgYEADs=" },
                    { 6, "Recruitment", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAApAAAAKQAG8o4lVAAAABGdBTUEAALGOfPtRkwAAACBjSFJNAAB6JQAAgIMAAPn/AACA6QAAdTAAAOpgAAA6mAAAF2+SX8VGAAADGElEQVR42mL8//8/A0lgJqM4kEwD4mAgFgXiX0D8CogPA/E8hvT/10gxDiCAGElywExGOyC5FIhlcKh4B8SZQEesItZIgAAi3gEzGS2B5Eaor/GB/+AQSv8/hxhjAQKIOAfMZFQGknuBWJ5Ij/0CR1H6/y2EFAIEEBORBmaQYDkIsAFxKdDhBM0HCCAmInzPCSS9GEgHpkCsSUgRQAAREwJiJPoeBkAO1yOkCCCAiHEAMyitMJAHWAgpAAggYhzwFojfk2H5PyC+T0gRQAARdkD6/49AcjsZDrgIxGcJKQIIIGJzwTQg/kyiAyYDHf+dkCKAACLOAen/zwPJBhIsXwzUM58YhQABxES0ken/+4BkAhB/xKPqGxBXQusKogBAADGSURlpQi1wBWI5qCdAldFxIJ4OdOgRUowDCCDSHYBwCChr8kAd8AVo8V9yjAEIIMIOgBSnxkCshlTZ/Idms79IUYleXnwAh0r6f7xZGCCA8DtgJiPI0JlAnExmQXQCiH2AjniLSwFAABFKhE4UWA4CFkCci08BQAAR4wBcYBsQg3LGBCBeAsQ/cagLAYYkNy5DAAKIBU/wgzQF4JAFxX0zMGhPQNUKAEl7IJbFolYbiJ2BeBM2gwACCF8IgFpAGnhaPX/RHPQTj1neuCQAAgifA/zwyL1EqWjS/4OK6et41HsAQ0kEmwRAADHhCH5hIOmPx8BzQEvfoImdxKNeDuwILAAggHCFgB1UEy5wiUgxZOCLTRAggHA5IIiAYedwVL/4Ch1HYMhieAoggJiwBD8oJXviMegTEJ/CIv4EiK/g0SeKLVoBAogJR+ITxmPQIyB+jaW2BBXNNwmEnC26AEAAYXPAd2jthgvIQ/M1eshpQEs+XOAuEK9DFwQIICYsPpkHbc1OBOKvWAziBRcqMxmLkCx3h/YNdXB01+qA2BBo9gp0SYAAIlQZgWrBGiB2hzaz0UED1GfToVUzelpZCcQdQIvv4bICIICI7ZppQh0Bq5ZBCUoA2gMCgd9ADCoXXgDxLWiZsBNo8UNCRgMEEPkNEioBgAADAKfduBnHVSiPAAAAAElFTkSuQmCC" }
                });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Descrtiption", "Name" },
                values: new object[,]
                {
                    { 1, null, "TopMenu" },
                    { 2, null, "MainMenu" },
                    { 3, null, "Tra cứu - Định vị" },
                    { 4, null, "Bottom-menu" },
                    { 8, null, "Mạng xã hội" },
                    { 9, null, "Slider" },
                    { 10, "Hiện tại chúng tôi có những gian hàng mua sắm online với đầy đủ những sản phẩm tiện ích, đa dạng. Hy vọng sẽ đem đến cho quý khách hàng những trải nghiệm mua sắm mới mẻ nhất. Hãy đến với hệ thống mua sắm trực tuyến của chúng tôi để tìm cho mình những sản phẩm thiết thực nhất.", "Mua sắm trực tuyến" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Pending" },
                    { 1, "Prepare" },
                    { 3, "Done" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "01b96c14-de28-4831-afa9-3d1f84b93aed", "13d23c51-re38-4831-wqa2-2e3f21c23ewd" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[,]
                {
                    { 15, 4, "Góp ý xây dựng cơ chế - chính sách" },
                    { 13, 4, "Công đoàn" },
                    { 12, 4, "Công tác Đảng" },
                    { 11, 3, "Tìm hiểu Tem Bưu chính" },
                    { 10, 3, "Cuộc thi ảnh bưu điện trong tôi" },
                    { 9, 3, "Viết thư UPU" },
                    { 8, 3, "Hoạt động cộng đồng" },
                    { 14, 4, "Đoàn thanh niên" },
                    { 16, 2, "Bưu điện - Văn hóa xã" },
                    { 6, 1, "Bưu chính thế giới" },
                    { 5, 1, "Điểm chi trả chế độ BHXH" },
                    { 4, 1, "Lương hưu - bảo trợ xã hội" },
                    { 3, 1, "Hành chính công" },
                    { 2, 1, "Thương mại điện tử" },
                    { 1, 1, "Hoạt động ngành" },
                    { 7, 3, "Gương điển hình" }
                });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[,]
                {
                    { 8, "", "/Posts/Service/List/1", 4, "Bưu chính chuyển phát" },
                    { 9, "", "/Posts/Service/List/2", 4, "Tài chính bưu chính" },
                    { 10, "", "/Posts/Service/List/3", 4, "Phân phối -Truyền thông" },
                    { 11, "", "/Posts/Article/List", 4, "Tin tức" },
                    { 31, "", "https://www.facebook.com/vnpost.vn", 8, "fab fa-facebook-f" },
                    { 32, "", "https://twitter.com/buudienvietnam", 8, "fab fa-twitter" },
                    { 36, "", "#", 9, "http://www.vnpost.vn/Portals/0/banner/IT-Banner-02.jpg" },
                    { 34, "", "http://www.vnpost.vn/desktopmodules/vnp_webapi/rssfeed.aspx", 8, "fab fa-instagram" },
                    { 35, "", "#", 9, "http://www.vnpost.vn/Portals/0/banner/Banner%20Chao%20mung%20DH%20Dang.jpg" },
                    { 37, "", "#", 9, "http://www.vnpost.vn/Portals/0/banner/Tem-COVID.jpg" },
                    { 38, "", "#", 9, "http://www.vnpost.vn/Portals/0/banner/Banner%20Cong%20PostGreen.jpg" },
                    { 39, "SÀN THƯƠNG MẠI ĐIỆN TỬ POSTMART", "#", 10, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fImages%2fPostmart+thumb.jpg&size=2&ver=28" },
                    { 18, "fas fa-qrcode", "#", 3, "Mã địa chỉ bưu chính" },
                    { 33, "", "https://www.linkedin.com/authwall?trk=gf&trkInfo=AQEcHBePbUPbnwAAAXKW4SzYfqas88PMwWIydrQUKt7vRdlRm_Thesf7HIcEsfHSkUXiZuX_nMjyj4IfViiABffUTA0XRALzYNn5xU6ph_mz0P_XK4651j2JANKqojtkFw3fRAk=&originalReferer=http://www.vnpost.vn/&sessionRedirect=https%3A%2F%2Fwww.linkedin.com%2Fin%2Ftt-dvkh-529b25197%2F", 8, "fab fa-linkedin" },
                    { 17, "fas fa-search-plus", "#", 3, "Tra cứu kỳ cước KHL" },
                    { 2, "QAndA", "#", 1, "Hỏi đáp" },
                    { 15, "fas fa-map", "#", 3, "Mạng lưới bưu cục" },
                    { 16, "fas fa-ban", "#", 3, "Tra cứu hàng cấm gửi" },
                    { 40, "LỊCH TẾT", "#", 10, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fLich+2019+(4).png&size=2&ver=31" },
                    { 3, "Contact", "#", 1, "Liên hệ" },
                    { 5, "Search-price", "#", 2, "<p>Tra cước</p><span>DỊCH VỤ</span>" },
                    { 1, "Description", "#", 1, "Giới thiệu" },
                    { 7, "Recruitment", "#", 2, "<p>Tin</p><span>TUYỂN DỤNG</span>" },
                    { 13, "fas fa-map-marker-alt", "/Main/Search", 3, "Định Vị Bưu Gửi" },
                    { 14, "fas fa-money-bill-alt", "#", 3, "Định vị chuyển tiền" },
                    { 6, "Mess", "#", 2, "<p>Đánh giá &</p><span>KHIẾU NẠI</span>" },
                    { 41, "DỊCH VỤ DATAPOST", "#", 10, "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fDataPost+(2).jpg&size=2&ver=31" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "DescriptionImg", "GalleryId", "Title" },
                values: new object[,]
                {
                    { 6, "Truyền thông quảng cáo qua các xuất bản phẩm, hệ thống truyền thông quảng cáo ngoài trời, tại các bưu cục, trên các phương tiện vận tải, phong bì...", "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2ftruyen-thong-quang-cao.jpg&size=3&ver=8", 3, "Truyền thông, quảng cáo" },
                    { 5, "POSTMART là sàn giao dịch thương mại điện tử được sáng lập bởi Tổng Công ty Bưu Điện Việt Nam (VNPost) và vận hành bởi Công ty Phát hành báo chí TW.", "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fviber_image_2019-06-06_14-38-15.jpg&size=3&ver=8", 3, "Sàn thương mại điện tử POSTMART" },
                    { 4, "Là dịch vụ cho phép khách hàng nộp tiền phí bảo hiểm, vay trả góp, tiền điện, nước, cước điện thoại, tiền đặt chỗ, mua hàng qua mạng, tiền phí phạt vi phạm giao thông, tiền thuế, tiền lệ phí hồ sơ xét tuyển ĐH,CĐ, tiền cấp đổi CMND, Hộ chiếu, tiền đặt vé máy bay…tại bưu cục", "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fthu-ho-chi-ho.jpg&size=3&ver=4", 2, "Thu hộ - Chi hộ" },
                    { 3, "Là dịch vụ giới thiệu, chào bán bảo hiểm, thu xếp việc giao kết hợp đồng bảo hiểm thông qua mạng lưới bưu cục, điểm cung cấp dịch vụ của Tổng Công ty Bưu điện Việt Nam.", "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fbh-phi-nhan-tho-pti.jpg&size=3&ver=5", 2, "Bảo hiểm phi nhân thọ PTI" },
                    { 2, "Bưu phẩm bảo đảm là dịch vụ chấp nhận, vận chuyển và phát bưu phẩm đến địa chỉ nhận trong nước và quốc tế; bưu phẩm được gắn số hiệu để theo dõi, định vị trong quá trình chuyển phát.", "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fDichVu%2fbuu-pham-dam-bao.jpg&size=3&ver=7", 1, "Bưu phẩm đảm bảo" },
                    { 1, "Là dịch vụ chuyển phát nhanh thư, tài liệu, vật phẩm, hàng hóa từ người gửi đến người nhận giữa Việt Nam trong nước và các nước trên thế giới trong khuôn khổ Liên minh Bưu chính Thế giới (UPU) và Hiệp hội EMS theo chỉ tiêu thời gian được Công ty Cổ phần Chuyển Phát Nhanh Bưu điện công bố trước. Chi tiết xin tham khảo tại website: www.ems.com.vn", "http://www.vnpost.vn/ImageCaching.ashx?file=%2fPortals%2f0%2fEMS-2.jpg&size=3&ver=7", 1, "Chuyển phát nhanh EMS" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[,]
                {
                    { 1, "<p>Toàn quốc và trên 100 quốc gia và vùng lãnh thổ khắp thế giới theo thoả thuận giữa Công ty và Bưu chính các nước thuộc Liên minh Bưu chính Thế giới (UPU) hoặc các đối tác khác.</p>", "Phạm vi cung cấp", 1 },
                    { 2, "<h4>Khối lượng:</h4><br/><p>- Khối lượng bưu gửi EMS thông thường: Tối đa 31,5kg/bưu gửi.</p><br /><p>- Đối với bưu gửi là hàng nguyên khối không thể tách rời, vận chuyển bằng đường bộ được nhận gửi tối đa đến 50kg, nhưng phải đảm bảo giới hạn về kích thước theo quy định.</p><br /><p>- Đối với bưu gửi là hàng nhẹ (hàng có khối lượng thực tế nhỏ hơn khối lượng qui đổi), khối lượng tính cước không căn cứ vào khối lượng thực tế mà căn cứ vào khối lượng qui đổi theo cách tính như sau: Khối lượng qui đổi (kg) = Chiều dài x Chiều rộng x Chiều cao (cm) / 6000</p><br /><p>- Đối với bưu gửi quốc tế: Thực hiện theo thông báo của Công ty Cổ phần Chuyển phát nhanh Bưu điện đối với từng nước.</p><br /><h4>Kích thước:</h4><br /><p>- Kích thước tối thiểu:</p><br /><p>+ Ít nhất một mặt bưu gửi có kích thước không nhỏ hơn 90mm x 140mm với sai số 2 mm.</p><br /><p>+ Nếu cuộn tròn: Chiều dài bưu gửi cộng hai lần đường kính tối thiểu 170 mm và kích thước chiều lớn nhất không nhỏ  hơn 100mm.</p><br /><p>- Kích thước tối đa: Bất kỳ chiều nào của bưu gửi không vượt quá 1500mm và tổng chiều dài cộng với chu vi lớn nhất (không đo theo chiều dài đã đo) không vượt quá 3000mm.</p><br /><p>- Bưu gửi có kích thước lớn hơn so với kích thước thông thường được gọi là bưu gửi cồng kềnh và có quy định riêng phụ thuộc vào từng nơi nhận, nơi phát và điều kiện phương tiện vận chuyển.</p><br /><p>- Đối với bưu gửi quốc tế: Kích thước thông thường đối với bưu gửi EMS là bất kỳ chiều nào của bưu gửi cũng không vượt quá 1,5m và tổng chiều dài cộng với chu vi lớn nhất (không đo theo chiều dài đã đo) không vượt quá 3m.</p><br />", "Khối lượng, kích thước", 1 },
                    { 3, "<p>Tùy theo từng dịch vụ sẽ có bảng cước giá khác nhau kèm theo phí dịch vụ của các dịch vụ cộng thêm.</p><p>Bảng cước dịch vụ chuyển phát nhanh EMS trong nước</p><p>Bảng cước dịch vụ chuyển phát nhanh EMS quốc tế</p>", "Cước phí", 1 },
                    { 4, "<p>Toàn quốc</p>", "Phạm vi cung cấp dịch vụ", 2 },
                    { 5, "<h4>a. Giới hạn kích thước của bưu thiếp:</h4><br/><p>- Kích thước tối đa: 165 mm x 245 mm, với sai số 2 mm.</p><br /><p>- Kích thước tối thiểu: 90 mm x 140 mm, với sai số 2 mm. </p><br /><p>- Tỷ lệ tối thiểu giữa chiều dài và chiều rộng: dài = rộng x  (≈ 1,4).</p><br /><h4>b. Giới hạn kích thước của gói nhỏ: </h4><br /><p>- Kích thước tối thiểu: 210 x 148 mm.</p><br /><p>- Kích thước tối đa: Tổng chiều dài, chiều rộng và chiều cao là 900 mm, nhưng kích thước chiều lớn nhất không vượt quá 600 mm, với sai số 2 mm. Nếu cuộn tròn, chiều dài cộng hai lần đường kính là 1040 mm, nhưng kích thước lớn nhất không vượt quá 900 mm.</p><br /><h4>c. Giới hạn kích thước của các loại bưu phẩm khác:</h4><br /><p>- Kích thước tối đa: Tổng chiều dài, chiều rộng và chiều cao là 900 mm, nhưng kích thước chiều lớn nhất không vượt quá 600 mm, với sai số 2 mm. Nếu cuộn tròn, chiều dài cộng hai lần đường kính là 1040 mm, nhưng kích thước lớn nhất không vượt quá 900 mm, với sai số 2 mm.</p><br /><p>- Kích thước tối thiểu: Một mặt kích thước không nhỏ hơn 90 mm x 140 mm với sai số 2 mm. Nếu cuộn tròn: chiều dài cộng hai lần đường kính là 170 mm, nhưng kích thước chiều lớn nhất không nhỏ hơn 100 mm</p><br />", "Quy định về khối lượng / kích thước", 2 },
                    { 6, "<p>Tất cả các điểm cung cấp dịch vụ của Bưu điện Việt Nam trên toàn quốc</p>", "Phạm vi cung cấp dịch vụ", 3 },
                    { 7, "<p>Mức phí bảo hiểm cạnh tranh với nhiều chương trình bán hàng hấp dẫn.</p><br/><p>Liên hệ với các điểm bán hàng của Bưu điện trên toàn quốc để biết thông tin phí bảo hiểm chi tiết.</p>", "Bảng cước dịch vụ", 3 },
                    { 8, "<p>Tất cả các điểm cung cấp dịch vụ của Bưu điện Việt Nam trên toàn quốc</p>", "Phạm vi cung cấp dịch vụ", 4 },
                    { 9, "<p>Giá cước được thỏa thuận tùy theo từng đối tác và theo sản lượng giao dịch.</p>", "Bảng cước dịch vụ", 4 },
                    { 10, "<p>Trên toàn Quốc!</p>", "Phạm vi cung cấp dịch vụ", 5 },
                    { 11, "<p>Dịch vụ thương mại điện tử hay con gọi là E-commerce là hoạt động kinh doanh, mua bán các loại sản phẩm hàng hóa/ dịch vụ diễn ra trên môi trường internet, đặc biệt là thông qua các website và ứng dụng di động. Các hoạt động diễn ra chủ yếu theo 3 hình thức B2C, B2B và C2C</p>", "Đặc điểm dịch vụ", 5 },
                    { 12, "<p>Tất cả các điểm giao dịch trên 63 tỉnh, thành phố</p>", "Phạm vi cung cấp dịch vụ", 6 },
                    { 13, "<i>Theo thỏa thuận trên cơ sở đơn giá thị trường</i>", "Bảng cước dịch vụ", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ColumnistItemId",
                table: "Articles",
                column: "ColumnistItemId");

            migrationBuilder.CreateIndex(
                name: "Index_Article_Date",
                table: "Articles",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_IdentityUserId",
                table: "Articles",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "Index_Article_View",
                table: "Articles",
                column: "View");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ColumnistItems_ColumnistId",
                table: "ColumnistItems",
                column: "ColumnistId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId",
                table: "Districts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DistricId",
                table: "Locations",
                column: "DistricId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ParcelId",
                table: "Locations",
                column: "ParcelId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuLinks_LocationId",
                table: "MenuLinks",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_StatusId",
                table: "Parcels",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_GalleryId",
                table: "Posts",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_ColumnistItemId",
                table: "RolePermissions",
                column: "ColumnistItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleId",
                table: "RolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_PostId",
                table: "Services",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CURDs");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "MenuLinks");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "MenuLocations");

            migrationBuilder.DropTable(
                name: "ColumnistItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Columnists");

            migrationBuilder.DropTable(
                name: "Galleries");
        }
    }
}
