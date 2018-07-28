using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.PageObjects
{
    public class Control
    {
        //private Page page;
        //private By locator;

        //public Page Page => page;

        private IWebDriver Driver { get; } = DriverInstance.Current();


        public By Locator { get; set; }

        public IWebElement Element { get; set; }

        public Control(By by)
        {
            Element = Driver.FindElement(by);
            Locator = by;
        }

        public Control(By parentBy, By by)
        {
            IWebElement parentControl = Driver.FindElement(parentBy);
            Element = parentControl.FindElement(by);
            Locator = by;
        }

        public string Text
        {
            get
            {
                Assert.IsTrue(this.Exists(), "Unable to find element: " + this.Locator);
                return this.Element.Text;
            }
        }

        public bool Exists(int timeout)
        {
            try
            {
                new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout)).Until(ExpectedConditions.ElementExists(this.Locator));
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }

        public bool Exists()
        {
            return Exists(Configuration.Timeout);
        }


        public bool Visible(int timeout)
        {
            try
            {
                new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout)).Until(ExpectedConditions.ElementIsVisible(this.Locator));
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }

        public bool Visible()
        {
            return Visible(Configuration.Timeout);
        }

        public void Click()
        {
            Assert.IsTrue(this.Exists(), "Unable to find element: " + this.Locator);
            Assert.IsTrue(this.Visible(), "Element not visible: " + this.Locator);
            this.Element.Click();
        }

    }
}
