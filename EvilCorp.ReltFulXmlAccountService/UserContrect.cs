using EvilCorp.AccountService.ClientEntities;
using EvilCorp.SlackStorage.AccountService.Data.Reposetories_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.ReltFulXmlAccountService
{
    [ServiceContract (Namespace = "http://localhost:53879/")]
    public interface UserContrect 
    {
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.WrappedRequest, UriTemplate = "createuser"), Description("add new user with complex object Emial and Password hash")]
        string RegisterUser(string username, string password);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "login/{userid}/{password}")]
        string Login(string userid , string password);
    }
}
