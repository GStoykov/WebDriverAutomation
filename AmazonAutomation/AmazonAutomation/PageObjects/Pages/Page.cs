using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.PageObjects
{
    public class Page
    {
        public IWebDriver Driver
        {
            get
            {
                return DriverInstance.Current();
            }
        }

        public Lazy<HeaderPanel> HeaderPanel { get; } = new Lazy<HeaderPanel>();

        public Page()
        {
        }

        public virtual Page Navigate()
        {
            return this;
        }

        public bool IsTextPresent(String text)
        {
            string locatorText = String.Format("//*[text()='{0}' or contains(text(), '{1}')]", text, text);
            Control element = new Control(By.XPath(locatorText));
            return element.Exists() && element.Visible();
        }
    }
}
