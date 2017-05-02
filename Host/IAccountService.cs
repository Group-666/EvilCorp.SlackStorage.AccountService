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
    }
}