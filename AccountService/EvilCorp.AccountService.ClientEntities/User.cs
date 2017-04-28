using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.AccountService.ClientEntities
{
   public class User
    {
        public User()
        {
            CreatedDate = DateTime.Now;
        }
        public Guid UserId { get; set; }
        public string NickName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public int UserRole { get; set; }
    }
}
