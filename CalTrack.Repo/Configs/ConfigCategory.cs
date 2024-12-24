using CalTrack.Core.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Repo.Configs
{
    public class ConfigCategory : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(50)");
            builder.HasMany(x => x.Foods).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction);
            builder.HasData
                (
                new Category() { Id = 1, Name = "Ana Yemekler" },  
                new Category() { Id = 2, Name = "Atıştırmalıklar" },  
                new Category() { Id = 3, Name = "İçecekler" },  
                new Category() { Id = 4, Name = "Salatalar" },  
                new Category() { Id = 5, Name = "Çorbalar" }, 
                new Category() { Id = 6, Name = "Tatlılar" }, 
                new Category() { Id = 7, Name = "Et Yemekleri" },  
                new Category() { Id = 8, Name = "Sebze Yemekleri" },  
                new Category() { Id = 9, Name = "Deniz Ürünleri" }, 
                new Category() { Id = 10, Name = "Hamur İşleri" },  
                new Category() { Id = 11, Name = "Kahvaltılıklar" },   
                new Category() { Id = 12, Name = "Dondurmalar" },  
                new Category() { Id = 13, Name = "Meyve" },  
                new Category() { Id = 14, Name = "Soslar" }, 
                new Category() { Id = 15, Name = "Makarna Çeşitleri" }

                );
        }
    }
}
