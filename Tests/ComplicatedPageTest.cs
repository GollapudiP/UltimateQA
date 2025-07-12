using UltimateQA.Pages;
using TestCaseStatus = AventStack.ExtentReports.Status;

namespace UltimateQA.Tests
{
    public class ComplicatedPageTest : BaseTest
    {
        //private IWebDriver _driver;
        //private UltimateQAHomePage _ultimateQAHomePage;

        /*     [SetUp]
            public void SetUp()
            {
                _driver = DriverFactory.CreateDriver();
                _ultimateQAHomePage = new UltimateQAHomePage(_driver);
            } */

        [Test, Order(1)]
        public void VerifyComplicatedPageTitle()
        {
            var report = Report.CreateTest("VerifyComplicatedPageTitle");

            var page = new HomePage(Driver);
            page.GoToUltimateQA();
            page.NavigateToComplicatedPage();
            AssertPageTitle("Complicated Page");
            AssertPageUrl("ultimateqa.com/complicated-page");

            report.Log(TestCaseStatus.Pass, "Complicated Page title and URL verified successfully.");
        }

        /*     [TearDown]
            public void TearDown()
            {
                if (_driver != null)
                {
                    _driver.Quit();
                    _driver.Dispose();
                }

            } */
    }
}