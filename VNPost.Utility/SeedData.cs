using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VNPost.Models.Entity;

namespace VNPost.Utility
{
    public class SeedData
    {
        public static void AddSeedDataToMenu(ModelBuilder builder)
        {
            builder.Entity<Menu>().HasData(new Menu { Id = 8, Key = "", Value = "Bưu chính chuyển phát", Link = "/Posts/Service/List/1" });
            builder.Entity<Menu>().HasData(new Menu { Id = 9, Key = "", Value = "Tài chính bưu chính", Link = "/Posts/Service/List/2" });
            builder.Entity<Menu>().HasData(new Menu { Id = 10, Key = "", Value = "Phân phối -Truyền thông", Link = "/Posts/Service/List/3" });
            builder.Entity<Menu>().HasData(new Menu { Id = 11, Key = "", Value = "Tin tức", Link = "/Posts/Article/List" });
        }

        public static void AddSeedDataBanner(ModelBuilder builder)
        {
            builder.Entity<Banner>().HasData(new Banner { Id = 1, Description = "", Image = "/image/slider/banner1.jpg", Link = "#" });
            builder.Entity<Banner>().HasData(new Banner { Id = 2, Description = "", Image = "/image/slider/banner2.jpg", Link = "#" });
            builder.Entity<Banner>().HasData(new Banner { Id = 3, Description = "", Image = "/image/slider/banner3.jpg", Link = "#" });
            builder.Entity<Banner>().HasData(new Banner { Id = 4, Description = "", Image = "/image/slider/banner4.jpg", Link = "#" });
        }

        public static void AddSeedToColumnist(ModelBuilder builder)
        {
            builder.Entity<Columnist>().HasData(new Columnist { Id = 1, Name = "Tin Vietnam Post", FatherId = 0 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 2, Name = "Bưu điện - Văn hóa xã", FatherId = 0 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 3, Name = "Người bưu điện", FatherId = 0 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 4, Name = "Hoạt động Đảng - Đoàn thể", FatherId = 0 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 5, Name = "Hoạt động ngành", FatherId = 1 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 6, Name = "Thương mại điện tử", FatherId = 1 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 7, Name = "Hành chính công", FatherId = 1 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 8, Name = "Lương hưu - bảo trợ xã hội", FatherId = 1 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 9, Name = "Điểm chi trả chế độ BHXH", FatherId = 1 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 10, Name = "Bưu chính thế giới", FatherId = 1 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 11, Name = "Gương điển hình", FatherId = 3 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 12, Name = "Hoạt động cộng đồng", FatherId = 3 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 13, Name = "Viết thư UPU", FatherId = 3 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 14, Name = "Cuộc thi ảnh bưu điện trong tôi", FatherId = 3 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 15, Name = "Tìm hiểu Tem Bưu chính", FatherId = 3 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 16, Name = "Công tác Đảng", FatherId = 4 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 17, Name = "Công đoàn", FatherId = 4 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 18, Name = "Đoàn thanh niên", FatherId = 4 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 19, Name = "Góp ý xây dựng cơ chế - chính sách", FatherId = 4 });
            builder.Entity<Columnist>().HasData(new Columnist { Id = 20, Name = "Bưu điện - Văn hóa xã", FatherId = 2 });
        }

        public static void AddSeedToCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(new Category { Id = 1, Name = "Bưu chính chuyển phát", Img = "/image/category/ImageCaching.ashx.png" });
            builder.Entity<Category>().HasData(new Category { Id = 2, Name = "Tài chính bưu chính", Img = "/image/category/ImageCaching.ashx-2.png" });
            builder.Entity<Category>().HasData(new Category { Id = 3, Name = "Phân phối - Truyền thông", Img = "/image/category/ImageCaching.ashx-3.png" });
        }

        public static void AddSeedToPost(ModelBuilder builder)
        {
            builder.Entity<Service>().HasData(new Service { Id = 1, Title = "Chuyển phát nhanh EMS", Description = "Là dịch vụ chuyển phát nhanh thư, tài liệu, vật phẩm, hàng hóa từ người gửi đến người nhận giữa Việt Nam trong nước và các nước trên thế giới trong khuôn khổ Liên minh Bưu chính Thế giới (UPU) và Hiệp hội EMS theo chỉ tiêu thời gian được Công ty Cổ phần Chuyển Phát Nhanh Bưu điện công bố trước. Chi tiết xin tham khảo tại website: www.ems.com.vn", DescriptionImg = "/image/post/ImageCaching.ashx.jpeg", CategoryId = 1 });
            builder.Entity<Service>().HasData(new Service { Id = 2, Title = "Bưu phẩm đảm bảo", Description = "Bưu phẩm bảo đảm là dịch vụ chấp nhận, vận chuyển và phát bưu phẩm đến địa chỉ nhận trong nước và quốc tế; bưu phẩm được gắn số hiệu để theo dõi, định vị trong quá trình chuyển phát.", DescriptionImg = "/image/post/ImageCaching.ashx-2.jpeg", CategoryId = 1 });
            builder.Entity<Service>().HasData(new Service { Id = 3, Title = "Bảo hiểm phi nhân thọ PTI", Description = "Là dịch vụ giới thiệu, chào bán bảo hiểm, thu xếp việc giao kết hợp đồng bảo hiểm thông qua mạng lưới bưu cục, điểm cung cấp dịch vụ của Tổng Công ty Bưu điện Việt Nam.", DescriptionImg = "/image/post/ImageCaching-3.ashx.jpeg", CategoryId = 2 });
            builder.Entity<Service>().HasData(new Service { Id = 4, Title = "Thu hộ - Chi hộ", Description = "Là dịch vụ cho phép khách hàng nộp tiền phí bảo hiểm, vay trả góp, tiền điện, nước, cước điện thoại, tiền đặt chỗ, mua hàng qua mạng, tiền phí phạt vi phạm giao thông, tiền thuế, tiền lệ phí hồ sơ xét tuyển ĐH,CĐ, tiền cấp đổi CMND, Hộ chiếu, tiền đặt vé máy bay…tại bưu cục", DescriptionImg = "/image/post/ImageCaching-4.ashx.jpeg", CategoryId = 2 });
            builder.Entity<Service>().HasData(new Service { Id = 5, Title = "Sàn thương mại điện tử POSTMART", Description = "POSTMART là sàn giao dịch thương mại điện tử được sáng lập bởi Tổng Công ty Bưu Điện Việt Nam (VNPost) và vận hành bởi Công ty Phát hành báo chí TW.", DescriptionImg = "/image/post/ImageCaching-5.ashx.jpeg", CategoryId = 3 });
            builder.Entity<Service>().HasData(new Service { Id = 6, Title = "Truyền thông, quảng cáo", Description = "Truyền thông quảng cáo qua các xuất bản phẩm, hệ thống truyền thông quảng cáo ngoài trời, tại các bưu cục, trên các phương tiện vận tải, phong bì...", DescriptionImg = "/image/post/ImageCaching-6.ashx.jpeg", CategoryId = 3 });
        }

        public static void AddSeedToService(ModelBuilder builder)
        {
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 1, ServiceId = 1, Name = "Phạm vi cung cấp", Content = "<p>Toàn quốc và trên 100 quốc gia và vùng lãnh thổ khắp thế giới theo thoả thuận giữa Công ty và Bưu chính các nước thuộc Liên minh Bưu chính Thế giới (UPU) hoặc các đối tác khác.</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 2, ServiceId = 1, Name = "Khối lượng, kích thước", Content = "<h4>Khối lượng:</h4><br/><p>- Khối lượng bưu gửi EMS thông thường: Tối đa 31,5kg/bưu gửi.</p><br /><p>- Đối với bưu gửi là hàng nguyên khối không thể tách rời, vận chuyển bằng đường bộ được nhận gửi tối đa đến 50kg, nhưng phải đảm bảo giới hạn về kích thước theo quy định.</p><br /><p>- Đối với bưu gửi là hàng nhẹ (hàng có khối lượng thực tế nhỏ hơn khối lượng qui đổi), khối lượng tính cước không căn cứ vào khối lượng thực tế mà căn cứ vào khối lượng qui đổi theo cách tính như sau: Khối lượng qui đổi (kg) = Chiều dài x Chiều rộng x Chiều cao (cm) / 6000</p><br /><p>- Đối với bưu gửi quốc tế: Thực hiện theo thông báo của Công ty Cổ phần Chuyển phát nhanh Bưu điện đối với từng nước.</p><br /><h4>Kích thước:</h4><br /><p>- Kích thước tối thiểu:</p><br /><p>+ Ít nhất một mặt bưu gửi có kích thước không nhỏ hơn 90mm x 140mm với sai số 2 mm.</p><br /><p>+ Nếu cuộn tròn: Chiều dài bưu gửi cộng hai lần đường kính tối thiểu 170 mm và kích thước chiều lớn nhất không nhỏ  hơn 100mm.</p><br /><p>- Kích thước tối đa: Bất kỳ chiều nào của bưu gửi không vượt quá 1500mm và tổng chiều dài cộng với chu vi lớn nhất (không đo theo chiều dài đã đo) không vượt quá 3000mm.</p><br /><p>- Bưu gửi có kích thước lớn hơn so với kích thước thông thường được gọi là bưu gửi cồng kềnh và có quy định riêng phụ thuộc vào từng nơi nhận, nơi phát và điều kiện phương tiện vận chuyển.</p><br /><p>- Đối với bưu gửi quốc tế: Kích thước thông thường đối với bưu gửi EMS là bất kỳ chiều nào của bưu gửi cũng không vượt quá 1,5m và tổng chiều dài cộng với chu vi lớn nhất (không đo theo chiều dài đã đo) không vượt quá 3m.</p><br />" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 3, ServiceId = 1, Name = "Cước phí", Content = "<p>Tùy theo từng dịch vụ sẽ có bảng cước giá khác nhau kèm theo phí dịch vụ của các dịch vụ cộng thêm.</p><p>Bảng cước dịch vụ chuyển phát nhanh EMS trong nước</p><p>Bảng cước dịch vụ chuyển phát nhanh EMS quốc tế</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 4, ServiceId = 2, Name = "Phạm vi cung cấp dịch vụ", Content = "<p>Toàn quốc</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 5, ServiceId = 2, Name = "Quy định về khối lượng / kích thước", Content = "<h4>a. Giới hạn kích thước của bưu thiếp:</h4><br/><p>- Kích thước tối đa: 165 mm x 245 mm, với sai số 2 mm.</p><br /><p>- Kích thước tối thiểu: 90 mm x 140 mm, với sai số 2 mm. </p><br /><p>- Tỷ lệ tối thiểu giữa chiều dài và chiều rộng: dài = rộng x  (≈ 1,4).</p><br /><h4>b. Giới hạn kích thước của gói nhỏ: </h4><br /><p>- Kích thước tối thiểu: 210 x 148 mm.</p><br /><p>- Kích thước tối đa: Tổng chiều dài, chiều rộng và chiều cao là 900 mm, nhưng kích thước chiều lớn nhất không vượt quá 600 mm, với sai số 2 mm. Nếu cuộn tròn, chiều dài cộng hai lần đường kính là 1040 mm, nhưng kích thước lớn nhất không vượt quá 900 mm.</p><br /><h4>c. Giới hạn kích thước của các loại bưu phẩm khác:</h4><br /><p>- Kích thước tối đa: Tổng chiều dài, chiều rộng và chiều cao là 900 mm, nhưng kích thước chiều lớn nhất không vượt quá 600 mm, với sai số 2 mm. Nếu cuộn tròn, chiều dài cộng hai lần đường kính là 1040 mm, nhưng kích thước lớn nhất không vượt quá 900 mm, với sai số 2 mm.</p><br /><p>- Kích thước tối thiểu: Một mặt kích thước không nhỏ hơn 90 mm x 140 mm với sai số 2 mm. Nếu cuộn tròn: chiều dài cộng hai lần đường kính là 170 mm, nhưng kích thước chiều lớn nhất không nhỏ hơn 100 mm</p><br />" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 6, ServiceId = 3, Name = "Phạm vi cung cấp dịch vụ", Content = "<p>Tất cả các điểm cung cấp dịch vụ của Bưu điện Việt Nam trên toàn quốc</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 7, ServiceId = 3, Name = "Bảng cước dịch vụ", Content = "<p>Mức phí bảo hiểm cạnh tranh với nhiều chương trình bán hàng hấp dẫn.</p><br/><p>Liên hệ với các điểm bán hàng của Bưu điện trên toàn quốc để biết thông tin phí bảo hiểm chi tiết.</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 8, ServiceId = 4, Name = "Phạm vi cung cấp dịch vụ", Content = "<p>Tất cả các điểm cung cấp dịch vụ của Bưu điện Việt Nam trên toàn quốc</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 9, ServiceId = 4, Name = "Bảng cước dịch vụ", Content = "<p>Giá cước được thỏa thuận tùy theo từng đối tác và theo sản lượng giao dịch.</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 10, ServiceId = 5, Name = "Phạm vi cung cấp dịch vụ", Content = "<p>Trên toàn Quốc!</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 11, ServiceId = 5, Name = "Đặc điểm dịch vụ", Content = "<p>Dịch vụ thương mại điện tử hay con gọi là E-commerce là hoạt động kinh doanh, mua bán các loại sản phẩm hàng hóa/ dịch vụ diễn ra trên môi trường internet, đặc biệt là thông qua các website và ứng dụng di động. Các hoạt động diễn ra chủ yếu theo 3 hình thức B2C, B2B và C2C</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 12, ServiceId = 6, Name = "Phạm vi cung cấp dịch vụ", Content = "<p>Tất cả các điểm giao dịch trên 63 tỉnh, thành phố</p>" });
            builder.Entity<ServiceDetail>().HasData(new ServiceDetail { Id = 13, ServiceId = 6, Name = "Bảng cước dịch vụ", Content = "<i>Theo thỏa thuận trên cơ sở đơn giá thị trường</i>" });
        }
        public static void AddSeedToUser(ModelBuilder builder)
        {
            builder.Entity<IdentityUser>().HasData(new IdentityUser { Id = "01b96c14-de28-4831-afa9-3d1f84b93aed", UserName = "admin@gmail.com", Email = "admin@gmail.com", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAENVfYO/ByyafuleVAgUNZiUlG+Vyi645v0VP2+KuzBuUxIrzqh2Hy0RwzJf21yFrAQ==	", NormalizedEmail = "ADMIN@GMAIL.COM", NormalizedUserName = "ADMIN@GMAIL.COM" });
        }
        public static void AddSeedToRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "13d23c51-re38-4831-wqa2-2e3f21c23ewd", Name = "Admin", NormalizedName = "ADMIN" });
        }

        public static void AddSeedToRoleUser(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = "13d23c51-re38-4831-wqa2-2e3f21c23ewd", UserId = "01b96c14-de28-4831-afa9-3d1f84b93aed" });
        }

        public static void AddSeedToPermission(ModelBuilder builder)
        {
            builder.Entity<Permission>().HasData(new Permission { Id = 1, Name = "Create" });
            builder.Entity<Permission>().HasData(new Permission { Id = 2, Name = "Update" });
            builder.Entity<Permission>().HasData(new Permission { Id = 3, Name = "Delete" });
        }

        public static void AddSeedToStatuses(ModelBuilder builder)
        {
            builder.Entity<Status>().HasData(new Status { Id = 1, Name = "Prepare" });
            builder.Entity<Status>().HasData(new Status { Id = 2, Name = "Pending" });
            builder.Entity<Status>().HasData(new Status { Id = 3, Name = "Done" });
        }
    }
}

