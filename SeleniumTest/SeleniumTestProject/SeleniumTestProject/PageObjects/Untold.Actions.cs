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
    partial class Untold
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public Untold(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            _driver.Navigate().GoToUrl("https://untold.com/");
        }

        public void GoToHome()
        {
            Thread.Sleep(5000);
            Menu.Click();
            Thread.Sleep(5000);
            Home.Click();
        }
    }
}
