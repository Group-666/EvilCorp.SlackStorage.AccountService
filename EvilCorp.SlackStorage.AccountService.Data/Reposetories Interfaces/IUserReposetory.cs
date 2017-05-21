using EvilCorp.AccountService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces
{
    public interface IUserReposetory
    {
        Task<IEnumerable<Account>> GetAll();
        Task<Account> Create(Account account);
        Task Delete(Guid id);
        Task<Account> Get(Guid id);
        Task Delete(Account account);
        Task Update(Account account);
    }
}
