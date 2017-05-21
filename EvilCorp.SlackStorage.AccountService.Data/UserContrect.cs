using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EvilCorp.ReltFulXmlAccountService
{
    [ServiceContract(Namespace = "")]
    public interface UserContrect 
    {
       // [OperationContract]
       //// [ServiceKnownType(typeof(Test))]
       // [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Xml,  RequestFormat  = WebMessageFormat.Xml,BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "testuser")]
       // Text TestUser(Test test);
       // [OperationContract]
       // [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Xml, RequestFormat =WebMessageFormat.Xml, UriTemplate = "registeruser")]
       // String RegisterUser(User user);
       // [OperationContract]
       // [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "login/{userid}/{password}")]
       // string Login(string userid , string password);
       // [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "disableuser/{username}")]
       // string DisableUser(string username);
       // [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "enableuser/{username}")]
       // string EnableUser(string username);
       // [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "deleteuser/{username}")]
       // string DeleteUser(string username);
       // [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "getalluser")]
       // IEnumerable<User> GetAllUsers();
       // [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "getuser/{userid}")]
       //  Task<User> GetUser(string userid);


    }
}
