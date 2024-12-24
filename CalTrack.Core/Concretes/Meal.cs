using CalTrack.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalTrack.Core.Helpers;
using CalTrack.Core.Enums;

namespace CalTrack.Core.Concretes
{
    public class Meal:BaseEntity
    {
        public string? Name { get; set; }
        public virtual ICollection<FoodMeal> FoodMeals { get; set; }         
        public MealType MealType { get; set; }

        

        
       

    }
}
