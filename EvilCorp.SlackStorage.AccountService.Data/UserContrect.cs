using EvilCorp.AccountService.ClientEntities;
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
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.WrappedRequest, UriTemplate = "registeruser"), Description("add new user with complex object Emial and Password hash")]
        String RegisterUser(string username, string password, string nickname);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "login/{userid}/{password}")]
        string Login(string userid , string password);
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "disableuser/{username}")]
        string DisableUser(string username);
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "enableuser/{username}")]
        string EnableUser(string username);
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "deleteuser/{username}")]
        string DeleteUser(string username);
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "getalluser")]
        IEnumerable<User> GetAllUsers();


    }
}
