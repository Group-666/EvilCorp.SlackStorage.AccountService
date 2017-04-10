using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces;
using EvilCorp.AccountService.BusinessEntities;
using EvilCorp.SlackStorage.AccountService.Service;
using EvilCorp.AccountService.Contracts;

namespace EvilCorp.SlackStroage.AccountService.Utest
{
    [TestClass]
    public class UserUnitTests
    {
        [TestMethod]
        public void CreateUserTest()
        {
            Mock<IUserReposetory> moqrepo = new Mock<IUserReposetory>();
            var token = "ourtoken";
            var demouser = new User { Email = "hello@hello.com", Password = "passwordhash" };
            var demouserdata = new UserData {Email = "userdata@email.com" , Password = "pass1122" };
            moqrepo.Setup(obj => obj.CreateUser(demouser)).Returns(token);
            IUserService userRepo = new UserManager(moqrepo.Object);
            string tokens = userRepo.CreateUser(demouserdata);
            Assert.IsFalse(tokens == "ourtoken");
        }
    }
}
