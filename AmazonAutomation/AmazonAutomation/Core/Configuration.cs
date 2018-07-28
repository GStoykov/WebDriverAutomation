using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation
{
    public class Configuration
    {
        private Configuration()
        {
        }

        public static string Get(string value)
        {
            return System.Configuration.ConfigurationManager.AppSettings[value];
        }

        public static int Timeout
        {
            get { return int.Parse(Get("Timeout")); }
        }
    }
}
