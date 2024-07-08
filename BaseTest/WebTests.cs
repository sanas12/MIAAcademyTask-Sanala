using AventStack.ExtentReports;
using MiaAcademyAutomation.Source.Pages;
using MiaAcademyAutomation.Utilities;


namespace MiaAcademyAutomation.Tests
{
    [TestFixture]
    public class WebTests : TestHooks
    {
        // List to hold test data loaded from a JSON file
        private List<User> users1;

        // Setup method to load test data before each test
        [SetUp]
        public void LoadTestData()
        {
            // Load users from JSON file and assign to users1 list
            users1 = Datadriventesting.LoadUsers1("/Users/sowmyasanala/Desktop/c#/AutomationFramework/MiaAcademyAutomation/bin/Debug/net7.0/users.json");
        }

        // Test case for verifying the Mia Prep link on the Home Page
        [Test, Category("Smoke testing")]
        [Ignore("Ignore a test")]
        [Description("Verify clicking Mia Prep link on the Home Page.")]
        public void HomePageTest()
        {
            // Create a test entry in the report
            test = extent.CreateTest("HomePageTest", "Verify clicking Mia Prep link on the Home Page.");
            try
            {
                // Initialize HomePage object and perform click action
                HomePage homePage = new HomePage(_driver);
                homePage.ClickMiaPrepLink();
                // Log successful action
                test.Log(Status.Pass, "Mia Prep link clicked successfully.");
            }
            catch (Exception ex)
            {
                // Log failure and rethrow the exception
                test.Log(Status.Fail, $"Test failed with exception: {ex.Message}");
                throw;
            }
            finally
            {
                // Log additional information after the test
                test.Log(Status.Info, $"After the url was accessed the page title was: {_driver.Title}");
            }
        }

        // Test case for verifying the "Apply to Our School" link on the Result Page
        [Test, Category("Integration testing")]
        [Ignore("Ignore a test")]
        [Description("Verify clicking Apply to Our School link on the Result Page.")]
        public void SecPageTest1()
        {
            // Create a test entry in the report
            test = extent.CreateTest("SecPageTest1", "Verify clicking Apply to Our School link on the Result Page.");
            try
            {
                // Initialize HomePage object and perform navigation and click actions
                HomePage homePage = new HomePage(_driver);
                var resultPage1 = homePage.ClickMiaPrepLink();
                resultPage1.ClickApplyToOurSchoolLink();
                // Log successful action
                test.Log(Status.Pass, "Apply to Our School link clicked successfully.");
            }
            catch (Exception ex)
            {
                // Log failure and rethrow the exception
                test.Log(Status.Fail, $"Test failed with exception: {ex.Message}");
                throw;
            }
            finally
            {
                // Log additional information after the test
                test.Log(Status.Info, $"After the url was accessed the page title was: {_driver.Title}");
            }
        }

        // Test case for verifying Parent Info Page with valid data
        [Test, Category("Smoke testing")]
        [Ignore("Ignore a test")]
        [Description("Verify Parent Info Page view with valid data (users1).")]
        public void ParentInfoPageTest()
        {
            // Create a test entry in the report
            test = extent.CreateTest("ParentInfoPageTest", "Verify Parent Info Page view with valid data (users1).");
            try
            {
                // Initialize HomePage object and perform navigation actions
                HomePage homePage = new HomePage(_driver);
                var resultPage1 = homePage.ClickMiaPrepLink();
                var parentResult1 = resultPage1.ClickApplyToOurSchoolLink();

                // Loop through each user and view the Parent Info Page
                foreach (var user in users1)
                {
                    parentResult1.ParentInfoPageView(user);
                    // Log information for each user
                    test.Log(Status.Info, $"Viewed Parent Info Page for user: {user.ParentFirstName}");
                }
                // Log successful action
                test.Log(Status.Pass, "Parent Info Page viewed successfully for all valid users.");
            }
            catch (Exception ex)
            {
                // Log failure and rethrow the exception
                test.Log(Status.Fail, $"Test failed with exception: {ex.Message}");
                throw;
            }
            finally
            {
                // Log additional information after the test
                test.Log(Status.Info, $"After the url was accessed the page title was: {_driver.Title}");
            }
        }

        // Test case for regression testing with valid data
        [Test, Category("Regression testing")]
        [Description("Verify Parent Info Page view with regression testing using valid data (users1).")]
        public void AllTest()
        {
            // Create a test entry in the report
            test = extent.CreateTest("AllTest", "Verify Parent Info Page view with regression testing using valid data (users1).");
            try
            {
                // Initialize HomePage object and perform navigation actions
                HomePage homePage = new HomePage(_driver);
                var resultPage = homePage.ClickMiaPrepLink();
                var parentResult = resultPage.ClickApplyToOurSchoolLink();

                // Loop through each user and view the Parent Info Page
                foreach (var user in users1)
                {
                    parentResult.ParentInfoPageView(user);
                    // Log information for each user
                    test.Log(Status.Info, $"Viewed Parent Info Page for user: {user.ParentFirstName}");
                }
                // Log successful action
                test.Log(Status.Pass, "Parent Info Page viewed successfully for all valid users.");
            }
            catch (Exception ex)
            {
                // Log failure and rethrow the exception
                test.Log(Status.Fail, $"Test failed with exception: {ex.Message}");
                throw;
            }
            finally
            {
                // Log additional information after the test
                test.Log(Status.Info, $"After the url was accessed the page title was: {_driver.Title}");
            }
        }
    }
}
