using OpenQA.Selenium;

namespace UltimateQA.Pages
{
    public class AppLifecycleSprint3Page : AppLifecycleSprint2Page
    {
        private readonly IWebDriver _driver;
        private IWebElement GenderMale => _driver.FindElement(By.XPath("//input[@value='male']"));
        private IWebElement GenderFemale => _driver.FindElement(By.XPath("//input[@value='female']"));
        private IWebElement GenderOther => _driver.FindElement(By.XPath("//input[@value='other']"));
        private IWebElement FirstName => _driver.FindElement(By.Name("firstname"));
        private IWebElement LastName => _driver.FindElement(By.Name("lastname"));
        private IWebElement SubmitButton => _driver.FindElement(By.XPath("//input[@type='submit']"));
        private IWebElement Sprint4Page => _driver.FindElement(By.XPath("//form//a[contains(text(),'sprint 4')]"));
        public AppLifecycleSprint3Page(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void SelectGender(string gender)
        {
            Thread.Sleep(2000); // Adding a delay to ensure the page is fully loaded before interacting with elements
            switch (gender)
            {
                case "male":
                    GenderMale.Click();
                    break;
                case "female":
                    GenderFemale.Click();
                    break;
                case "other":
                    GenderOther.Click();
                    break;
                default:
                    break;
            }
        }
        public override void EnterFirstName(String firstName)
        {
            FirstName.SendKeys(firstName);
        }

        public override void EnterLastName(String lastName)
        {
            LastName.SendKeys(lastName);
        }

        public override void SubmitDetails()
        {
            SubmitButton.Click();
        }

        public void NavigateToSprint4Page()
        {
            Sprint4Page.Click();
        }
    }
}