using EvilCorp.SlackStorage.AccountService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost servicehost = new ServiceHost(typeof(UserManager));
            servicehost.Open();
            Console.WriteLine("Service is Running");
            Console.ReadLine();

            servicehost.Close();
        }
    }
}
