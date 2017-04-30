
using EvilCorp.AccountService.ClientEntities;
using EvilCorp.AccountService.ServiceProvider;
using EvilCorp.ReltFulXmlAccountService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Data.Reposetories
{
    public class UserReposetory : UserContrect
    {
        AccountDBContext context = new AccountDBContext();
        Logger _loger = new Logger();
        public string DeleteUser(string username)
        {
            var user = context.Users.Where(x => x.UserName == username).FirstOrDefault();
            if (user != null)
            {
                user.CreateDeletedDate();
                user.IsDeleted = true;
                context.SaveChanges();
                _loger.Log("Deleted user with id" + user.UserId.ToString(), LogLevel.Information);
                return user.UserId.ToString();
            }
            else
            {
                return "This is some Problem with deleteing User";
            }
        }

        public string DisableUser(string username)
        {
            var user = context.Users.Where(x => x.UserName == username).FirstOrDefault();
            if (user != null)
            {
                user.DisableUser();
                context.SaveChanges();
                _loger.Log("Disabled user with id" + user.UserId.ToString(), LogLevel.Warning);
                return user.UserId.ToString();
            }
            else
            {
                return "This is some Problem with Disableing User";
            }
        }

        public string EnableUser(string username)
        {
            var user = context.Users.Where(x => x.UserName == username).FirstOrDefault();
            if (user != null)
            {
                user.EnableUser();
                context.SaveChanges();
                _loger.Log("Enabled user with id" + user.UserId.ToString(), LogLevel.Warning);
                return user.UserId.ToString();
            }
            else
            {
                return "This is some Problem with Enableing User";
            }
        }

        public IEnumerable<EvilCorp.AccountService.ClientEntities.User> GetAllUsers()
        {
            return context.Users;
        }

        public async Task<User>  GetUser(string userid)
        {
            if (userid != null)
                return  await context.Users.FindAsync(userid);
            else
                throw new Exception("User not Found");
        }

        public string Login(string userid, string password)
        {
            var user = context.Users.Where(x => x.UserId.ToString() == userid).FirstOrDefault();
            if (user != null)
            {
                _loger.Log("LogedIn user with id" + user.UserId.ToString(), LogLevel.Information);
                return  (user.UserId.ToString() == userid && user.Password == password) ? user.UserId.ToString() : "user not found";
            }
            return "User or password is not in database";
        }

        public string RegisterUser(string username, string password, string nickname)
        {
            var user = new User() {NickName = nickname, UserName = username, Password = password };

            var saveduser = context.Users.Add(user);
            context.SaveChanges();
            if (saveduser.UserId != null)
            {
                _loger.Log("Registerd user with id" + user.UserId.ToString(), LogLevel.Information);
                return saveduser.UserId.ToString();
            }
            else { return " User is Not Created"; }
        }
    }
}
