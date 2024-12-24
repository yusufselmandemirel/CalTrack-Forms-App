using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalTrack.Core.Concretes;
using CalTrack.Repo.Concretes;

namespace CalTrack.Service.Services
{
    public interface IMealService
    {
        bool Delete(int id);



        bool Add(string name);

        Meal GetMealById(int id);

        List<Meal> GetMealByName(string name);



        IQueryable<Meal> GetAll();




    }
}
