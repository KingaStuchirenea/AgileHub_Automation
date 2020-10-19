using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement AutentificationButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement InscriereButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
    }
}
