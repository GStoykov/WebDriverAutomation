using System;
using OpenQA.Selenium;


namespace AmazonAutomation.PageObjects
{
    public class ProductsFilter : Component
    {
        public override By ContainerLocator { get => By.Id("leftNavContainer"); }

        public ProductsFilter()
        {
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
