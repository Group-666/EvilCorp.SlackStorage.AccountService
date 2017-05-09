
using EvilCorp.AccountService.ClientEntities;
using EvilCorp.AccountService.ServiceProvider;
using EvilCorp.ReltFulXmlAccountService;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvilCorp.SlackStorage.AccountService.Data.DomainEntities;
using System.Data.Entity;

namespace EvilCorp.SlackStorage.AccountService.Data.Reposetories
{
    public class UserReposetory : IUserReposetory
    {
        AccountDBContext context = new AccountDBContext();
        Logger _loger = new Logger();

        public async Task<Account> Create(Account account)
        {
          var acc = context.Accounts.Add(account);
            await context.SaveChangesAsync();
            return acc;
        }

        public async Task Delete(Guid id)
        {
            var user = await context.Accounts.FindAsync(id);
            context.Accounts.Remove(user);
            Save();
        }

        public async Task<Account> Get(Guid id)
        {
            return await context.Accounts.FindAsync(id);

        }

        public async Task<IEnumerable<Account>> GetAll()
        {
            return context.Accounts.ToList();
        }

        public async Task Update(Account account)
        {
            context.Entry(account).State = EntityState.Modified;
        }

        private async void Save()
        {
            int x  = await context.SaveChangesAsync();
        }
    }
}
