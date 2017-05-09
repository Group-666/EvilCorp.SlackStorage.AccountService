using EvilCorp.AccountService.ClientEntities;
using EvilCorp.SlackStorage.AccountService.Data.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces
{
    public interface IUserReposetory
    {
        Task<IEnumerable<Account>> GetAll();
        Task<Account> Create(Account account);
        Task Delete(Guid id);
        Task<Account> Get(Guid id);

        Task Update(Account account);
    }
}
