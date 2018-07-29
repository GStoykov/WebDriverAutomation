using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;


namespace AmazonAutomation
{
    public class DriverInstance
    {
        private static IWebDriver driver;
        private static Dictionary<string, Type> driverMap = new Dictionary<string, Type>()
        {
            {"Chrome", typeof(ChromeDriver)}
        };

        private static Dictionary<string, Type> driverOptions = new Dictionary<string, Type>()
        {
            {"Chrome", typeof(ChromeOptions)}
        };

        private DriverInstance()
        {
        }

        public static void Add(string browser, string path, ICapabilities capabilities)
        {
            Type driverType = driverMap[browser];
            DriverOptions options = (DriverOptions)driverOptions[browser].GetConstructor(new Type[] { }).Invoke(new object[] { });
            driver = (IWebDriver)driverType.GetConstructor(new Type[] { typeof(string), driverOptions[browser] }).Invoke(new object[] { path, options });
            driver.Manage().Window.Maximize();
        }

        public static IWebDriver Current()
        {
            return driver;
        }

        public static void Quit()
        {
            driver.Quit();
        }
    }
}
