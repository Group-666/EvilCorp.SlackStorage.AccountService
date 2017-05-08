using EvilCorp.AccountService.ClientEntities;
using EvilCorp.AccountService.ServiceProvider;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilCorp.SlackStorage.AccountService.Data
{
    public class Logger
    {
        LoggerRepository logrepo = new LoggerRepository();
        private readonly string componentName = "AccoutService";
        public void Log(string message, LogLevel logLevel)
        {
            if (string.IsNullOrEmpty(message))
                throw new ArgumentException("The message cannot be null or empty.", nameof(message));

            var logEntry = CreateContent(message, logLevel);
               // logrepo.Log(logEntry);
        }


        private JObject CreateContent(string message, LogLevel level)
        {
            var json = new JObject
            {
                ["componet"] = componentName,
                ["message"] = message,
                ["level"] = (int)level
            };
            return json;
        }
    }
}
