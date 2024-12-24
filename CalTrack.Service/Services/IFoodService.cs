using CalTrack.Core.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Service.Services
{
    public interface IFoodService
    {
        bool Delete(int id);

        bool Add(Food food);

        bool Update(Food food);
        Food GetFoodById(int id);

        IQueryable<Food> GetAll();
    }
}
