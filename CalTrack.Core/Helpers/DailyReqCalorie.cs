using CalTrack.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Core.Helpers
{
    public static class DailyReqCalorie
    {
        public static double CalculateDailyRequiredCalorie(double weight,double height,int age,Gender gender,ActivityLevel activityLevel)
        {
            double bmr = 0;
            if (gender == Gender.Male)
            {
               
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else if (gender==Gender.Female)//For women
            {
                
                bmr = 10 * weight + 6.25 * height - 5 * age - 161;
            }
            double activityMultiplier = activityLevel switch
            {
                ActivityLevel.sedentary => 1.2,
                ActivityLevel.light => 1.375,
                ActivityLevel.moderate => 1.55,
                ActivityLevel.active => 1.725,
                ActivityLevel.superactive => 1.9,
                _ => throw new ArgumentException("Invalid activity level. Use one of the following: sedentary, light, moderate, active, superactive.")
        };
            double totalReqCalories = bmr * activityMultiplier;
            return totalReqCalories;
        }
    }
}
