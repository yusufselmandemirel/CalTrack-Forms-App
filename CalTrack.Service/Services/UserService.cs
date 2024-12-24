using CalTrack.Core.Concretes;
using CalTrack.Core.Enums;
using CalTrack.Repo.Abstracts;
using CalTrack.Repo.Concretes;
using CalTrack.Repo.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Service.Services
{
    public class UserService : IUserService
    {
        IUserRepo _repo = new UserRepo(new AppDbContext());
        public bool Add(User user)
        {

            return _repo.Create(user);
        }



        public bool Delete(int id)
        {
            return _repo.Delete(_repo.GetById(id));
        }

        public IQueryable<User> GetAll()
        {
            return _repo.GetAll();
        }

        public User GetUserById(int id)
        {
            return _repo.GetById(id);
        }

        public List<User> GetUserByStatus(bool status)
        {
            Status result;
            if (status)
            {
                result = Status.Created;
                return _repo.GetAll().Where(x => x.Status != Status.Deleted).ToList();
            }
            else
            {
                result = Status.Deleted;
                return _repo.GetAll().Where(x => x.Status == Status.Deleted).ToList();
            }
        }

        public bool Update(User user)
        {       
            return _repo.Update(user);

        }
    }
}
