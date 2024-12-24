using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Service.Services
{
    public interface IUserService
    {
        bool Delete(int id);

        bool Update(User user);

        public bool Add(User user);

       User GetUserById(int id);

        List<User> GetUserByStatus(bool status);

        IQueryable<User> GetAll();
    }
}
