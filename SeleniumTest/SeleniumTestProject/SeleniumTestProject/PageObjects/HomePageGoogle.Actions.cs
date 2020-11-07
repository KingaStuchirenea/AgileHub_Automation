using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class HomePageGoogleDriver
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePageGoogleDriver(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public void SearchInGoogle(string textToBeSearched)
        {
            _driver.SwitchTo().Frame(0);
            suntDeAcordButton.Click();
            googleTextBoxField.SendKeys(textToBeSearched);
            googleTextBoxField.SendKeys(Keys.Enter);
        }

        public void SearchImagesFirstPicture()
        {
            imaginiButton.Click();
            firstPic.Click();
            _driver.Navigate().Back();
        }
    }
}
