using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MiaAcademyAutomation.Utilities
{
    [SetUpFixture]
    public class TestHooks
    {
        public static IWebDriver _driver;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public ExtentTest test;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("I am inside logs.");

            // path for the report
            string reportPath = "../../../index.html";

            // Create the ExtentHtmlReporter object 
            htmlReporter = new ExtentHtmlReporter(reportPath);
            htmlReporter.Config.DocumentTitle = "Automation Test Report";
            htmlReporter.Config.ReportName = "Automation Test Report";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("User Name", "Your Name");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            extent.Flush();
        }

        //Driver configuration

        [SetUp]
        public void Setup()
        {
            try
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                _driver = new ChromeDriver();
                _driver.Navigate().GoToUrl("https://miacademy.co/#/");
                _driver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {
                Assert.Fail($"WebDriver initialization failed: {ex.Message}");
            }
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
