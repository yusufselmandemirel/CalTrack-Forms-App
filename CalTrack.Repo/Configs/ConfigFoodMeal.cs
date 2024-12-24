using CalTrack.Core.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalTrack.Core.Enums;
namespace CalTrack.Repo.Configs
{
    public class ConfigFoodMeal : IEntityTypeConfiguration<FoodMeal>
    {
        public void Configure(EntityTypeBuilder<FoodMeal> builder)
        {
            builder.Property(x => x.Portion).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.MealType).HasColumnType("nvarchar(50)");
          
        }
    }
}
