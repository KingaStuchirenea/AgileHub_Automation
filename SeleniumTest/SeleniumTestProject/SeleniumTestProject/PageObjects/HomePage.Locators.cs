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
            _driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        }
        private IWebElement AutentificationButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement InscriereButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        private IWebElement VeziDetaliiButton => _driver.FindElement(By.CssSelector(".btn-primary"));

        

    }
}
