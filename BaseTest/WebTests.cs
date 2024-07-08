using AventStack.ExtentReports;
using MiaAcademyAutomation.Source.Pages;
using MiaAcademyAutomation.Utilities;

namespace MiaAcademyAutomation.Tests
{
    [TestFixture]
    public class WebTests : TestHooks
    {
        private List<User> users1;

        [SetUp]
        public void LoadTestData()
        {
            users1 = Datadriventesting.LoadUsers1("/Users/sowmyasanala/Desktop/c#/AutomationFramework/MiaAcademyAutomation/bin/Debug/net7.0/users.json");
        }

        [Test, Category("Smoke testing")]
        [Ignore("Ignore a test")]
        [Description("Verify clicking Mia Prep link on the Home Page.")]
        public void HomePageTest()
        {
            test = extent.CreateTest("HomePageTest", "Verify clicking Mia Prep link on the Home Page.");
            try
            {
                HomePage homePage = new HomePage(_driver);
                homePage.ClickMiaPrepLink();
                test.Log(Status.Pass, "Mia Prep link clicked successfully.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, $"Test failed with exception: {ex.Message}");
                throw;
            }
            finally
            {
                test.Log(Status.Info, $"After the url was accessed the page title was: {_driver.Title}");
            }
        }

        [Test, Category("Integration testing")]
        [Ignore("Ignore a test")]
        [Description("Verify clicking Apply to Our School link on the Result Page.")]
        public void SecPageTest1()
        {
            test = extent.CreateTest("SecPageTest1", "Verify clicking Apply to Our School link on the Result Page.");
            try
            {
                HomePage homePage = new HomePage(_driver);
                var resultPage1 = homePage.ClickMiaPrepLink();
                resultPage1.ClickApplyToOurSchoolLink();
                test.Log(Status.Pass, "Apply to Our School link clicked successfully.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, $"Test failed with exception: {ex.Message}");
                throw;
            }
            finally
            {
                test.Log(Status.Info, $"After the url was accessed the page title was: {_driver.Title}");
            }
        }

        [Test, Category("Smoke testing")]
        [Ignore("Ignore a test")]
        [Description("Verify Parent Info Page view with valid data (users1).")]
        public void ParentInfoPageTest()
        {
            test = extent.CreateTest("ParentInfoPageTest", "Verify Parent Info Page view with valid data (users1).");
            try
            {
                HomePage homePage = new HomePage(_driver);
                var resultPage1 = homePage.ClickMiaPrepLink();
                var parentResult1 = resultPage1.ClickApplyToOurSchoolLink();

                foreach (var user in users1)
                {
                    parentResult1.ParentInfoPageView(user);
                    test.Log(Status.Info, $"Viewed Parent Info Page for user: {user.ParentFirstName}");
                }
                test.Log(Status.Pass, "Parent Info Page viewed successfully for all valid users.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, $"Test failed with exception: {ex.Message}");
                throw;
            }
            finally
            {
                test.Log(Status.Info, $"After the url was accessed the page title was: {_driver.Title}");
            }
        }

        [Test, Category("Regression testing")]
        [Description("Verify Parent Info Page view with regression testing using valid data (users1).")]
        public void AllTest()
        {
            test = extent.CreateTest("AllTest", "Verify Parent Info Page view with regression testing using valid data (users1).");
            try
            {
                HomePage homePage = new HomePage(_driver);
                var resultPage = homePage.ClickMiaPrepLink();
                var parentResult = resultPage.ClickApplyToOurSchoolLink();

                foreach (var user in users1)
                {
                    parentResult.ParentInfoPageView(user);
                    test.Log(Status.Info, $"Viewed Parent Info Page for user: {user.ParentFirstName}");
                }
                test.Log(Status.Pass, "Parent Info Page viewed successfully for all valid users.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, $"Test failed with exception: {ex.Message}");
                throw;
            }
            finally
            {
                test.Log(Status.Info, $"After the url was accessed the page title was: {_driver.Title}");
            }
        }
    }
}
