using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MobileStore.Models
{
    public class MobileData : DropCreateDatabaseAlways<MobileContext>
    {
        protected override void Seed(MobileContext context)
        {
            GetProducts().ForEach(c => context.Products.Add(c));
            GetMobiles().ForEach(p => context.Mobiles.Add(p));
        }
        private static List<Product> GetProducts()
        {
            var categories = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "SamSung"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Huawei"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Oppo"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Xiaomi"
                },
                 new Product
                {
                    ProductID = 5,
                    ProductName = "Nokia"
                },
                  new Product
                {
                    ProductID = 6,
                    ProductName = "Iphone"
                },
            };
            return categories;
        }
        private static List<Mobile> GetMobiles()
        {
            var mobiles = new List<Mobile> {
                new Mobile
                {
                    MoblieID  = 1,
                    MoblieName = "SamSung A50s",
                    Description = "Bức phá mới trong thiết kế từ mặt lưng đến màu sắc vượt trội).",
                    ImagePath ="Pic1.png",
                    Price = 7790000,
                    ProductID = 1
                    },
                new Mobile
                {
                    MoblieID = 2,
                    MoblieName = "SamSung Galaxy Note 10+ ",
                    Description = "Chữ viết tay sang chữ viết văn bản nhanh chóng).",
                    ImagePath ="Pic9.jn",
                    Price = 26990000,
                    ProductID = 1
                    },
                new Mobile
                {
                    MoblieID = 3,
                    MoblieName = "SamSung Galaxy S10 ",
                    Description = "Siêu phẩm năm 2018).",
                    ImagePath ="Pic10.png",
                    Price = 22990000,
                    ProductID = 1
                    },
                new Mobile
                {
                    MoblieID = 2,
                    MoblieName = "Huawei P30 Lite",
                    Description = "Thiết kế hoàn toàn mới . Viền mỏng hơn . Đem lại trải nghiệm xem thoải mái hơn",
                    ImagePath ="Pic2.png",
                    Price = 6699000,
                    ProductID = 2
                },
                new Mobile
                {
                    MoblieID = 3,
                    MoblieName = "Huawei Mate 20 Pro",
                    Description = "Siêu phẩm thuộc hãng Huawei",
                    ImagePath ="Pic3.png",
                    Price = 15999000,
                    ProductID = 2
                },
                new Mobile
                {
                    MoblieID = 4,
                    MoblieName = "Oppo K3",
                    Description = "Thiết kế đẹp , chip mạnh , pin trâu ",
                    ImagePath ="Pic4.png",
                    Price = 7690000,
                    ProductID = 3
                },
                new Mobile
                {
                    MoblieID = 5,
                    MoblieName = "Xiaomi MI9T",
                    Description = "Nổi bật với mặt lưng thiết kế sợi cacbon, cùng đường cong 3D tinh xảo ",
                    ImagePath ="Pic5.png",
                    Price = 7990000,
                    ProductID = 4
                },
                 new Mobile
                {
                    MoblieID = 6,
                    MoblieName = "NOKIA 8.1",
                    Description = " Thiết kế sang trọng và mạnh mẽ ",
                    ImagePath ="Pic6.png",
                    Price = 7990000,
                    ProductID = 5
                },
                 new Mobile
                {
                    MoblieID = 7,
                    MoblieName = "Ihone X",
                    Description = " Siêu phẩm năm 2017 ",
                    ImagePath ="Pic7.png",
                    Price =24000000,
                   ProductID= 6
                },
                  new Mobile
                {
                    MoblieID = 8,
                    MoblieName = "Ihone XS MAX",
                    Description = " Siêu phẩm năm 2018 ",
                    ImagePath ="Pic8.png",
                    Price =26000000,
                    ProductID = 6
                },
            };
            return mobiles;

        }
    }
}