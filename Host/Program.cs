using Ninject;
using System;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host
{
    public class Program
    {
        private static void Main()
        {
            var baseAddress = "http://localhost:8009/AccountService";
            StandardKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());
            



            var hostAccountManager = new ServiceHost(typeof(AccountManager), new Uri(baseAddress));

            hostAccountManager.Open();

            Console.WriteLine("Services started. Press [Enter] to exit.");
            Console.ReadLine();

            hostAccountManager.Close();
        }
    }
}