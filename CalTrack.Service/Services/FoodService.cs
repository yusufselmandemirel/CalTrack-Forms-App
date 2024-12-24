using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
using CalTrack.Repo.Abstracts;
using CalTrack.Repo.Concretes;
using CalTrack.Repo.Contexts;

namespace CalTrack.Service.Services
{
    public class FoodService : IFoodService
    {
        IFoodRepo _repo = new FoodRepo(new AppDbContext());
        public bool Add(Food food)
        {
            

            if (food is not null)
            {
                return _repo.Create(food);
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

        public IQueryable<Food> GetAll()
        {
            return _repo.GetAll();
        }

        public Food GetFoodById(int id)
        {
            return _repo.GetById(id);
        }

        public bool Update(Food food)
        {
            return _repo.Update(food);
        }
    }
}
