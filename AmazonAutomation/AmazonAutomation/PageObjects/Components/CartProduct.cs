using System;
using OpenQA.Selenium;


namespace AmazonAutomation.PageObjects
{
    public class CartProduct : Component
    {
        public override By ContainerLocator { get => By.XPath("//div[contains(@class, 'sc-list-item')]"); }

        public Control Title { get { return new Control(ContainerLocator, By.XPath(".//span[contains(@class, 'sc-product-title')]")); } }
        public Control Price { get { return new Control(ContainerLocator, By.XPath(".//span[contains(@class, 'sc-price')]")); } }
        public SelectList Quantity { get { return new SelectList(ContainerLocator, By.XPath(".//select[@name='quantity']")); } }
        public string CurrentQuantity { get { return new SelectList(ContainerLocator, By.XPath("//span[@data-a-class='quantity']//span[@class='a-dropdown-prompt']")).Text; } }
    }
}
