using System;


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
