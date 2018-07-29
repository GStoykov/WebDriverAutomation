using System;
using NUnit.Framework;
using AmazonAutomation.PageObjects;


namespace AmazonAutomation.Tests
{
    [TestFixture]
    public class AddingProductsToCart : Environment
    {
        private Page page;

        [SetUp]
        public void Preconditions()
        {
            page = new Page();

            string baseURL = Configuration.Get("BaseURL");
            page.Driver.Navigate().GoToUrl(baseURL);
        }

        [Test(Description = "Adding product to cart with unregistered user")]
        public void AddingProductToCart()
        {
            // Search for "Harry Potter"
            page.HeaderPanel.Value.SearchFor("Harry Potter");

            // Filter products
            SearchResultPage searchResultPage = new SearchResultPage();
            searchResultPage.ProductsFilter.ClickOnText("See All 36 Departments");
            searchResultPage.ProductsFilter.ClickOnText("Toys & Games");
            searchResultPage.ProductsFilter.SetPriceRange(10, 150);
            searchResultPage.ProductsFilter.ClickOnText("14 Years & Up");

            //Click on the first result
            searchResultPage.OpenProduct(1);

            //Add product to cart
            ProductDetailsPage productPage = new ProductDetailsPage();
            productPage.Quantity.Text = "4";
            productPage.AddToCartButton.Click();

            //Open cart
            CartPage cartPage = new CartPage();
            cartPage.CartButton.Value.Click();

            //Assert product's details
            Assert.AreEqual(productPage.Title, cartPage.CartProduct.Value.Title.Text);
            Assert.AreEqual(productPage.Price, cartPage.CartProduct.Value.Price.Text);
            Assert.AreEqual("4", cartPage.CartProduct.Value.CurrentQuantity);
        }
    }
}
