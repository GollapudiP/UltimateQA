using OpenQA.Selenium;

namespace UltimateQA.Pages
{
    public class HomePage : BasePage
    {
        private readonly IWebDriver _driver;

        private IWebElement ComplicatedPage => _driver.FindElement(By.XPath("//ul/li[1]/a[contains(text(),'Big page')]"));
        private IWebElement FakeLandinPage => _driver.FindElement(By.XPath("//ul/li[2]/a[contains(text(),'Fake Landing Page')]"));
        private IWebElement FakePricingPage => _driver.FindElement(By.XPath("//ul/li[3]/a[contains(text(),'Fake Pricing Page')]"));
        private IWebElement FillOutFormsPage => _driver.FindElement(By.XPath("//ul/li[4]/a[contains(text(),'Fill out forms')]"));
        private IWebElement AppLifecycleSprint1Page => _driver.FindElement(By.XPath("//ul/li[5]/a[contains(text(),'evolves over time')]"));
        private IWebElement LoginAutomationPage => _driver.FindElement(By.XPath("//ul/li[6]/a[contains(text(),'Login automation')]"));

        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        // Actions
        /*         public override void GoTo()
                {
                    _driver.Navigate().GoToUrl("https://ultimateqa.com/automation");
                    _driver.Manage().Window.Maximize();
                    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                } */

        public void NavigateToComplicatedPage()
        {
            ComplicatedPage.Click();
        }

        public void NavigateToFakeLandinPage()
        {
            FakeLandinPage.Click();
        }

        public void NavigateToFakePricingPage()
        {
            FakePricingPage.Click();
        }

        public void NavigateToFillOutFormsPage()
        {
            FillOutFormsPage.Click();
        }

        public void NavigateToAppLifecycleSprint1()
        {
            AppLifecycleSprint1Page.Click();
        }
    }
}