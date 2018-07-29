using System;
using OpenQA.Selenium;


namespace AmazonAutomation.PageObjects
{
    public class Component
    {
        public virtual By ContainerLocator { get; }

        public void ClickOnText(string text)
        {
            new Control(ContainerLocator, By.XPath($".//*[contains(text(),'{text}')]")).Click(true);
        }
    }
}
