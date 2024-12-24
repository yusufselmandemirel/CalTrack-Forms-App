using CalTrack.Repo.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalTrack.Core.Abstracts;
using CalTrack.Core.Enums;
using CalTrack.Repo.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalTrack.Repo.Concretes
{
    public class BaseRepo<T> : IBaseRepo<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private DbSet<T> _dbSet;
        public BaseRepo(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public bool Create(T entity)
        {
            try
            {
              
                
                    _dbSet.Add(entity);
                    return _context.SaveChanges() > 0 ? true : false;
                    
                
              
            }
            catch
            {
                throw new Exception("An error occurred while performing the operation!");
            }

        }
        
        public bool Delete(T entity)
        {

            try
            {
                if (entity is not null)
                {
                    entity.Status = Status.Deleted;
                    _dbSet.Update(entity);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                throw new Exception("An error occurred while performing the operation!");
            }
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable(); 
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public bool Update(T entity)
        {
            try
            {
                if (entity is not null)
                {
                    entity.Status = Status.Updated;
                    _context.Update(entity);
                    return _context.SaveChanges() > 0 ? true : false;
                }
                return false;
            }
            catch
            {
                throw new Exception("An error occurred while performing the operation!");
            }
        }
    }
}
