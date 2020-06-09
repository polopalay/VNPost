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
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuLocations", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1, "VN", "data:image/gif;base64,R0lGODlhGwASAOYAAOgAAuAACtgAE9YAFdIAGdAAGs8AG8kAH8cAIcAAJb4AJ70AJ7wAJ6sAI5gAH70AKLwAKLsAKLsAKboAKLoAKbkAKrcAK/3/Av3/A/z/BP3/Bfz/Bvn/B/r/B/n/CP7/Af/9Af7/Av/9Av/2Af/6Af/7Af/1Af7rAP7tAP3lAP3fAPzYAPzTAPvQAPrJAPivAPewAPajAPagAPWQAPWUAPWIAPSFAPSAAPN+APOAAPOBAPN9APJ6APF1AO9QAO5OAO5DAO0/AOw5AO02AOwuAOwvAOwlAOslAOseAOsWAOoQAOgCAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACwAAAAAGwASAAAHxIANgoOEhYaHComKi4yNiw4NjowLko+RlQoJRAiYCpCYCwQtAQyYn5USQxk/FKaXiw8UshYzGjEVshQPjaeKC0k2Ojw7KRgoOTw4NUaUlo0FOx0bHR8kItIdNALNir2+EkgsICXkISpCE9zdr4wSAykXICEmSq2O3osQSiMeHxwYQOzxYreIwg0NLoLA2PACgiR8iRYcWCHDAIUEPU4AcDjQ0YMlPiDsWhChyBGOjCAmSoAyUcuUBDtVguSgps2bOHPiDAQAOw==" },
                    { 11, "Policy", "Ghi rõ nguồn \"www.vnpost.vn\" khi phát hành lại thông tin từ website này" },
                    { 9, "Company", "TỔNG CÔNG TY BƯU ĐIỆN VIỆT NAM - VIETNAM POST" },
                    { 8, "PhoneNumber", "1900 54 54 81" },
                    { 7, "PhoneText", "Đường dây nóng hỗ trợ" },
                    { 10, "Location", "Địa chỉ: Số 05 đường Phạm Hùng - Mỹ Đình 2 - Nam Từ Liêm - Hà Nội - Việt Nam" },
                    { 5, "Mess", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAADE0lEQVRYR+2WTU4bQRCFv8JSyA44AeYEmBNgToBzAvAmjFdxThA4QZyVTTaYE8Q+QcwJYk6AOUHMjiSKK6qenh+PZ+wxREKR0tLIkqen+9WrV69KeOElL3w//x4A7VKngvKbe2kxeS6DSxnQz9RQjlHq4J68NQbsGUjAcF1AuQD0kgbKB6BWcOADsJXzborQljOuywKZA6BXbPODK6DhD3hAGQAje7KUu/0/qTuGlAbCrv9uzAZNeeuYWbpiAP7yr3HUygWv6UiT6apDovfa5RSh49mZoryRlgNfuByAzOW3Fs1TBebOeqSDcAJM2eBoGRMhgC59/8Etm9TXibootNSZEzY5KDpTnNJnfAMs37WnRp4HRHtOA/sI7+XMpWZhSYxUuZAW52XzXWaf8wzBdDWRgL0iACOEQzY4yOZKu1TZ4JAZNxEzrkStBF8xNFp9JRwzc8a0IDjtMnHVoezlsSvaQw2ZBIu2HFMIYwk4cICEOxeJp1UvaaN8dP9tspPNtXYJA1SOzCMQ+nLmSjs8piSAoQQ05gAoTWnRXxsAHAN9CWiGACKEeSkIS6rGa8ZRZN6eq+koXK4tzzm9QXvOR7YidlLV8UkC2saAqfMdyrW0OC0jrrJ7vDGZs95KkNi69lwKrMfsGQNJXnNYKHtZdp83NyvvKj5dsWOGlj8xm4+M6BxxzWelc5UBlHXWdPQxiJCF3aQXRKZhIEp4+BIHNEa/+J5SaG7axQWdbUbfUwf3Cc2p1NDhPeMEpQ1so9xToVHUB5wYoZ4ASFwrG9wYYYAwSk9B7sIKu8ycuKwKohZu3w/Z5LTI/32K7lCGCYC0oYQQioaOYhkoN8D5qhYcl6KJPhZF0hEtbx2bBdy7RxeZebpFuj93u9EsGEMjZgzKpGvBB1IA3NSz9hBiJfWL6qrpJzPmxb4wJ8J15wCvZBOdzYcmVtOKVVE4ihlrStVrxH6jNZWAnXDLM5efgKzJWKrmU5ScPfSgLJWH7m/fuJ4NII3fg0km6QrTnBZvFWNzhxPrXwWwDpkG1lL+YgAisP8B/AE6nGKNmot1GAAAAABJRU5ErkJggg==" },
                    { 4, "Search-price", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAADGUlEQVRYR8WXTVYTQRDHf5WFYWc4gfEEwgkgJyCeQLKRZEVyAuEEZpfBDeEEJicwnMDkBOIJDDvxPWlfdfd8ZnpmwPd0dvC6u3719a+K8MzPzOginADHQBc48E/dAXcIK4SlvGddZUKeat8b/gCcNry7wnApI1Zl558EYCLOgWnhoQ2gRraZ/x8jHBXOzWkzkUHuHI0BTMR1zmvDJTCXERrync9c0+EXpxgugJf+wJo2vSxEI4CC8Q2GfshwkcSC/GSK8K4MohbAXDHG8NFfXtLmtBjGJrVgZswzEHMZMtB7lQCW/oFvQAfY0OY4ZNzMuEA4lyH7IaAchKGnhVkNkKX2F4L5frBR0s7o0+a2DNQ7pDWjNbGSIb0gQM57w42MytvOfOKAR774KCV8MiyPbi6lLQ7DAFf0MXy2Lwpv5YxFqfczKzqvECY8WtHp0qIjZzvtaq97x364P7gMA7icquDcy9DWQOlnIoxlDHgcgFaVPMJwWwWQHhpZuS0HiCPgxCioeNnLvmDVubu/B9Aa+M3CpsF9K1pMqmZABiDchmZmh4kLU0UEYs/MzBappk1BthgOgyqZprcSwAlHQ4AEJLLFeuLToTK885nIFqjOlU1VF6QK2Ga/qfolj7t6CAF89eN7WVUDOu9VBbVdBjJiXnQloxXaiguM3QvcmDa8LkuBH+fuXWFSrYSR7es3sWqVArhB008mnuG7QoTmfyb8DjLUXtYJLSyxYzgYhUwR2qKt0oOc915d66dh2udbWvRC7WVbC7pByXaDTSXbrW4+RU+ZhnptTYtB3Z4XqJXUuObeS3XdMEovpa9uEcZyxk1V+jKp0fVMJ2XseW6wlQL46i4znrWpOZ/zgmXp6I3sxuzGc0KzO1V3AGqM39vlM5Xd+GntlvxSmg+P3huXtXIOoMZ4shH57hj7Fq3KhBqessc0JGQJQFPjWWu2rVr0ebT5VRHSz/0wabEO7RDZNyzAc4w3KcAmZ+R/GrdqXFiXs9CVW3AT75qckXilKhz+J8ZdBNKBEzP8M+MOIF2pOhgW7DFuOvubhLjuzB9Hh2lzHqyLfAAAAABJRU5ErkJggg==" },
                    { 3, "Logo", "data:image/png;base64,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" },
                    { 2, "US", "data:image/gif;base64,R0lGODlhGwASAPcAAMq6u//19v709awAF//3+KkAGv3p7NUAJcIAIKoAHpYAGu8nSvI9XPV7kPiUpfaUpvmruMaJlPesuuGlr/i3wv3N1ePS1f74+dkAKdkAKtgAKtEAKcgAJsQAJb0AJLQAI64AIacAIaAAH5cAHb0fQOwoUO48X78xTfJuidpje8FYbcNidfR7k8Z2hvejtMaDkMeSnMikq9+UpPrN18rGx8IAO7IANpUALdQ6acZAcs11nc+Iq8+avNG309Ta7zlcvEZnv0Jerh9FpidNqChOqStQqy1SqjFWuDRcvjdfvjJVqzhgvzpiwTlhwDhevDlfvT1jwDdZrT5kwUBmwUFnwkFmwUNow0JnwkRpxENowkRpw0VqxEZrw0dsxElsw0ptxExvxkxvxURjsURksU1wxkxuw05xxVBzxiBJpyFJpyRMqClSrCtRqzNdvjRdvjdgvzdgvjhhvzpjwTpiwDtjwTpivjtjvz5nxD1lwTxkwDxlwD5mwj1lwEFowkNqxENpw0Rqw0VrxD5gsD9hsUhvyElvxUhtxEhuxEtwxUxxxU1yxmeJ0m2N03yZ2ICa1WaJ0meL0m6R1mWDwHOU1XeW1n6c2X+d2n+d2ebd3f/29v/4+P77+8vKygAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACwAAAAAGwASAAAI/wCNCEojRsgYNIOIRFGyJsiNAQUiSpwYccgVM3YU2UlUBYwWLoWc7HDwoKTJkw9aGCGzxAwSM28S6ekCCE8ZHhAk6NzJU0IENXPAuDnjBkwdQ1T6EDpiA4GHp1CjehjBBlGTMHHAzEG0hwsWKYZ6VJhBtqzZGTGGUAk0hwuTLXi6SLHi54mOBizy6t3LYkWRQ3S+LDFER+6WP3eA1DiwobHjxxtCDAG71Y6hKV60ZOESx8emz6BDf+aUBgqcPG3yJOGzBM8SOT9yMDBBu7ZtEyckNYJ06ZGlRZUYUZoUyRGOBSWSK19eggQmAZqgSycQIFMm6Beya9+enUYHDODDi0zHkEFDhvPo058HkQKF+/fw48uHr8KCgfv48+vfnx/ABw4ABijggAQKKMIEFCSo4IIMNrggDDK4IOGEFFZoIYUvJKDAhhx26OGHHgYEADs=" },
                    { 6, "Recruitment", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAApAAAAKQAG8o4lVAAAABGdBTUEAALGOfPtRkwAAACBjSFJNAAB6JQAAgIMAAPn/AACA6QAAdTAAAOpgAAA6mAAAF2+SX8VGAAADGElEQVR42mL8//8/A0lgJqM4kEwD4mAgFgXiX0D8CogPA/E8hvT/10gxDiCAGElywExGOyC5FIhlcKh4B8SZQEesItZIgAAi3gEzGS2B5Eaor/GB/+AQSv8/hxhjAQKIOAfMZFQGknuBWJ5Ij/0CR1H6/y2EFAIEEBORBmaQYDkIsAFxKdDhBM0HCCAmInzPCSS9GEgHpkCsSUgRQAAREwJiJPoeBkAO1yOkCCCAiHEAMyitMJAHWAgpAAggYhzwFojfk2H5PyC+T0gRQAARdkD6/49AcjsZDrgIxGcJKQIIIGJzwTQg/kyiAyYDHf+dkCKAACLOAen/zwPJBhIsXwzUM58YhQABxES0ken/+4BkAhB/xKPqGxBXQusKogBAADGSURlpQi1wBWI5qCdAldFxIJ4OdOgRUowDCCDSHYBwCChr8kAd8AVo8V9yjAEIIMIOgBSnxkCshlTZ/Idms79IUYleXnwAh0r6f7xZGCCA8DtgJiPI0JlAnExmQXQCiH2AjniLSwFAABFKhE4UWA4CFkCci08BQAAR4wBcYBsQg3LGBCBeAsQ/cagLAYYkNy5DAAKIBU/wgzQF4JAFxX0zMGhPQNUKAEl7IJbFolYbiJ2BeBM2gwACCF8IgFpAGnhaPX/RHPQTj1neuCQAAgifA/zwyL1EqWjS/4OK6et41HsAQ0kEmwRAADHhCH5hIOmPx8BzQEvfoImdxKNeDuwILAAggHCFgB1UEy5wiUgxZOCLTRAggHA5IIiAYedwVL/4Ch1HYMhieAoggJiwBD8oJXviMegTEJ/CIv4EiK/g0SeKLVoBAogJR+ITxmPQIyB+jaW2BBXNNwmEnC26AEAAYXPAd2jthgvIQ/M1eshpQEs+XOAuEK9DFwQIICYsPpkHbc1OBOKvWAziBRcqMxmLkCx3h/YNdXB01+qA2BBo9gp0SYAAIlQZgWrBGiB2hzaz0UED1GfToVUzelpZCcQdQIvv4bICIICI7ZppQh0Bq5ZBCUoA2gMCgd9ADCoXXgDxLWiZsBNo8UNCRgMEEPkNEioBgAADAKfduBnHVSiPAAAAAElFTkSuQmCC" }
                });

            migrationBuilder.InsertData(
                table: "MenuLocations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Phân phối - Truyền thông" },
                    { 1, "TopMenu" },
                    { 2, "MainMenu" },
                    { 3, "Tra cứu - Định vị" },
                    { 4, "BottomMenu" },
                    { 5, "Bưu chính chuyển phát" },
                    { 6, "Tài chính bưu chính" },
                    { 8, "Mạng xã hội" }
                });

            migrationBuilder.InsertData(
                table: "MenuLinks",
                columns: new[] { "Id", "Key", "Link", "LocationId", "Value" },
                values: new object[,]
                {
                    { 1, "Description", "#", 1, "Giới thiệu" },
                    { 32, "", "https://twitter.com/buudienvietnam", 8, "fab fa-twitter" },
                    { 31, "", "https://www.facebook.com/vnpost.vn", 8, "fab fa-facebook-f" },
                    { 30, "#", "/", 7, "Dịch vụ phân phối hàng hoá" },
                    { 29, "#", "/", 7, "Dịch vụ Viễn thông - CNTT" },
                    { 28, "#", "/", 7, "Phân phối xuất bản ấn phẩm" },
                    { 27, "#", "/", 7, "Truyền thông, quảng cáo" },
                    { 26, "#", "/", 7, "Sàn thương mại điện tử POSTMART" },
                    { 25, "#", "/", 6, "Dịch vụ Chuyển tiền trong nước" },
                    { 24, "#", "/", 6, "Đại lý ngân hàng" },
                    { 23, "#", "/", 6, "Đại lý Bảo hiểm nhân thọ (Dai-ichi)" },
                    { 22, "#", "#", 6, "Thu hộ - Chi hộ" },
                    { 21, "#", "/", 6, "Bảo hiểm phi nhân thọ PTI" },
                    { 20, "#", "/", 5, "Bưu chính chuyển phát Quốc tế" },
                    { 19, "#", "/", 5, "Bưu chính chuyển phát Trong nước" },
                    { 12, "Email", "#", 4, "Email" },
                    { 11, "News", "#", 4, "Tin tức" },
                    { 10, "Comunity", "#", 4, "Phân phối -Truyền thông" },
                    { 2, "QAndA", "#", 1, "Hỏi đáp" },
                    { 3, "Contact", "#", 1, "Liên hệ" },
                    { 4, "Login", "#", 1, "Login" },
                    { 5, "Search-price", "#", 2, "<p>Tra cước</p><span>DỊCH VỤ</span>" },
                    { 6, "Mess", "#", 2, "<p>Đánh giá &</p><span>KHIẾU NẠI</span>" },
                    { 7, "Recruitment", "#", 2, "<p>Tin</p><span>TUYỂN DỤNG</span>" },
                    { 33, "", "https://www.linkedin.com/authwall?trk=gf&trkInfo=AQEcHBePbUPbnwAAAXKW4SzYfqas88PMwWIydrQUKt7vRdlRm_Thesf7HIcEsfHSkUXiZuX_nMjyj4IfViiABffUTA0XRALzYNn5xU6ph_mz0P_XK4651j2JANKqojtkFw3fRAk=&originalReferer=http://www.vnpost.vn/&sessionRedirect=https%3A%2F%2Fwww.linkedin.com%2Fin%2Ftt-dvkh-529b25197%2F", 8, "fab fa-linkedin" },
                    { 13, "fas fa-map-marker-alt", "#", 3, "Định Vị Bưu Gửi" },
                    { 15, "fas fa-map", "#", 3, "Mạng lưới bưu cục" },
                    { 16, "fas fa-ban", "#", 3, "Tra cứu hàng cấm gửi" },
                    { 17, "fas fa-search-plus", "#", 3, "Tra cứu kỳ cước KHL" },
                    { 18, "fas fa-qrcode", "#", 3, "Mã địa chỉ bưu chính" },
                    { 8, "PostAndD", "#", 4, "Bưu chính chuyển phát" },
                    { 9, "Money", "#", 4, "Tài chính bưu chính" },
                    { 14, "fas fa-money-bill-alt", "#", 3, "Định vị chuyển tiền" },
                    { 34, "", "http://www.vnpost.vn/desktopmodules/vnp_webapi/rssfeed.aspx", 8, "fab fa-instagram" }
                });

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
                name: "IX_MenuLinks_LocationId",
                table: "MenuLinks",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "MenuLinks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MenuLocations");
        }
    }
}
