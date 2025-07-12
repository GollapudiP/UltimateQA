using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

namespace UltimateQA.Pages
{
    public abstract class BasePage
    {
        private readonly IWebDriver _driver;
        private static IConfiguration config = ConfigManager.LoadConfig();
        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public virtual void GoToUltimateQA()
        {
            String? appUrl = config["BaseUrl"];
            if (string.IsNullOrEmpty(appUrl))
            {
                throw new ArgumentException("BaseUrl is not configured in appsettings.json");
            }
            else
            {
                Console.WriteLine($"Navigating to: {appUrl}");
            }
            _driver.Navigate().GoToUrl(appUrl);
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}