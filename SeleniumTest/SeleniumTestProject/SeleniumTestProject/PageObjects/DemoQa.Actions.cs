using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class DemoQa
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public DemoQa(IWebDriver driver/*, string url*/)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            // _driver.Navigate().GoToUrl(url);
        }

        public void PopulatePageAndSubmit()
        {
            FirstName.SendKeys("Miller");
            LastName.SendKeys("John");
            UserEmail.SendKeys("Miller.John@yahoo.com");
            Gender.Click();
            MobileNumber.SendKeys("0751123456");
            DateOfBirth.Click();
            Month.Click();
            Year.Click();
            Day.Click();
            Subjects.SendKeys("Test subjects");
            Thread.Sleep(2000);
            Hobbies.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", Picture);
            //Thread.Sleep(5000);
            //Picture.Click();
            CurrentAddress.SendKeys("Str. 13 Dec");
            Thread.Sleep(2000);
            StateDropDown.Click();
            StateOption.Click();
            CityDropDown.Click();
            CityOption.Click();
            Submit.Click();
        }

        public void PopulateAndSubmit()
        {
            UserName.SendKeys("Miller John");
            UserEmail.SendKeys("Miller.John@yahoo.com");
            CurrentAddress.SendKeys("Brasov, Str. 13 Dec");
            PermanentAddress.SendKeys("Brasov, Str. 13 Dec");
            Submit.Click();
        }

    }
}
