using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MiaAcademyAutomation.Source.Pages
{
    public class StudentInfoPage
    {
        private readonly IWebDriver _driver;

        // WebElements defined using FindsBy attribute for various fields and dropdowns

        [FindsBy(How = How.XPath, Using = "//span[@id='select2-Dropdown1-arialabel-container']")]
        private IWebElement enrollDropDown;

        [FindsBy(How = How.XPath, Using = "//input[@class='select2-search__field' and @type='search' and @role='textbox']")]
        private IWebElement _searchTxtBx;

        [FindsBy(How = How.XPath, Using = "//input[@complink='Name2_First']")]
        private IWebElement studentFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@complink='Name2_Last']")]
        private IWebElement studentLastName;

        [FindsBy(How = How.XPath, Using = "//input[@id='SingleLine5-arialabel' and @name='SingleLine5' and @type='text']")]
        private IWebElement studentPreferredName;

        [FindsBy(How = How.XPath, Using = "//input[@name='Email2']")]
        private IWebElement studentEmail;

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber2']")]
        private IWebElement studentPhone;

        [FindsBy(How = How.XPath, Using = "//input[@id='SingleLine3-arialabel' and @name='SingleLine3' and @type='text']")]
        private IWebElement studentDOB;

        [FindsBy(How = How.XPath, Using = "//span[@id='select2-Dropdown3-arialabel-container']")]
        private IWebElement genderDropDown;

        [FindsBy(How = How.XPath, Using = "//span[@class='select2-search select2-search--dropdown']/input[@class='select2-search__field']")]
        private IWebElement _searchTxtBx1;

        [FindsBy(How = How.XPath, Using = "//span[@id='select2-Dropdown4-arialabel-container']")]
        private IWebElement accountDropDown;

        [FindsBy(How = How.XPath, Using = "//span[@class='select2-search select2-search--dropdown']/input[@class='select2-search__field']")]
        private IWebElement _searchTxtBx2;

        [FindsBy(How = How.XPath, Using = "//span[@id='select2-Dropdown5-arialabel-container']")]
        private IWebElement schoolingDropDown;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'select2-search') and contains(@class, 'select2-search--dropdown')]/input[@class='select2-search__field']")]
        private IWebElement _searchTxtBx3;

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox1_1' and @aria-hidden='true' and @class='checkChoice cusChoiceLabel']")]
        private IWebElement mathCheckbox1;

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox1_5' and @aria-hidden='true' and @class='checkChoice cusChoiceLabel']")]
        private IWebElement mathCheckbox2;

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox2_2' and @class='checkChoice cusChoiceLabel']")]
        private IWebElement englishCheckbox1;

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox2_3' and @class='checkChoice cusChoiceLabel']")]
        private IWebElement englishCheckbox2;

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox3_2' and @class='checkChoice cusChoiceLabel']")]
        private IWebElement scienceCheckbox;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='MultiLine-arialabel' and @name='MultiLine']")]
        private IWebElement studentTextArea;

        [FindsBy(How = How.XPath, Using = "//span[@id='select2-Dropdown13-arialabel-container']")]
        private IWebElement studentChallengeDropDown;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'select2-search') and contains(@class, 'select2-search--dropdown')]/input[@class='select2-search__field']")]
        private IWebElement studentChallenge;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label=\"Next\nNavigates to page 3 out of 3\" and @class='fmSmtButton next_previous navWrapper' and @type='button' and @elname='next']")]
        public IWebElement nextButton1;


        public StudentInfoPage(IWebDriver driver)

        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        public void StudentInfoPageView(StudentInfo student)
        {
            // Validate the title of the new page
            string expectedTitle = "MOHS Intial Application";
            if (_driver.Title.Contains(expectedTitle))
            {
                Console.WriteLine($"Successfully navigated to student info  page with title: {_driver.Title}");
            }
            else
            {
                Console.WriteLine($"Failed to navigate to student info page with expected title '{expectedTitle}'. Actual title: {_driver.Title}");
                throw new Exception("Navigation failed.");
            }
            Thread.Sleep(2000);


            enrollDropDown.Click();
            _searchTxtBx.SendKeys("One");
            _searchTxtBx.SendKeys(Keys.Enter);

            studentFirstName.SendKeys(student.StudentFirstName);
            studentLastName.SendKeys(student.StudentLastName);
            studentPreferredName.SendKeys(student.StudentPreferredName);
            studentEmail.SendKeys(student.StudentEmail);

            Thread.Sleep(2000);

            studentPhone.SendKeys(student.StudentPhone);
            studentDOB.SendKeys(student.StudentDOB);
            studentDOB.SendKeys(Keys.Enter);

            genderDropDown.Click();
            _searchTxtBx1.SendKeys(student.Gender);
            _searchTxtBx1.SendKeys(Keys.Enter);

            Thread.Sleep(1000);

            accountDropDown.Click();
            _searchTxtBx2.SendKeys(student.Account);
            _searchTxtBx2.SendKeys(Keys.Enter);

            Thread.Sleep(1000);

            schoolingDropDown.Click();
            _searchTxtBx3.SendKeys(student.Schooling);
            _searchTxtBx3.SendKeys(Keys.Enter);

            Thread.Sleep(1000);

            foreach (var checkbox in student.MathCheckboxes)
            {
                _driver.FindElement(By.XPath($"//label[@for='{checkbox}' and @aria-hidden='true' and @class='checkChoice cusChoiceLabel']")).Click();
            }

            foreach (var checkbox in student.EnglishCheckboxes)
            {
                _driver.FindElement(By.XPath($"//label[@for='{checkbox}' and @aria-hidden='true' and @class='checkChoice cusChoiceLabel']")).Click();
            }

            _driver.FindElement(By.XPath($"//label[@for='{student.ScienceCheckbox}' and @aria-hidden='true' and @class='checkChoice cusChoiceLabel']")).Click();

            studentTextArea.SendKeys(student.StudentTextArea);

            studentChallengeDropDown.Click();
            studentChallenge.SendKeys(student.StudentChallenge);
            studentChallenge.SendKeys(Keys.Enter);

            Thread.Sleep(5000);
        }

        
    }
}