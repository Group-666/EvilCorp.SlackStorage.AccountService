using System;
using System.Collections.Generic;
using System.ServiceModel.Activation;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace EvilCorp.AccountService.WebHosting
{
    public class CustomHostFectory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            ServiceHost host = new ServiceHost(serviceType, baseAddresses);
            return host;
        }
    }
}