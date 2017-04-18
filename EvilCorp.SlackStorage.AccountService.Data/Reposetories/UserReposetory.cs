using EvilCorp.AccountService.BusinessEntities;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Data.Reposetories
{
    public class UserReposetory : IUserReposetory
    {
        public string CreateUser(User user)
        {
            return "User is Created 200";
        }
    }
}
