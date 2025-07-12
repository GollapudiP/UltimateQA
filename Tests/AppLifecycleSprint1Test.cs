using UltimateQA.Pages;
using Newtonsoft.Json;
using AventStack.ExtentReports.Model;
using NUnit.Framework;

namespace UltimateQA.Tests
{
    public class AppLifecycleSprint1Test : BaseTest
    {

        [Test, Order(1)]
        public void VerifyAppLifecycleSprint1PageTitle()
        {
            ReportManager.CreateTest("VerifyAppLifecycleSprint1PageTitle");

            var page = new AppLifecycleSprint1Page(Driver);
            page.GoToUltimateQA();
            page.NavigateToAppLifecycleSprint1();
            AssertPageTitle("Application Lifecycle");
            AssertPageUrl("ultimateqa.com/sample-application-lifecycle-sprint-1");

            ReportManager.LogPass("Application Lifecycle Sprint 1 page title and URL verified successfully.");
        }

        //[TestCase("Priya")]
        [Test, Order(2), TestCaseSource(nameof(GetTestData))]
        public void FirstNameIsSubmittedSuccessfully(UserData user)
        {
            ReportManager.CreateTest("FirstNameIsSubmittedSuccessfully");

            var page = new AppLifecycleSprint1Page(Driver);
            page.GoToUltimateQA();
            page.NavigateToAppLifecycleSprint1();
            page.EnterFirstName(user.FirstName);
            page.SubmitDetails();
            AssertPageTitle("Homepage - Ultimate QA");
            AssertPageUrl($"ultimateqa.com/?firstname={user.FirstName}");

            ReportManager.LogPass($"First name '{user.FirstName}' submitted successfully and page title and URL verified.");
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            // Example test data; replace with your actual data source as needed
            yield return new TestCaseData(new UserData { FirstName = "Priya" });
            yield return new TestCaseData(new UserData { FirstName = "Priya 1" });
        }

    }

    public class UserData
    {
        public string FirstName { get; set; }
    }

    public static class TestDataProvider
    {
        public static IEnumerable<TestCaseData> GetTestData()
        {
            // Example test data; replace with your actual data source as needed
            yield return new TestCaseData(new UserData { FirstName = "Priya" });
            yield return new TestCaseData(new UserData { FirstName = "Priya 1" });
        }
    }

    /* public static IEnumerable<TestCaseData> FirstNameSubmitTestData()
        {
            foreach (var data in JsonDataReader.GetAppLCSprint1Data())
            {
                yield return new TestCaseData(data.Username);
            }
        } */
}