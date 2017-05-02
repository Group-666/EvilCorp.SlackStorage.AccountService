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
            await Task.Delay(0);
            return new List<Account>
            {
                new Account
                {
                    Id = Guid.NewGuid(),
                    Username = "Martin2",
                    Password = "SIKKERSEX"
                }
            };
        }
    }
}