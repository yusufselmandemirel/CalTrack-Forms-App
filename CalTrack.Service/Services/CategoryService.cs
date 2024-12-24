using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
using CalTrack.Repo.Abstracts;
using CalTrack.Repo.Concretes;
using CalTrack.Repo.Contexts;

namespace CalTrack.Service.Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepo _repo = new CategoryRepo(new AppDbContext());
        public bool Add(string name)
        {
            if (name is not null)
            {
                return _repo.Create(new Category() { Name = name });
            }
            else
            {
                throw new Exception("Category name can't be empty.");
            }
        }

        public bool Delete(int id)
        {
            return _repo.Delete(_repo.GetById(id));
        }

        public IQueryable<Category> GetAll()
        {
            return _repo.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _repo.GetById(id);
        }

        public bool Update(int id, string name)
        {
            var cat = _repo.GetById(id);
            cat.Name = name;
            return _repo.Update(cat);
        }

       
    }
}
