using EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EvilCorp.AccountService;

namespace EvilCorp.SlackStorage.AccountService.Data.Reposetories
{
    public class UserReposetory : IUserReposetory
    {
        AccountDBContext context = new AccountDBContext();
        private Logger _loger;
        public UserReposetory(Logger loger)
        {
            _loger = loger;
        }
        public async Task<Account> Create(Account account)
        {
          var acc = context.Accounts.Add(account);
            await context.SaveChangesAsync();
           // _loger.Log("success", LogLevel.Information);
            return acc;
        }

        public async Task Delete(Guid id)
        {
            var user = await context.Accounts.FindAsync(id);
            context.Accounts.Remove(user);
            Save();
           // _loger.Log("Deleted", LogLevel.Warning);
        }

        public async Task Delete(Account account)
        {
            context.Accounts.Remove(account);
            Save();
           // _loger.Log("Deleted", LogLevel.Warning);
        }

        public async Task<Account> Get(Guid id)
        {
            
            //_loger.Log("Get", LogLevel.Information);
            return await context.Accounts.FindAsync(id);
        }

        public async Task<IEnumerable<Account>> GetAll()
        {
           // _loger.Log("GetAll", LogLevel.Information);
            return context.Accounts.ToList();
        }

        public async Task Update(Account account)
        {
          //  _loger.Log("Update", LogLevel.Information);
            context.Entry(account).State = EntityState.Modified;
        }

        private async void Save()
        {
            int x = await context.SaveChangesAsync();
        }
    }
}
