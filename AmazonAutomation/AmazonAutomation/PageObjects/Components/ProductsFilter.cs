using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.PageObjects
{
    public class ProductsFilter : Component
    {
        public ProductsFilter()
        {
            base.ContainerLocator = By.Id("leftNavContainer");
        }

        public void SetPriceRange(int minPrice, int maxPrice)
        {
            TextField minField = new TextField(By.Id("low-price"));
            TextField maxField = new TextField(By.Id("high-price"));

            Control buttonGo = new Control(By.XPath("//input[@class='a-button-input'][@value='Go']"));

            minField.Text = minPrice.ToString();
            maxField.Text = maxPrice.ToString();
            buttonGo.Click();
        }
    }
}
