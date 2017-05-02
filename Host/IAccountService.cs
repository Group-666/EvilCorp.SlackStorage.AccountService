using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace EvilCorp.AccountService
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        Task<IEnumerable<Account>> GetAll();

        /// <summary>
        ///
        /// </summary>
        /// <param name="account">An account with an empty ID.</param>
        /// <returns>The newly created account with an ID.</returns>
        [OperationContract]
        Task<Account> Create(Account account);

        [OperationContract]
        Task Delete(Account account);

        [OperationContract]
        Task<Account> Get(Guid id);

        /// <summary>
        /// The update operation updates the accounts properties with the given ID.
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        [OperationContract]
        Task Update(Account account);
    }
}