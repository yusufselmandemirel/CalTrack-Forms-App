using CalTrack.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Core.Concretes
{
    public class Food:BaseEntity
    {
       
        private string _photoPath;

        public string Name { get; set; }
        public virtual ICollection<FoodMeal> FoodMeals { get; set; }

        public double PortionCalorie { get; set; }

        public string? PhotoPath
        {
            get => _photoPath;
            set
            {
                _photoPath = value;
            }
        }

       

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

       
    }
}
