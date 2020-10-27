using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class SignUpPage
    {
        private IWebElement Nume => _driver.FindElement(By.CssSelector("input[name='name']"));
        private IWebElement Email => _driver.FindElement(By.CssSelector("input[name='email']"));
        private IWebElement Telefon => _driver.FindElement(By.CssSelector("input[name ='phone']"));
        private IWebElement Adresa => _driver.FindElement(By.CssSelector("textarea[name='address']"));
        private IWebElement Parola => _driver.FindElement(By.CssSelector("input[name='password_1']"));
        private IWebElement ConfirmareParola => _driver.FindElement(By.CssSelector("input[name='password_2']"));
        private IWebElement SubmitButton => _driver.FindElement(By.CssSelector("button[type='submit']"));
        private IWebElement NewEmail => _driver.FindElement(By.CssSelector("input[name='email']"));
        private IWebElement NewParola => _driver.FindElement(By.CssSelector("input[name='password']"));
        private IWebElement AutentificareButton => _driver.FindElement(By.CssSelector("button[type='submit']"));



    }
}
