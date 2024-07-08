using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MiaAcademyAutomation.Source.Pages
{
    public class HomePage 
    {
        private readonly IWebDriver _driver;

        // WebElement declaration using PageFactory's FindsBy attribute
        [FindsBy(How = How.XPath, Using = "//a[@href='https://miaprep.com/online-school/']")]
        public IWebElement miaPrepLink;

        // Constructor that initializes the page objects using PageFactory
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this); 
        }

        // Method to click on the MiaPrep link and navigate to the SecPage
        public SecPage ClickMiaPrepLink()
        {
            

            // Validation to check if the navigation was successful
            if (_driver.Url.Contains("https://miacademy.co/"))
            {
                Console.WriteLine("MiaPrep page is available in the homepage.");
                // Click on the MiaPrep link
                Console.WriteLine("Clicked on the MiaPrep link.");
            }
            else
            {
                Console.WriteLine("MiaPrep page is not available in the homepage. Current URL: " + _driver.Url);
                throw new Exception("Navigation failed.");
            }

            // Return an instance of SecPage after clicking the link
            Console.WriteLine("Sucessfully naviagted to online high school page");
            miaPrepLink.Click();

            return new SecPage(_driver);
        }
    }






}
