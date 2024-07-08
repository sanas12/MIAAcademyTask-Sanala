using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MiaAcademyAutomation.Source.Pages
{
    public class ParentInfoPage
    {
        private readonly IWebDriver _driver;

        // WebElements defined using FindsBy attribute for various fields and dropdowns

        [FindsBy(How = How.XPath, Using = "//input[@complink='Name_First']")]
        private IWebElement parentFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@complink='Name_Last']")]
        private IWebElement parentLastName;

        [FindsBy(How = How.XPath, Using = "//input[@name='Email']")]
        private IWebElement parentEmail;

        [FindsBy(How = How.XPath, Using = "//div[@class='selected-flag']")]
        private IWebElement selectedFlag;

        [FindsBy(How = How.XPath, Using = "//li[@class='country' and @data-country-code='de']")]
        private IWebElement germanyOption;

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        private IWebElement parentPhone;

        [FindsBy(How = How.XPath, Using = "//span[@class='select2-selection__arrow select2FormArrow']")]
        private IWebElement dropField;

        [FindsBy(How = How.XPath, Using = "//input[@class='select2-search__field']")]
        private IWebElement searchField;

        [FindsBy(How = How.XPath, Using = "//li[contains(@class, 'select2-results__option') and text()='Yes']")]
        private IWebElement yesOption;

        [FindsBy(How = How.XPath, Using = "//input[@complink='Name1_First']")]
        private IWebElement parentFirstName1;

        [FindsBy(How = How.XPath, Using = "//input[@complink='Name1_Last']")]
        private IWebElement parentLastName1;

        [FindsBy(How = How.XPath, Using = "//input[@name='Email1']")]
        private IWebElement parentEmail1;

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber1']")]
        private IWebElement parentPhone1;

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox_1']")]
        private IWebElement searchEngineCheckbox;

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox_10']")]
        private IWebElement otherSocialMediaCheckbox;

        [FindsBy(How = How.XPath, Using = "//input[@id='Date-date']")]
        private IWebElement datePickerInput;

        [FindsBy(How = How.XPath, Using = "//input[@id='Date-date' and @name='Date' and @type='text']")]
        private IWebElement selectDay;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Next']")]
        private IWebElement nextButton;


        public ParentInfoPage(IWebDriver driver)

        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        public StudentInfoPage ParentInfoPageView(User user)
        {
            // Validate the title of the new page
            string expectedTitle = "MOHS Initial Application";
            if (_driver.Title.Contains(expectedTitle))
            {
                Console.WriteLine($"Successfully navigated to MiaPrep page with title: {_driver.Title}");
            }
            else
            {
                Console.WriteLine($"Failed to navigate to MiaPrep page with expected title '{expectedTitle}'. Actual title: {_driver.Title}");
                throw new Exception("Navigation failed.");
            }

            parentFirstName.SendKeys(user.ParentFirstName);
            parentLastName.SendKeys(user.ParentLastName);
            parentEmail.SendKeys(user.ParentEmail);

            Thread.Sleep(2000);

            selectedFlag.Click();
            germanyOption.Click();

            Thread.Sleep(1000);

            parentPhone.SendKeys(user.ParentPhone);

            dropField.Click();
            searchField.Click();
            yesOption.Click();

            parentFirstName1.SendKeys(user.ParentFirstName1);
            parentLastName1.SendKeys(user.ParentLastName1);
            parentEmail1.SendKeys(user.ParentEmail1);

            Thread.Sleep(1000);

            parentPhone1.SendKeys(user.ParentPhone1);

            searchEngineCheckbox.Click();

            Thread.Sleep(1000);

            if (!otherSocialMediaCheckbox.Selected)
            {
                otherSocialMediaCheckbox.Click();
            }

            Thread.Sleep(1000);

            datePickerInput.Click();
            Thread.Sleep(1000);
            selectDay.SendKeys(user.Date);
            selectDay.SendKeys(Keys.Enter);



            Thread.Sleep(1000);

            nextButton.Click();

            Thread.Sleep(2000);


            return new StudentInfoPage(_driver);


        }
    }
}

