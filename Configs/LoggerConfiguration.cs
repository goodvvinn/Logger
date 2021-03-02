using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Logger
{
    public class LoggerConfiguration
    {
        public LoggerConfig ReadConfig()
        {
            var configFile = File.ReadAllText("loggerConfigFile.json");
            var config = JsonConvert.DeserializeObject<LoggerConfig>(configFile);

            return config;
        }
    }
}
