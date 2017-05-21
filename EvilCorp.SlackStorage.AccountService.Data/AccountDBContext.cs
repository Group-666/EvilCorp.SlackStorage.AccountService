using EvilCorp.AccountService;
using System.Data.Entity;

namespace EvilCorp.SlackStorage.AccountService.Data
{
    public class AccountDBContext : DbContext
    {
        public AccountDBContext() : base("AccountDBContext")
        {
        }
        public DbSet<Account> Accounts { get; set; }
    }
}
