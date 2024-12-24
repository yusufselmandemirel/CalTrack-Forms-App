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
    public class MealService : IMealService
    {
        IMealRepo _repo = new MealRepo(new AppDbContext());
        public bool Add(string name)
        {
            if (name is not null)
            {
                return _repo.Create(new Meal() { Name = name });
            }
            else
            {
                throw new Exception("Meal name can't be empty.");
            }
        }

        public bool Delete(int id)
        {
            return _repo.Delete(_repo.GetById(id)); ;
        }

        public IQueryable<Meal> GetAll()
        {
            return _repo.GetAll();
        }

     

        public Meal GetMealById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Meal> GetMealByName(string name)
        {
            return _repo.GetAll().Where(x => x.Name == name).ToList();
        }
    }
}
