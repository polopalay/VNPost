using System;
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                values: new object[] { "13d23c51-re38-4831-wqa2-2e3f21c23ewd", "20e6071b-fbd8-4c55-806a-a79b3b1c4a8b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "01b96c14-de28-4831-afa9-3d1f84b93aed", 0, "ecff460b-adfc-411e-9f35-5c3bcec94910", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENVfYO/ByyafuleVAgUNZiUlG+Vyi645v0VP2+KuzBuUxIrzqh2Hy0RwzJf21yFrAQ==	", null, false, "6ffaeab3-f7bb-4889-8127-35ed8b0f2b53", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "CURDs",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Create" });

            migrationBuilder.InsertData(
                table: "CURDs",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Update" });

            migrationBuilder.InsertData(
                table: "CURDs",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Delete" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Img", "Name" },
                values: new object[] { 1, "/image/category/ImageCaching.ashx.png", "Bưu chính chuyển phát" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Img", "Name" },
                values: new object[] { 2, "/image/category/ImageCaching.ashx-2.png", "Tài chính bưu chính" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Img", "Name" },
                values: new object[] { 3, "/image/category/ImageCaching.ashx-3.png", "Phân phối - Truyền thông" });

            migrationBuilder.InsertData(
                table: "Columnists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Tin Vietnam Post" });

            migrationBuilder.InsertData(
                table: "Columnists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Bưu điện - Văn hóa xã" });

            migrationBuilder.InsertData(
                table: "Columnists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Người bưu điện" });

            migrationBuilder.InsertData(
                table: "Columnists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Hoạt động Đảng - Đoàn thể" });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Description", "ImgDescription", "Title" },
                values: new object[] { 9, "Chuyên trang thông tin doanh nghiệp", "/image/gallery/list-top.png", "Thông tin Doanh nghiệp" });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Description", "ImgDescription", "Title" },
                values: new object[] { 8, "Hướng tới Đại hội Đại biểu Đảng bộ TCT lần II", "/image/gallery/Icon-Dang.png", "Đại hội Đảng" });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Description", "ImgDescription", "Title" },
                values: new object[] { 7, "Văn bản pháp lý và các thông tin liên quan", "/image/gallery/folder.png", "Văn bản pháp lý" });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Description", "ImgDescription", "Title" },
                values: new object[] { 5, "Tổng hợp thông tin thi đua khen thưởng", "/image/gallery/thi-dua-khen-thuong.png", "Thi đua - khen thưởng" });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Description", "ImgDescription", "Title" },
                values: new object[] { 4, "Văn bản quản lý tem bưu chính", "/image/gallery/stamp.png", "Tem bưu chính" });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Description", "ImgDescription", "Title" },
                values: new object[] { 3, "Văn bản quản lý chất lượng dịch vụ", "/image/gallery/quan-ly-chat-luong.png", "Quản lý chất lượng" });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Description", "ImgDescription", "Title" },
                values: new object[] { 2, "Tổng hợp báo chí ngành bưu điện", "/image/gallery/newspaper.png", "Tổng hợp báo chí" });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Description", "ImgDescription", "Title" },
                values: new object[] { 1, "Bưu điện Việt Nam vì một cuộc sống xanh", "/image/gallery/Recycle.png", "Nói không với rác thải nhựa" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { 9, "Company", "TỔNG CÔNG TY BƯU ĐIỆN VIỆT NAM - VIETNAM POST" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { 10, "Location", "Địa chỉ: Số 05 đường Phạm Hùng - Mỹ Đình 2 - Nam Từ Liêm - Hà Nội - Việt Nam" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { 11, "Policy", "Ghi rõ nguồn \"www.vnpost.vn\" khi phát hành lại thông tin từ website này" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { 12, "Ra mắt nền tảng mã địa chỉ bưu chính - Vpostcode", "https://www.youtube.com/embed/iPEvFyikq-g" });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Descrtiption", "Name" },
                values: new object[] { 4, null, "Bottom-menu" });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Descrtiption", "Name" },
                values: new object[] { 8, null, "Mạng xã hội" });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Descrtiption", "Name" },
                values: new object[] { 9, null, "Slider" });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Descrtiption", "Name" },
                values: new object[] { 10, "Hiện tại chúng tôi có những gian hàng mua sắm online với đầy đủ những sản phẩm tiện ích, đa dạng. Hy vọng sẽ đem đến cho quý khách hàng những trải nghiệm mua sắm mới mẻ nhất. Hãy đến với hệ thống mua sắm trực tuyến của chúng tôi để tìm cho mình những sản phẩm thiết thực nhất.", "Mua sắm trực tuyến" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Prepare" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Pending" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Done" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "01b96c14-de28-4831-afa9-3d1f84b93aed", "13d23c51-re38-4831-wqa2-2e3f21c23ewd" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 15, 4, "Góp ý xây dựng cơ chế - chính sách" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 14, 4, "Đoàn thanh niên" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 13, 4, "Công đoàn" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 12, 4, "Công tác Đảng" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 10, 3, "Cuộc thi ảnh bưu điện trong tôi" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 9, 3, "Viết thư UPU" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 8, 3, "Hoạt động cộng đồng" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 11, 3, "Tìm hiểu Tem Bưu chính" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 16, 2, "Bưu điện - Văn hóa xã" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 6, 1, "Bưu chính thế giới" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 5, 1, "Điểm chi trả chế độ BHXH" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 4, 1, "Lương hưu - bảo trợ xã hội" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 3, 1, "Hành chính công" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 2, 1, "Thương mại điện tử" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 1, 1, "Hoạt động ngành" });

            migrationBuilder.InsertData(
                table: "ColumnistItems",
                columns: new[] { "Id", "ColumnistId", "Name" },
                values: new object[] { 7, 3, "Gương điển hình" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 33, "", "https://www.linkedin.com/authwall?trk=gf&trkInfo=AQEcHBePbUPbnwAAAXKW4SzYfqas88PMwWIydrQUKt7vRdlRm_Thesf7HIcEsfHSkUXiZuX_nMjyj4IfViiABffUTA0XRALzYNn5xU6ph_mz0P_XK4651j2JANKqojtkFw3fRAk=&originalReferer=http://www.vnpost.vn/&sessionRedirect=https%3A%2F%2Fwww.linkedin.com%2Fin%2Ftt-dvkh-529b25197%2F", 8, "fab fa-linkedin" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 34, "", "http://www.vnpost.vn/desktopmodules/vnp_webapi/rssfeed.aspx", 8, "fab fa-instagram" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 35, "", "#", 9, "/image/slider/banner1.jpg" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 39, "SÀN THƯƠNG MẠI ĐIỆN TỬ POSTMART", "#", 10, "/image/other/ImageCaching.ashx.jpeg" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 37, "", "#", 9, "/image/slider/banner3.jpg" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 38, "", "#", 9, "/image/slider/banner4.jpg" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 32, "", "https://twitter.com/buudienvietnam", 8, "fab fa-twitter" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 36, "", "#", 9, "/image/slider/banner2.jpg" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 31, "", "https://www.facebook.com/vnpost.vn", 8, "fab fa-facebook-f" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 41, "DỊCH VỤ DATAPOST", "#", 10, "/image/other/ImageCaching.ashx-2.jpeg" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 10, "", "/Posts/Service/List/3", 4, "Phân phối -Truyền thông" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 9, "", "/Posts/Service/List/2", 4, "Tài chính bưu chính" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 8, "", "/Posts/Service/List/1", 4, "Bưu chính chuyển phát" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 40, "LỊCH TẾT", "#", 10, "/image/other/ImageCaching.ashx.png" });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[] { 11, "", "/Posts/Article/List", 4, "Tin tức" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "DescriptionImg", "GalleryId", "Title" },
                values: new object[] { 6, "Truyền thông quảng cáo qua các xuất bản phẩm, hệ thống truyền thông quảng cáo ngoài trời, tại các bưu cục, trên các phương tiện vận tải, phong bì...", "/image/post/ImageCaching-6.ashx.jpeg", 3, "Truyền thông, quảng cáo" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "DescriptionImg", "GalleryId", "Title" },
                values: new object[] { 5, "POSTMART là sàn giao dịch thương mại điện tử được sáng lập bởi Tổng Công ty Bưu Điện Việt Nam (VNPost) và vận hành bởi Công ty Phát hành báo chí TW.", "/image/post/ImageCaching-5.ashx.jpeg", 3, "Sàn thương mại điện tử POSTMART" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "DescriptionImg", "GalleryId", "Title" },
                values: new object[] { 4, "Là dịch vụ cho phép khách hàng nộp tiền phí bảo hiểm, vay trả góp, tiền điện, nước, cước điện thoại, tiền đặt chỗ, mua hàng qua mạng, tiền phí phạt vi phạm giao thông, tiền thuế, tiền lệ phí hồ sơ xét tuyển ĐH,CĐ, tiền cấp đổi CMND, Hộ chiếu, tiền đặt vé máy bay…tại bưu cục", "/image/post/ImageCaching-4.ashx.jpeg", 2, "Thu hộ - Chi hộ" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "DescriptionImg", "GalleryId", "Title" },
                values: new object[] { 3, "Là dịch vụ giới thiệu, chào bán bảo hiểm, thu xếp việc giao kết hợp đồng bảo hiểm thông qua mạng lưới bưu cục, điểm cung cấp dịch vụ của Tổng Công ty Bưu điện Việt Nam.", "/image/post/ImageCaching-3.ashx.jpeg", 2, "Bảo hiểm phi nhân thọ PTI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "DescriptionImg", "GalleryId", "Title" },
                values: new object[] { 1, "Là dịch vụ chuyển phát nhanh thư, tài liệu, vật phẩm, hàng hóa từ người gửi đến người nhận giữa Việt Nam trong nước và các nước trên thế giới trong khuôn khổ Liên minh Bưu chính Thế giới (UPU) và Hiệp hội EMS theo chỉ tiêu thời gian được Công ty Cổ phần Chuyển Phát Nhanh Bưu điện công bố trước. Chi tiết xin tham khảo tại website: www.ems.com.vn", "/image/post/ImageCaching.ashx.jpeg", 1, "Chuyển phát nhanh EMS" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "DescriptionImg", "GalleryId", "Title" },
                values: new object[] { 2, "Bưu phẩm bảo đảm là dịch vụ chấp nhận, vận chuyển và phát bưu phẩm đến địa chỉ nhận trong nước và quốc tế; bưu phẩm được gắn số hiệu để theo dõi, định vị trong quá trình chuyển phát.", "/image/post/ImageCaching.ashx-2.jpeg", 1, "Bưu phẩm đảm bảo" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 1, "<p>Toàn quốc và trên 100 quốc gia và vùng lãnh thổ khắp thế giới theo thoả thuận giữa Công ty và Bưu chính các nước thuộc Liên minh Bưu chính Thế giới (UPU) hoặc các đối tác khác.</p>", "Phạm vi cung cấp", 1 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 2, "<h4>Khối lượng:</h4><br/><p>- Khối lượng bưu gửi EMS thông thường: Tối đa 31,5kg/bưu gửi.</p><br /><p>- Đối với bưu gửi là hàng nguyên khối không thể tách rời, vận chuyển bằng đường bộ được nhận gửi tối đa đến 50kg, nhưng phải đảm bảo giới hạn về kích thước theo quy định.</p><br /><p>- Đối với bưu gửi là hàng nhẹ (hàng có khối lượng thực tế nhỏ hơn khối lượng qui đổi), khối lượng tính cước không căn cứ vào khối lượng thực tế mà căn cứ vào khối lượng qui đổi theo cách tính như sau: Khối lượng qui đổi (kg) = Chiều dài x Chiều rộng x Chiều cao (cm) / 6000</p><br /><p>- Đối với bưu gửi quốc tế: Thực hiện theo thông báo của Công ty Cổ phần Chuyển phát nhanh Bưu điện đối với từng nước.</p><br /><h4>Kích thước:</h4><br /><p>- Kích thước tối thiểu:</p><br /><p>+ Ít nhất một mặt bưu gửi có kích thước không nhỏ hơn 90mm x 140mm với sai số 2 mm.</p><br /><p>+ Nếu cuộn tròn: Chiều dài bưu gửi cộng hai lần đường kính tối thiểu 170 mm và kích thước chiều lớn nhất không nhỏ  hơn 100mm.</p><br /><p>- Kích thước tối đa: Bất kỳ chiều nào của bưu gửi không vượt quá 1500mm và tổng chiều dài cộng với chu vi lớn nhất (không đo theo chiều dài đã đo) không vượt quá 3000mm.</p><br /><p>- Bưu gửi có kích thước lớn hơn so với kích thước thông thường được gọi là bưu gửi cồng kềnh và có quy định riêng phụ thuộc vào từng nơi nhận, nơi phát và điều kiện phương tiện vận chuyển.</p><br /><p>- Đối với bưu gửi quốc tế: Kích thước thông thường đối với bưu gửi EMS là bất kỳ chiều nào của bưu gửi cũng không vượt quá 1,5m và tổng chiều dài cộng với chu vi lớn nhất (không đo theo chiều dài đã đo) không vượt quá 3m.</p><br />", "Khối lượng, kích thước", 1 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 3, "<p>Tùy theo từng dịch vụ sẽ có bảng cước giá khác nhau kèm theo phí dịch vụ của các dịch vụ cộng thêm.</p><p>Bảng cước dịch vụ chuyển phát nhanh EMS trong nước</p><p>Bảng cước dịch vụ chuyển phát nhanh EMS quốc tế</p>", "Cước phí", 1 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 4, "<p>Toàn quốc</p>", "Phạm vi cung cấp dịch vụ", 2 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 5, "<h4>a. Giới hạn kích thước của bưu thiếp:</h4><br/><p>- Kích thước tối đa: 165 mm x 245 mm, với sai số 2 mm.</p><br /><p>- Kích thước tối thiểu: 90 mm x 140 mm, với sai số 2 mm. </p><br /><p>- Tỷ lệ tối thiểu giữa chiều dài và chiều rộng: dài = rộng x  (≈ 1,4).</p><br /><h4>b. Giới hạn kích thước của gói nhỏ: </h4><br /><p>- Kích thước tối thiểu: 210 x 148 mm.</p><br /><p>- Kích thước tối đa: Tổng chiều dài, chiều rộng và chiều cao là 900 mm, nhưng kích thước chiều lớn nhất không vượt quá 600 mm, với sai số 2 mm. Nếu cuộn tròn, chiều dài cộng hai lần đường kính là 1040 mm, nhưng kích thước lớn nhất không vượt quá 900 mm.</p><br /><h4>c. Giới hạn kích thước của các loại bưu phẩm khác:</h4><br /><p>- Kích thước tối đa: Tổng chiều dài, chiều rộng và chiều cao là 900 mm, nhưng kích thước chiều lớn nhất không vượt quá 600 mm, với sai số 2 mm. Nếu cuộn tròn, chiều dài cộng hai lần đường kính là 1040 mm, nhưng kích thước lớn nhất không vượt quá 900 mm, với sai số 2 mm.</p><br /><p>- Kích thước tối thiểu: Một mặt kích thước không nhỏ hơn 90 mm x 140 mm với sai số 2 mm. Nếu cuộn tròn: chiều dài cộng hai lần đường kính là 170 mm, nhưng kích thước chiều lớn nhất không nhỏ hơn 100 mm</p><br />", "Quy định về khối lượng / kích thước", 2 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 6, "<p>Tất cả các điểm cung cấp dịch vụ của Bưu điện Việt Nam trên toàn quốc</p>", "Phạm vi cung cấp dịch vụ", 3 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 7, "<p>Mức phí bảo hiểm cạnh tranh với nhiều chương trình bán hàng hấp dẫn.</p><br/><p>Liên hệ với các điểm bán hàng của Bưu điện trên toàn quốc để biết thông tin phí bảo hiểm chi tiết.</p>", "Bảng cước dịch vụ", 3 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 8, "<p>Tất cả các điểm cung cấp dịch vụ của Bưu điện Việt Nam trên toàn quốc</p>", "Phạm vi cung cấp dịch vụ", 4 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 9, "<p>Giá cước được thỏa thuận tùy theo từng đối tác và theo sản lượng giao dịch.</p>", "Bảng cước dịch vụ", 4 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 10, "<p>Trên toàn Quốc!</p>", "Phạm vi cung cấp dịch vụ", 5 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 11, "<p>Dịch vụ thương mại điện tử hay con gọi là E-commerce là hoạt động kinh doanh, mua bán các loại sản phẩm hàng hóa/ dịch vụ diễn ra trên môi trường internet, đặc biệt là thông qua các website và ứng dụng di động. Các hoạt động diễn ra chủ yếu theo 3 hình thức B2C, B2B và C2C</p>", "Đặc điểm dịch vụ", 5 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 12, "<p>Tất cả các điểm giao dịch trên 63 tỉnh, thành phố</p>", "Phạm vi cung cấp dịch vụ", 6 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 13, "<i>Theo thỏa thuận trên cơ sở đơn giá thị trường</i>", "Bảng cước dịch vụ", 6 });

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
                unique: true);

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
                unique: true);

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
