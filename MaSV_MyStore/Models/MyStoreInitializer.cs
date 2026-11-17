using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MaSV_MyStore.Models
{
    public class MyStoreInitializer : DropCreateDatabaseAlways<MyStoreEntities>
    {
        protected override void Seed(MyStoreEntities context)
        {
            var categories = new List<Category>
            {
                new Category { CategoryName = "Điện thoại", Description = "Smartphone các hãng" },
                new Category { CategoryName = "Laptop", Description = "Máy tính xách tay" },
                new Category { CategoryName = "Phụ kiện", Description = "Tai nghe, sạc, ốp lưng..." },
                new Category { CategoryName = "Đồng hồ", Description = "Smartwatch & đồng hồ thông minh" }
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();

            var products = new List<Product>
            {
                // Điện thoại
                new Product { 
                    ProductName = "iPhone 15 Pro Max 256GB", 
                    Description = "Chip A17 Pro, camera 48MP, titan", 
                    Price = 34990000, Quantity = 50, SoldQuantity = 120, CategoryID = 1, 
                    ImageUrl = "https://images.unsplash.com/photo-1695048133142-1a20484d2569?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-30) 
                },
                new Product { 
                    ProductName = "Samsung Galaxy S24 Ultra", 
                    Description = "Snapdragon 8 Gen 3, bút S-Pen", 
                    Price = 29990000, Quantity = 40, SoldQuantity = 95, CategoryID = 1, 
                    ImageUrl = "https://images.unsplash.com/photo-1610945415295-d9bbf067e59c?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-25) 
                },
                new Product { 
                    ProductName = "Xiaomi 14 Ultra", 
                    Description = "Camera Leica, sạc nhanh 90W", 
                    Price = 22990000, Quantity = 60, SoldQuantity = 80, CategoryID = 1, 
                    ImageUrl = "https://images.unsplash.com/photo-1592899677977-9c10ca588bbd?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-20) 
                },
                new Product { 
                    ProductName = "OPPO Find X7 Ultra", 
                    Description = "Camera Hasselblad, màn hình AMOLED", 
                    Price = 21990000, Quantity = 35, SoldQuantity = 45, CategoryID = 1, 
                    ImageUrl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-15) 
                },

                // Laptop
                new Product { 
                    ProductName = "MacBook Air M3 13 inch", 
                    Description = "Chip Apple M3, 8GB RAM, 256GB SSD", 
                    Price = 27990000, Quantity = 30, SoldQuantity = 70, CategoryID = 2, 
                    ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-28) 
                },
                new Product { 
                    ProductName = "Dell XPS 13 Plus", 
                    Description = "Intel Core Ultra 7, màn hình OLED", 
                    Price = 35990000, Quantity = 20, SoldQuantity = 25, CategoryID = 2, 
                    ImageUrl = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-22) 
                },
                new Product { 
                    ProductName = "Asus ROG Zephyrus G14", 
                    Description = "AMD Ryzen 9, RTX 4060, gaming", 
                    Price = 42990000, Quantity = 15, SoldQuantity = 40, CategoryID = 2, 
                    ImageUrl = "https://images.unsplash.com/photo-1603302576837-37561b2e2302?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-18) 
                },

                // Phụ kiện
                new Product { 
                    ProductName = "AirPods Pro 2", 
                    Description = "Chống ồn chủ động, USB-C", 
                    Price = 5990000, Quantity = 100, SoldQuantity = 200, CategoryID = 3, 
                    ImageUrl = "https://images.unsplash.com/photo-1606220945770-b5b6c2c55bf1?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-40) 
                },
                new Product { 
                    ProductName = "Sony WH-1000XM5", 
                    Description = "Chống ồn hàng đầu, 30h pin", 
                    Price = 7990000, Quantity = 45, SoldQuantity = 110, CategoryID = 3, 
                    ImageUrl = "https://images.unsplash.com/photo-1546435770-a3e426bf472b?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-35) 
                },
                new Product { 
                    ProductName = "Sạc nhanh Anker 65W", 
                    Description = "3 cổng, GaN, nhỏ gọn", 
                    Price = 890000, Quantity = 150, SoldQuantity = 300, CategoryID = 3,
                    ImageUrl = "https://images.unsplash.com/photo-1609091839311-d5365f9ff1c5?w=400&h=400&fit=crop",
                    CreatedDate = DateTime.Now.AddDays(-50) 
                },

                // Đồng hồ
                new Product { 
                    ProductName = "Apple Watch Series 9", 
                    Description = "GPS, 41mm, luôn sáng", 
                    Price = 9990000, Quantity = 40, SoldQuantity = 85, CategoryID = 4, 
                    ImageUrl = "https://images.unsplash.com/photo-1434493789847-2f02dc6ca35d?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-12) 
                },
                new Product { 
                    ProductName = "Samsung Galaxy Watch 6", 
                    Description = "45mm, đo huyết áp, ECG", 
                    Price = 7490000, Quantity = 55, SoldQuantity = 60, CategoryID = 4, 
                    ImageUrl = "https://images.unsplash.com/photo-1579586337278-3befd40fd17a?w=400&h=400&fit=crop", 
                    CreatedDate = DateTime.Now.AddDays(-10) 
                }
            };
            context.Products.AddRange(products);
            context.SaveChanges();

            // Tài khoản demo
            context.Users.Add(new User
            {
                Username = "demo",
                Password = "123456",
                Role = "Customer",
                CreatedDate = DateTime.Now
            });
            context.Customers.Add(new Customer
            {
                Username = "demo",
                FullName = "Nguyễn Văn Demo",
                Phone = "0901234567",
                Email = "demo@mystore.com",
                Address = "123 Nguyễn Huệ, Quận 1, TP.HCM",
                CreatedDate = DateTime.Now
            });
            context.SaveChanges();
        }
    }
}
