using CalTrack.Core.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalTrack.Core.Abstracts;

namespace CalTrack.Repo.Configs
{
    public class ConfigFood:IEntityTypeConfiguration<Food>
    {

        public void Configure(EntityTypeBuilder<Food> builder)
        {
            
            builder.Property(x => x.PortionCalorie).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasData
                (
                new Food() { Id = 1, Name = "Köfte", CategoryId = 7, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Köfte.jpg", PortionCalorie = 250 },
                new Food() { Id = 2, Name = "Börek", CategoryId = 10, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Börek.jpg", PortionCalorie = 300 },
                new Food() { Id = 3, Name = "Çay", CategoryId = 3, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Çay.jpg", PortionCalorie = 2 },
                new Food() { Id = 4, Name = "Kısır", CategoryId = 4, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Kısır.jpeg", PortionCalorie = 250 },
                new Food() { Id = 5, Name = "Mercimek Çorbası", CategoryId = 5, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\MercimekÇorbası.jpg", PortionCalorie = 150 },
                new Food() { Id = 6, Name = "Kadayıf", CategoryId = 6, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Kadayıf.jpg", PortionCalorie = 350 },
                new Food() { Id = 7, Name = "Tavuk Şiş", CategoryId = 7, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Tavuk Şil.png", PortionCalorie = 270 },
                new Food() { Id = 8, Name = "Sebze Sote", CategoryId = 8, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Sebze Sote.jpg", PortionCalorie = 180 },
                new Food() { Id = 9, Name = "Balık Izgara", CategoryId = 9, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Balık Izgara.jpg", PortionCalorie = 220 },
                new Food() { Id = 10, Name = "Poğaça", CategoryId = 10, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Poğaça.jpg", PortionCalorie = 230 },
                new Food() { Id = 11, Name = "Menemen", CategoryId = 11, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Menemen.jpg", PortionCalorie = 150 },
                new Food() { Id = 12, Name = "Çikolatalı Dondurma", CategoryId = 12, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Çikolatalı Dondurma.jpeg", PortionCalorie = 180 },
                new Food() { Id = 13, Name = "Meyve Salatası", CategoryId = 13, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Meyve Salatası.png", PortionCalorie = 120 },
                new Food() { Id = 14, Name = "Zeytinyağlı Enginar", CategoryId = 8, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Enginar.jpg", PortionCalorie = 140 },
                new Food() { Id = 15, Name = "Tatlı Sos", CategoryId = 14, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Tatlı Sos.jpg", PortionCalorie = 80 },
                new Food() { Id = 16, Name = "Spagetti", CategoryId = 15, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Spagetti.jpg", PortionCalorie = 200 },
                new Food() { Id = 17, Name = "Simit", CategoryId = 10, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Simit.jpg", PortionCalorie = 280 },
                new Food() { Id = 18, Name = "Limonata", CategoryId = 3, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\lemonade.jpg", PortionCalorie = 100 },
                new Food() { Id = 19, Name = "Sebze Çorbası", CategoryId = 5, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Sebze Çorbası.jpg", PortionCalorie = 120 },
                new Food() { Id = 20, Name = "Çikolatalı Kek", CategoryId = 6, PhotoPath = "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Çikolatalı Kek.jpg", PortionCalorie = 350 }


                );

        }
    }
}
