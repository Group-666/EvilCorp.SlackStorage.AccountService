using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories;
using EvilCorp.AccountService.ServiceProvider;
using EvilCorp.SlackStorage.AccountService.Data;

namespace Host.Ninject
{
    public class NinjectBinds : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserReposetory>().To<UserReposetory>();
            Bind<ILogger>().To<LoggerRepository>();
            Bind<Logger>().To<Logger>();
        }
    }
}
