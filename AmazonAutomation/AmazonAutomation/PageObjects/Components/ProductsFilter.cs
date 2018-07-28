using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.PageObjects
{
    public class ProductsFilter
    {
        private By containerLocator = By.Id("leftNavContainer");

        public ProductsFilter()
        {
        }

        public void ClickOnText(string text)
        {
            new Control(containerLocator, By.XPath($".//*[contains(text(),'{text}')]")).Click();
        }

        public void SetPriceRange(int minPrice, int maxPrice)
        {

            TextField minField = new TextField(containerLocator, By.XPath(".//*[@id='low-price']"));
            TextField maxField = new TextField(containerLocator, By.XPath(".//*[@id='high-price']"));
            Control buttonGo = new Control(By.XPath("//input[@class='a-button-input'][@value='Go']"));

            minField.Text = minPrice.ToString();
            maxField.Text = maxPrice.ToString();
            buttonGo.Click();
        }
    }
}
