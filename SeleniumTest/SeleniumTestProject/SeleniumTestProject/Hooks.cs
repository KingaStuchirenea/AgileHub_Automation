using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestProject
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
