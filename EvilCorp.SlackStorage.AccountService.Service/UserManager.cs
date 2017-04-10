using EvilCorp.AccountService.BusinessEntities;
using EvilCorp.AccountService.Contracts;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Service
{
    public class UserManager : IUserService
    {
        IUserReposetory userRepo;
        public UserManager() { }

        public UserManager(IUserReposetory userrepo)
        {
            userRepo = userrepo;
        }
        public string CreateUser(UserData userdata)
        {
            IUserReposetory userrepor = userRepo ?? new UserReposetory();
            var user = new User { Email = userdata.Email, Password = userdata.Password };
            return  userrepor.CreateUser(user);
        }
    }
}
