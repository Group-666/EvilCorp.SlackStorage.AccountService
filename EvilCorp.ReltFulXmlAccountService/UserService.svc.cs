using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using EvilCorp.AccountService.ClientEntities;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories;

namespace EvilCorp.ReltFulXmlAccountService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : UserContrect
    {
        UserReposetory repo = new UserReposetory();

        public string DeleteUser(string username)
        {
            throw new NotImplementedException();
        }

        public string DisableUser(string username)
        {
            throw new NotImplementedException();
        }

        public string EnableUser(string username)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string userid)
        {
            throw new NotImplementedException();
        }

        public string Login(string userid, string password)
        {
            throw new NotImplementedException();
        }

        public string RegisterUser(User user)
        {
            throw new NotImplementedException();
        }

        //public string Login(string username, string password)
        //{
        //    return repo.Login(username, password);
        //}

        //public String RegisterUser(User user)
        //{
        //    return "posted";
        //    // return repo.RegisterUser(username, password, nickname);
        //}
        //public string DisableUser(string username)
        //{
        //    return repo.DisableUser(username);
        //}
        //public string EnableUser(string username)
        //{
        //    return repo.EnableUser(username);
        //}
        //public string DeleteUser(string username)
        //{
        //    return repo.DeleteUser(username);
        //}
        //public IEnumerable<User> GetAllUsers()
        //{
        //    return repo.GetAllUsers();
        //}

        //public Task<User> GetUser(string userid)
        //{
        //    if (userid != null)
        //        return repo.GetUser(userid);
        //    else
        //    throw new NotImplementedException();
        //}

        public Test TestUser(Test test)
        {
            return  new Test { Name = test.Name, age = test.age};
        }
    }
}
