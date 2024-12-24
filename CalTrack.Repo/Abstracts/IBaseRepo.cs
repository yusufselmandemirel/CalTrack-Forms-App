using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalTrack.Core.Abstracts;

namespace CalTrack.Repo.Abstracts
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
