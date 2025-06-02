// Facebook automation processing a registration
// Working with dropdown menus
// This is with fake fields, so it will not fully be able to create an account
// But with the correct and real credentials and account should be able to be made
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Automation
{
    class Program
    {
        // Create a reference for Chrome browser
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            // Go to Google Page
            driver.Navigate().GoToUrl("https://www.facebook.com");
        }

        [Test]
        public void ExecuteTest()
        {
            // Make the browser full screen
            driver.Manage().Window.Maximize();

            // Clicking new account
            IWebElement create_new_account = driver.FindElement(By.XPath("//a[text()='Create new account']"));
            create_new_account.Click();

            // Inputting first name
            IWebElement first_name = driver.FindElement(By.Name("firstname"));
            first_name.SendKeys("John");

            // Inputting last name
            IWebElement last_name = driver.FindElement(By.Name("lastname"));
            last_name.SendKeys("Wick");

            // Selecting a month
            IWebElement month = driver.FindElement(By.Id("month"));
            // Allowing to use a dropdown menu
            var select_element_month = new SelectElement(month);
            select_element_month.SelectByValue("4"); // Selecting April

            // Selecting a day
            IWebElement day = driver.FindElement(By.Id("day"));
            var select_day = new SelectElement(day);
            select_day.SelectByValue("7"); // Selecting day 7

            // Selecting a year
            IWebElement year = driver.FindElement(By.Id("year"));
            var select_year = new SelectElement(year);
            select_year.SelectByValue("2000"); // Selecting year 2005

            // Choosing gender
            IWebElement gender = driver.FindElement(By.XPath("//input[@name='sex' and @value='2']"));
            gender.Click();

            // Creating email
            IWebElement email = driver.FindElement(By.Name("reg_email__"));
            email.SendKeys("johnnnwwwick420@gmail.com");

            //Creating password
            IWebElement password = driver.FindElement(By.Name("reg_passwd__"));
            password.SendKeys("coolmovies123!");

            // Creating account
            IWebElement create = driver.FindElement(By.Name("websubmit"));
            create.Click();

        }

        [TearDown]
        public void CloseTest()
        {
            // Uncomment this to automatically close the browser once testing has been done
            //driver.Quit();
        }
    }
}