using CalTrack.Core.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Service.Services
{
    public interface IFoodMealService
    {
        bool Delete(int id);

        bool Add(FoodMeal foodmeal);

        bool Update(FoodMeal foodmeal);
        FoodMeal GetFoodMealById(int id);

        IQueryable<FoodMeal> GetAll();
    }
}
