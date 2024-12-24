using CalTrack.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CalTrack.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalTrack.Core.Concretes
{
    public class FoodMeal:BaseEntity
    {
        public int UserId { get; set; }
        public int FoodId { get; set; }

        public double Portion { get; set; }

        public virtual User User { get; set; }
        public virtual Food Food { get; set; }

        [Column(TypeName = "nvarchar")]
        public virtual MealType MealType { get; set; }

        
       
    }
}
