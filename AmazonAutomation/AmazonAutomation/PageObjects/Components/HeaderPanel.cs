using System;
using OpenQA.Selenium;


namespace AmazonAutomation.PageObjects
{
    public class HeaderPanel : Component
    { 
        public TextField SearchField { get; } = new TextField(By.Id("twotabsearchtextbox"));
        public Control SearchButton { get; } = new Control(By.XPath(@"//*[@id='nav-search']/form/div[2]"));

        public void SearchFor(string text)
        {
            SearchField.Text = text;
            SearchButton.Click();
        }
    }
}
