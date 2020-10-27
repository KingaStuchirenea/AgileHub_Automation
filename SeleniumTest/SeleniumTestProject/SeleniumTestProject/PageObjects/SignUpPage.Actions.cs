using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class SignUpPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public SignUpPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public void PopulateSignUpPage()
        {
            Nume.SendKeys("John Miller");
            Email.SendKeys("john.miller1@xyz.com");
            Telefon.SendKeys("0712345678");
            Adresa.SendKeys("Brasov, Str. 13 Dec");
            Parola.SendKeys("pwd123");
            ConfirmareParola.SendKeys("pwd123");
            SubmitButton.Click();
        }

        public void LoginNewUser()
        {
            NewEmail.SendKeys("john.miller1@xyz.com");
            NewParola.SendKeys("pwd123");
            AutentificareButton.Click();
        }

    }
}
