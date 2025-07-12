using UltimateQA.Pages;
using Newtonsoft.Json;
using AventStack.ExtentReports.Model;
using NUnit.Framework;
using TestStatus = AventStack.ExtentReports.Status;
using NUnit.Framework.Internal;

namespace UltimateQA.Tests
{
    public class AppLifecycleSprint1Test : BaseTest
    {
        [Test, Order(1)]
        public void VerifyAppLifecycleSprint1PageTitle()
        {
            var test = Report.CreateTest("VerifyAppLifecycleSprint1PageTitle");

            var page = new AppLifecycleSprint1Page(Driver);
            page.GoToUltimateQA();
            page.NavigateToAppLifecycleSprint1();
            AssertPageTitle("Application Lifecycle");
            AssertPageUrl("ultimateqa.com/sample-application-lifecycle-sprint-1");

            test.Log(TestStatus.Pass, "Application Lifecycle Sprint 1 page title and URL verified successfully.");
        }

        public static IEnumerable<TestCaseData> FirstNameIsSubmittedSuccessfullyTestData => TestDataProvider.GetTestData<Sprint1TestData>("Sprint1TestData.json");

        //[TestCase("Priya")]
        [Test, Order(2), TestCaseSource(nameof(FirstNameIsSubmittedSuccessfullyTestData))]
        public void FirstNameIsSubmittedSuccessfully(Sprint1TestData user)
        {
            var test = Report.CreateTest("FirstNameIsSubmittedSuccessfully");

            var page = new AppLifecycleSprint1Page(Driver);
            page.GoToUltimateQA();
            page.NavigateToAppLifecycleSprint1();
            page.EnterFirstName(user.FirstName);
            page.SubmitDetails();
            AssertPageTitle("Homepage - Ultimate QA");
            AssertPageUrl($"ultimateqa.com/?firstname={user.FirstName}");

            test.Log(TestStatus.Pass, $"First name '{user.FirstName}' submitted successfully and page title and URL verified.");
        }


        [Test, Order(3)]
        public void VerifyAppLifecycleSprint2PageTitle()
        {
            var test = Report.CreateTest("VerifyAppLifecycleSprint2PageTitle");

            var page = new AppLifecycleSprint2Page(Driver);
            page.GoToUltimateQA();
            page.NavigateToAppLifecycleSprint1();
            page.NavigateToNextSprintPage();
            AssertPageTitle("Sample Application Lifecycle");
            AssertPageUrl("ultimateqa.com/sample-application-lifecycle-sprint-2");

            test.Log(TestStatus.Pass, "Application Lifecycle Sprint 2 page title and URL verified successfully.");
        }

        public static IEnumerable<TestCaseData> FirstNameLastNameIsSubmittedSuccessfullyTestData => TestDataProvider.GetTestData<Sprint2TestData>("Sprint2TestData.json");

        [Test, Order(4), TestCaseSource(nameof(FirstNameLastNameIsSubmittedSuccessfullyTestData))]
        public void FirstNameLastNameIsSubmittedSuccessfully(Sprint2TestData data)
        {
            var test = Report.CreateTest("FirstNameLastNameIsSubmittedSuccessfully");

            var page = new AppLifecycleSprint2Page(Driver);
            page.GoToUltimateQA();
            page.NavigateToAppLifecycleSprint1();
            page.NavigateToNextSprintPage();
            page.EnterFirstName(data.FirstName);
            page.EnterLastName(data.LastName);
            page.SubmitDetails();
            AssertPageTitle("Homepage - Ultimate QA");
            AssertPageUrl($"ultimateqa.com/?firstname={data.FirstName}&lastname={data.LastName}");

            test.Log(TestStatus.Pass, $"First name '{data.FirstName}' and last name '{data.LastName}' submitted successfully and page title and URL verified.");
        }

        [Test, Order(5)]
        public void VerifyAppLifecycleSprint3PageTitle()
        {
            var test = Report.CreateTest("VerifyAppLifecycleSprint3PageTitle");

            var page = new AppLifecycleSprint3Page(Driver);
            page.GoToUltimateQA();
            page.NavigateToAppLifecycleSprint1();
            page.NavigateToNextSprintPage();
            page.NavigateToSprint3Page();
            AssertPageTitle("Sample Application Lifecycle");
            AssertPageUrl("ultimateqa.com/sample-application-lifecycle-sprint-3");

            test.Log(TestStatus.Pass, "Application Lifecycle Sprint 3 page title and URL verified successfully.");
        }


        public static IEnumerable<TestCaseData> FirstNameLastNameGenderIsSubmittedSuccessfullyTestData => TestDataProvider.GetTestData<Sprint3TestData>("Sprint3TestData.json");

        [Test, Order(6), TestCaseSource(nameof(FirstNameLastNameGenderIsSubmittedSuccessfullyTestData))]
        public void FirstNameLastNameGenderIsSubmittedSuccessfully(Sprint3TestData data)
        {
            var test = Report.CreateTest("FirstNameLastNameGenderIsSubmittedSuccessfully");

            var page = new AppLifecycleSprint3Page(Driver);
            page.GoToUltimateQA();
            page.NavigateToAppLifecycleSprint1();
            page.NavigateToNextSprintPage();
            page.NavigateToSprint3Page();
            page.SelectGender(data.Gender);
            page.EnterFirstName(data.FirstName);
            page.EnterLastName(data.LastName);
            page.SubmitDetails();
            AssertPageTitle("Homepage - Ultimate QA");
            AssertPageUrl($"ultimateqa.com/?gender={data.Gender}&firstname={data.FirstName}&lastname={data.LastName}");

            test.Log(TestStatus.Pass, $"First name '{data.FirstName}', last name '{data.LastName}', and gender '{data.Gender}' submitted successfully and page title and URL verified.");
        }
    }
}