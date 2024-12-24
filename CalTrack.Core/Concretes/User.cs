using CalTrack.Core.Abstracts;
using CalTrack.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CalTrack.Core.Helpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalTrack.Core.Concretes
{
    public class User : BaseEntity
    {
        private double _totalRequiredCalories;
        private double _bmi;
        private int _age;
        private string _password;
        private string _username;

        public User()
        {
          
        }

        public string Username
        {
            get { return _username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username is required.");
                }

                var usernameRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");//Mail format kontrolü
                if (!usernameRegex.IsMatch(value))
                {
                    throw new ArgumentException("Invalid username.");
                }

                _username = value;
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Password is required.");
                }
                if (value.Length <= 8)
                {
                    throw new ArgumentException("Password must be at least 8 characters long.");
                }
                if (!value.Any(char.IsUpper))
                {
                    throw new ArgumentException("Password must contain at least one uppercase letter.");
                }


                if (!value.Any(c => "!@#$%^&*()_-+=<>?".Contains(c))) //En az bir özel karakter kontrolü
                {
                    throw new ArgumentException("Password must contain at least one special character.");
                }
                _password = value;
            }
        }
        public DateTime BirthDate { get; set; }

        public int Age => Ages.CalculateAge(BirthDate); 

        public string Name { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }

        public double Width { get; set; }

        public double BMI => CalcBMI.CalculateBMI(Height, Width);


        public double DailyRequiredCalorie => DailyReqCalorie.CalculateDailyRequiredCalorie(Width, Height, Age, gender, ActivityLevel);
           
     
        
        [Column(TypeName = "nvarchar")]
        public Gender gender { get; set; }
       
        [Column(TypeName = "nvarchar")]
        public ActivityLevel ActivityLevel { get; set; }
        public string City { get; set; }

        public virtual ICollection<FoodMeal> FoodMeals { get; set; }
    }
}
