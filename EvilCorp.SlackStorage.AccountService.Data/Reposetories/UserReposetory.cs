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
            AccountDBContext context = new AccountDBContext();
            var saved_user = context.Users.Add(user);
                             context.SaveChanges();
            if (saved_user.UserId != 0)
            {
                return saved_user.UserId.ToString();
            }
            else
            {
                return "User is not Saved";
            }
            
        }
    }
}
