using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Configuration;

namespace EvilCorp.AccountService.ServiceProvider
{
    public class LoggerRepository// : ILogger
    {
        //private RestClient _restClient;
        //public LoggerRepository()
        //{
        //    _restClient = new RestClient(ConfigurationManager.AppSettings["loguri"]);
        //}
        //public async Task<string> Log(JObject logEntry)
        //{
        //    var request = new RestRequest("log", Method.POST);
        //    request.AddParameter("Application/Json", logEntry, ParameterType.RequestBody);
        //    var result = await _restClient.ExecuteTaskAsync(request);
        //    return result.StatusCode.ToString();
        //}
    }
}
