using OpenQA.Selenium;


namespace AmazonAutomation.PageObjects
{
    public class SearchResultPage : Page
    {
        public ProductsFilter ProductsFilter { get; } = new ProductsFilter();


        public void OpenProduct(int productNumber)
        {
            new Control(By.Id($"result_{productNumber-1}"), By.XPath(".//a[contains(@class, 'access-detail-page')]")).Click();
        }
    }
}
