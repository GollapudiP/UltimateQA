using OpenQA.Selenium;

namespace UltimateQA.Pages
{
    public class AppLifecycleSprint1Page : HomePage
    {
        private readonly IWebDriver _driver;

        private IWebElement FirstName => _driver.FindElement(By.Name("firstname"));
        private IWebElement SubmitButton => _driver.FindElement(By.Id("submitForm"));
        private IWebElement NextSprintPage => _driver.FindElement(By.XPath("//form//a[contains(text(),'next sprint')]"));
        public AppLifecycleSprint1Page(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public virtual void EnterFirstName(String firstName)
        {
            FirstName.SendKeys(firstName);
        }

        public virtual void SubmitDetails()
        {
            SubmitButton.Click();
        }

        public void NavigateToNextSprintPage()
        {
            NextSprintPage.Click();
        }
    }
}