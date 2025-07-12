using OpenQA.Selenium;

namespace UltimateQA.Pages
{
    public class AppLifecycleSprint2Page : AppLifecycleSprint1Page
    {
        private readonly IWebDriver _driver;

        private IWebElement FirstName => _driver.FindElement(By.Name("firstname"));
        private IWebElement LastName => _driver.FindElement(By.Name("lastname"));
        private IWebElement SubmitButton => _driver.FindElement(By.XPath("//input[@type='submit']"));
        private IWebElement Sprint3Page => _driver.FindElement(By.XPath("//form//a[contains(text(),'sprint 3')]"));
        public AppLifecycleSprint2Page(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public override void EnterFirstName(String firstName)
        {
            Thread.Sleep(2000); // Adding a delay to ensure the page is fully loaded before interacting with elements
            FirstName.SendKeys(firstName);
        }

        public virtual void EnterLastName(String lastName)
        {
            LastName.SendKeys(lastName);
        }

        public override void SubmitDetails()
        {
            SubmitButton.Click();
        }

        public void NavigateToSprint3Page()
        {
            Sprint3Page.Click();
        }
    }
}