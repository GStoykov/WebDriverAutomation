using System;
using OpenQA.Selenium;


namespace AmazonAutomation.PageObjects
{
    public class ProductDetailsPage : Page
    {
        public string Title { get; } = new Control(By.Id("productTitle")).Text;
        public string Price { get; } = new Control(By.Id("priceblock_ourprice")).Text;
        public SelectList Quantity { get; } = new SelectList(By.Id("quantity"));
        public Control AddToCartButton { get; } = new Control(By.Id("add-to-cart-button"));
    }
}
