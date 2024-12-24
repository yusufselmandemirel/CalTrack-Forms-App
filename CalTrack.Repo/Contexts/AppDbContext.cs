using CalTrack.Core.Concretes;
using CalTrack.Repo.Configs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Repo.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<FoodMeal> FoodMeals { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ALRICK\\SQLEXPRESS;Initial Catalog=CalTrackApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False\r\n");

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConfigCategory());
            modelBuilder.ApplyConfiguration(new ConfigFood());
            modelBuilder.ApplyConfiguration(new ConfigFoodMeal());
            modelBuilder.ApplyConfiguration(new ConfigMeal());
            modelBuilder.ApplyConfiguration(new ConfigUser());
        }
    }
}
