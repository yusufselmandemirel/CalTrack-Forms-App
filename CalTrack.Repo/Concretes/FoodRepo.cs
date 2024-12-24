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
    public class FoodRepo : BaseRepo<Food>, IFoodRepo
    {
        private readonly AppDbContext _context;
        public FoodRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
