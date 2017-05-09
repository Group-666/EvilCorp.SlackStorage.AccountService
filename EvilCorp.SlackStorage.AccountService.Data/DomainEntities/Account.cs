using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Data.DomainEntities
{
    public class Account
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Nickname { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public bool Activated { get; set; }
    }
}
