using EvilCorp.AccountService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Host
{
    public class AccountManager : IAccountService
    {
        public async Task<IEnumerable<Account>> GetAll()
        {
            return new List<Account>
            {
                new Account
                {
                    Id = Guid.NewGuid(),
                    Username = "Martin2",
                    Password = "SIKKERSEX",
                    Nickname = "Martin3"
                }
            };
        }

        public async Task<Account> Create(Account account)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Account account)
        {
            throw new NotImplementedException();
        }

        public async Task<Account> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Account account)
        {
            throw new NotImplementedException();
        }
    }
}