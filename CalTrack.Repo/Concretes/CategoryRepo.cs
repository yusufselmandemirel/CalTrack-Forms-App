using CalTrack.Core.Concretes;
using CalTrack.Repo.Abstracts;
using CalTrack.Repo.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Repo.Concretes
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        private readonly AppDbContext _context;
        public CategoryRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
