using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.IO;
using System.Reflection;
using System.Configuration;

namespace AmazonAutomation
{
    [TestFixture]
    public class Environment
    {
        [SetUp]
        public void SetUp()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            Driver.Add(Configuration.Get("Browser"), path, capabilities);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
