using Ninject.Modules;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories;
using EvilCorp.SlackStorage.AccountService.Data;

namespace Host.Ninject
{
    public class NinjectBinds : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserReposetory>().To<UserReposetory>();
            Bind<Logger>().To<Logger>();
        }
    }
}
