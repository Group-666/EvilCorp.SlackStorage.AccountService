using EvilCorp.AccountService.ClientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces
{
    public interface IUserReposetory
    {
         string CreateUser(User user);
    }
}
