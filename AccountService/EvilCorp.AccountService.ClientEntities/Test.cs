using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.AccountService.ClientEntities
{
    [DataContract(Namespace = "")]
    public class Test
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string age { get; set; }
    }
}
