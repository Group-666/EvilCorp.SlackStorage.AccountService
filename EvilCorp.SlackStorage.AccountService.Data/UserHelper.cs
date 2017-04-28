using EvilCorp.AccountService.ClientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Data
{
    public static class UserHelper
    {
        public static DateTime CreateDeletedDate(this  User user)
        {
            var deleteddate = user.DeletedDate = DateTime.Now;
            return deleteddate;
        }
        public static bool DisableUser(this User user)
        {
            return user.IsActive = false;
        }
        public static bool EnableUser(this User user)
        {
            return user.IsActive = true;
        }
    }
}
