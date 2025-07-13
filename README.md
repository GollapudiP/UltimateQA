# Selenium WebDriver Automation with C#, NUnit, JSON Test Data, POM & ExtentReports

This repository contains a structured automation framework using:

- Selenium WebDriver  
- NUnit  
- Page Object Model (POM)  
- JSON-based Test Data  
- ExtentReports for HTML Reporting  
- GitHub Actions for Continuous Integration

---

## Project Structure

UltimateQA/
│
├─-- Utilities/ # WebDriver setup logic, JSON reader, Report logger, Configuration manager
├──- Pages/ # Page Object classes
├──- Tests/ # NUnit test classes
├──- TestData/ # JSON files containing test data
├──- appsettings.json # Config file (browser, URLs, etc.)
├──- .github/workflows/ # GitHub Actions CI pipeline
├──- UltimateQA.csproj
└──- README.md

---

## Technologies Used

- [Selenium WebDriver](https://www.selenium.dev/)
- [NUnit](https://nunit.org/)
- [.NET 8 or later](https://dotnet.microsoft.com/)
- [ExtentReports](https://extentreports.com/)
- [ChromeDriver](https://sites.google.com/a/chromium.org/chromedriver/)
- [GeckoDriver (Firefox)](https://github.com/mozilla/geckodriver/releases)
- [GitHub Actions](https://github.com/features/actions)
  
---

## Installation & Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/GollapudiP/UltimateQA.git
   cd UltimateQA
   
2. **Install Dependencies**
   ```bash
   dotnet restore

3. **Build the Project**
   ```bash
   dotnet build

4. **Run Tests**
   ```bash
   dotnet test

This will:

- Read test data from JSON files under TestData/
- Launch browser (Chrome/Firefox based on configuration)
- Generate an HTML report using ExtentReports which will be saved as an artifact in the GitHub Actions workflow runs
- Use GitHub Actions workflow to run tests on each push and pull request on master along with a scheduled run daily at 12:00 PM AWST.
  
---

## Best Practices

- Use [TestCaseSource] or JSON data providers for test reusability
- Structure POM classes cleanly (1 page = 1 class)
- Keep driver setup in Utilities/DriverFactory.cs
- Use TearDown to ensure driver cleanup.
- Integrate with GitHub Actions CI pipelines.

---

## Coming Soon

- Screenshots for failure logs in ExtentReports
- Parallel test execution

---

## License

MIT © 2025 Priya Gollapudi

---

## Author

Priya Gollapudi
