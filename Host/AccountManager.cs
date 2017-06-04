using EvilCorp.AccountService;
using EvilCorp.SlackStorage.AccountService.Data;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Host
{
    public class AccountManager : IAccountService
    {
        private IUserReposetory _userrepo;
        
        public AccountManager(IUserReposetory userreposetory)
        {
            _userrepo = userreposetory;
        }
        public AccountManager()
        {
            _userrepo = new UserReposetory(new Logger());
        }
        public async Task<IEnumerable<Account>> GetAll()
        {
           return await _userrepo.GetAll();
        }

        public async Task<Account> Create(Account account)
        {
          return   await _userrepo.Create(account);
        }

        public async Task Delete(Guid id)
        {
           await _userrepo.Delete(id);
        }

        public async Task Delete(Account account)
        {
            await _userrepo.Delete(account);
        }

        public async Task<Account> Get(Guid id)
        {
            try
            {
                return await _userrepo.Get(id);
            }
            catch (Exception ex)
            {

                throw new FaultException(ex.Message);
            }
           
        }

        public async Task Update(Account account)
        {
          await  _userrepo.Update(account);
        }
    }
}