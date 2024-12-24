using CalTrack.Core.Concretes;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Service.Services
{
    public interface ICategoryService
    {
        bool Delete(int id);
        
        bool Update(int id,string name);

        bool Add(string name);


        IQueryable<Category> GetAll();
    }
}
