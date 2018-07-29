using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;

namespace AmazonAutomation.PageObjects
{
    public class Control
    {
        private IWebDriver Driver { get; } = DriverInstance.Current();

        public By Locator { get; set; }

        public IWebElement Element { get; set; }

        public Control(By by)
        {
            ElementPresent(by);
            Element = Driver.FindElement(by);
            Locator = by;
        }

        public Control(By parentBy, By by)
        {
            ElementPresent(parentBy);
            IWebElement parentControl = Driver.FindElement(parentBy);

            ElementPresent(by);
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

        public bool Exists(int timeout, By _by)
        {
            try
            {
                if (_by == null)
                    _by = this.Locator;
                new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout)).Until(ExpectedConditions.ElementExists(_by));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Exists(By _by = null)
        {
            return Exists(Configuration.Timeout, _by);
        }


        public bool Visible(int timeout, By _by)
        {
            try
            {
                if (_by == null)
                    _by = this.Locator;
                new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout)).Until(ExpectedConditions.ElementIsVisible(_by));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Visible(By _by = null)
        {
            return Visible(Configuration.Timeout, _by);
        }

        public void ElementPresent(By _by = null)
        {
            Assert.IsTrue(this.Exists(_by), "Unable to find element: " + _by);
            Assert.IsTrue(this.Visible(_by), "Element not visible: " + _by);
        }

        public void Click(bool moveToElement = false)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(this.Element).Perform();
            this.Element.Click();
        }
    }
}
