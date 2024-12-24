using CalTrack.Core.Concretes;
using CalTrack.Repo.Abstracts;
using CalTrack.Repo.Concretes;
using CalTrack.Repo.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Service.Services
{
    public class FoodMealService : IFoodMealService
    {
        IFoodMealRepo _repo = new FoodMealRepo(new AppDbContext());
        
        public bool Add(FoodMeal foodmeal)
        {

            if (foodmeal is not null)
            {
                return _repo.Create(foodmeal);
            }
            else
            {
                throw new Exception("Food can't be null.");
            }
        }

        public bool Delete(int id)
        {
            return _repo.Delete(_repo.GetById(id));
        }

        public IQueryable<FoodMeal> GetAll()
        {
            return _repo.GetAll();
        }

        public FoodMeal GetFoodMealById(int id)
        {
            return _repo.GetById(id);
        }

        public bool Update(FoodMeal foodmeal)
        {
            return _repo.Update(foodmeal);
        }
    }
}
