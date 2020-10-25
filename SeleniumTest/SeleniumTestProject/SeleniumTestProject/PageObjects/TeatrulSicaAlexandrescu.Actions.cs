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
    partial class TeatrulSicaAlexandrescu
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public TeatrulSicaAlexandrescu(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            _driver.Navigate().GoToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");
        }

        public void SelectTeamMember()
        {
            SelectTeam.Click();
            //scrolls down page 500px
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollBy(0,500)", "");
            Thread.Sleep(5000);
            SelectMember.Click();
        }

        public void SelectShow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollBy(0,500)", "");
            Thread.Sleep(5000);
            SelectFirstShow.Click();
        }
    }
}
