using EvilCorp.AccountService.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Data
{
    public class AccountDBContext : DbContext
    {
        public AccountDBContext() : base("name = AccountDBContext")
        {
        }
        public DbSet<User> Users {get; set;}
    }
}
