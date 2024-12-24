using CalTrack.Core.Concretes;
using CalTrack.Repo.Abstracts;
using CalTrack.Repo.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Repo.Concretes
{
    public class MealRepo : BaseRepo<Meal>, IMealRepo
    {
        private readonly AppDbContext _context;
        public MealRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }



    }
}

