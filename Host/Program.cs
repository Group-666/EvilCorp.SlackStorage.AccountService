using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host
{
    public class Program
    {
        private static void Main()
        {
            var baseAddress = "http://localhost:8009/AccountService";
            var hostAccountManager = new ServiceHost(typeof(AccountManager), new Uri(baseAddress));

            hostAccountManager.Open();

            Console.WriteLine("Services started. Press [Enter] to exit.");
            Console.ReadLine();

            hostAccountManager.Close();
        }
    }
}