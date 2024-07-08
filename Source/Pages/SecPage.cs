using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MiaAcademyAutomation.Source.Pages
{
    public class SecPage
    {
        private readonly IWebDriver _driver;

        // WebElement declaration using PageFactory's FindsBy attribute
        [FindsBy(How = How.XPath, Using = "//a[@href='https://forms.zohopublic.com/miaplazahelp/form/MOHSInitialApplication/formperma/okCyt4yyq39rZvSBXB9FSjDeek1ilbRVK1iNCK--3K8']")]
        public IWebElement mohsLink;

        // Constructor that initializes the page objects using PageFactory
        public SecPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        // Method to click on the Apply to Our School link and navigate to ParentInfoPage
        public ParentInfoPage ClickApplyToOurSchoolLink()
        {
            // Validate the title of the new page
            string expectedTitle = "MiaPrep Online High School - MiaPrep";
            if (_driver.Title.Contains(expectedTitle))
            {
                Console.WriteLine($"Successfully navigated to MiaPrep page with title: {_driver.Title}");
            }
            else
            {
                Console.WriteLine($"Failed to navigate to MiaPrep page with expected title '{expectedTitle}'. Actual title: {_driver.Title}");
                throw new Exception("Navigation failed.");
            }


            // Click on the MOHS link to apply to the school
            mohsLink.Click();

            // Return an instance of ParentInfoPage after clicking the MOHS link
            return new ParentInfoPage(_driver);
        }
    }
}
