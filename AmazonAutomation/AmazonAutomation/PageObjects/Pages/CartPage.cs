using System;
using OpenQA.Selenium;


namespace AmazonAutomation.PageObjects
{
    public class CartPage : Page
    {
        public Lazy<Control> CartButton { get; } = new Lazy<Control>(() => new Control(By.Id("hlb-view-cart-announce")));

        public Lazy<CartProduct> CartProduct { get; } = new Lazy<CartProduct>();
    }
}
