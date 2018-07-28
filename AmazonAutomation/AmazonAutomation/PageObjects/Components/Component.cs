using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.PageObjects
{
    public class Component
    {
        public By ContainerLocator { get; set; }

        public void ClickOnText(string text)
        {
            new Control(ContainerLocator, By.XPath($".//*[contains(text(),'{text}')]")).Click();
        }
    }
}
