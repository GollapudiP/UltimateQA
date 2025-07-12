using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Microsoft.Extensions.Configuration;

namespace UltimateQA.Utilities
{
    public static class DriverFactory
    {
        private static IConfiguration config = ConfigManager.LoadConfig();
        public static IWebDriver CreateDriver()
        {
            String? browser = config["Browser"];
            Console.WriteLine($"Executing tests on: {browser}");
            dynamic options;
            switch (browser)
            {
                case "Chrome":
                    options = new ChromeOptions();
                    options.AddArgument("start-maximized");
                    return new ChromeDriver(options);
                case "Firefox":
                    options = new FirefoxOptions();
                    options.AddArgument("start-maximized");
                    return new FirefoxDriver(options);
                // case "Edge":
                //     return CreateEdgeDriver();
                default:
                    throw new NotSupportedException("Browser not supported");
            }
        }
        /* public static IWebDriver CreateDriver()
        {
            //new DriverManager().SetUpDriver(new ChromeConfig());
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return new ChromeDriver(options);
        } */
    }
}