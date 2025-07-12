using UltimateQA.Pages;
using UltimateQA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UltimateQA.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected ReportManager Report = ReportManager.Instance;

        [SetUp]
        public void SetUp()
        {
            Driver = DriverFactory.CreateDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public void AssertPageTitle(String expectedTitle)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Contains(expectedTitle));
            Console.WriteLine(Driver.Title);
            Assert.IsTrue(Driver.Title.Contains(expectedTitle));
        }

        public void AssertPageUrl(String expectedUrl)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Contains(expectedUrl));
            Console.WriteLine(Driver.Url);
            Assert.IsTrue(Driver.Url.Contains(expectedUrl));
        }

        [TearDown]
        public void TearDown()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }

        }

        [OneTimeTearDown]
        public void TearDownReport() => Report.FlushReport();
    }
}