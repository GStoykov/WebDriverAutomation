using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.PageObjects
{
    public class CartPage : Page
    {
        public Lazy<Control> CartButton { get; } = new Lazy<Control>(() => new Control(By.Id("hlb-view-cart-announce")));

        public Lazy<CartProduct> CartProduct { get; } = new Lazy<CartProduct>();
    }
}
