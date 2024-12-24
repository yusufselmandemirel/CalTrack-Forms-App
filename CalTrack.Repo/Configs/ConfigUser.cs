using CalTrack.Core.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Diagnostics;
using CalTrack.Core.Enums;
namespace CalTrack.Repo.Configs
{
    public class ConfigUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.LastName).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.Username).IsRequired().HasColumnType("nvarchar(50)");
            builder.HasIndex(x => x.Username).IsUnique();
            builder.Property(x => x.Password).IsRequired().HasColumnType("nvarchar(20)");
            builder.Property(x => x.BirthDate).IsRequired().HasColumnType("date");
            builder.Property(x => x.Height).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.Width).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.City).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.ActivityLevel).HasColumnType("nvarchar(50)");
            builder.Property(x => x.gender).HasColumnType("nvarchar(50)");
            builder.HasData
                (
                new User() { Id = 1, Name = "Admin", LastName = "Admin", ActivityLevel = ActivityLevel.active, BirthDate = new DateTime(1997,12,20), City="İstanbul", gender=Gender.Male, Height=182,Width=100, Username="admin@gmail.com", Password="Admin123*" },
                new User() { Id = 2, Name = "Emine", LastName = "Kaya", ActivityLevel = ActivityLevel.moderate, BirthDate = new DateTime(1995, 7, 25), City = "Ankara", gender = Gender.Female, Height = 165, Width = 60, Username = "emine.kaya@hotmail.com", Password = "Emine123*" },
                new User() { Id = 3, Name = "Mehmet", LastName = "Öztürk", ActivityLevel = ActivityLevel.sedentary, BirthDate = new DateTime(1987, 11, 15), City = "İzmir", gender = Gender.Male, Height = 180, Width = 90, Username = "mehmet@gmail.com", Password = "Mehmet123*" },
                new User() { Id = 4, Name = "Zeynep", LastName = "Demir", ActivityLevel = ActivityLevel.active, BirthDate = new DateTime(1992, 2, 5), City = "Bursa", gender = Gender.Female, Height = 160, Width = 55, Username = "zeynep@gmail.com", Password = "Zeynep123*" },
                new User() { Id = 5, Name = "Murat", LastName = "Çelik", ActivityLevel = ActivityLevel.moderate, BirthDate = new DateTime(1985, 9, 30), City = "Antalya", gender = Gender.Male, Height = 185, Width = 95, Username = "murat@gmail.com", Password = "Murat123*" }
                );

        }
    }
}
