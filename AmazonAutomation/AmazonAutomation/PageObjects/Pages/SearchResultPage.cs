using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.PageObjects
{
    public class SearchResultPage : Page
    {
        public ProductsFilter ProductsFilter { get; } = new ProductsFilter();

        public SearchResultPage() : base()
        {
        }

        public override Page Navigate()
        {
            return this;
        }

        public void OpenProduct(int productNumber)
        {
            new Control(By.Id($"result_{productNumber-1}"), By.XPath(".//a[contains(@class, 'access-detail-page')]")).Click();
        }
    }
}
