using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SeleniumExtras.WaitHelpers;

namespace SeleniumTestProject.PageObjects
{
    partial class LoginPage
    {
        private IWebElement EmailFieldTextBox => _driver.FindElement(By.CssSelector("input[type=email]"));
        private IWebElement PasswordFieldTextBox => _driver.FindElement(By.CssSelector("input[type=password]"));
        private IWebElement SubmitButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button[type=submit]")));


    }
}
