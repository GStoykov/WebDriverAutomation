using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using AmazonAutomation.PageObjects;

namespace AmazonAutomation.Tests
{
    [TestClass]
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
            searchResultPage.ProductsFilter.ClickOnText("See All 37 Departments");
            searchResultPage.ProductsFilter.ClickOnText("Toys & Games");
            searchResultPage.ProductsFilter.SetPriceRange(10, 150);
            //Checkbox "14 years & Up" was missing at the time of automating this test
            searchResultPage.ProductsFilter.ClickOnText("12-15 years");

            //Click on the first result
            searchResultPage.OpenProduct(1);

            //Select quantity 4
            //Click on "Add to Cart"
            //Open the cart
            //Assert the purchase details
        }
    }
}
