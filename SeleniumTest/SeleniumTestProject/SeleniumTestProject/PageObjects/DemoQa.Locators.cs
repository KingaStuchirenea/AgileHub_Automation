using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class DemoQa
    {
        private IWebElement FirstName => _driver.FindElement(By.Id("firstName"));
        private IWebElement LastName => _driver.FindElement(By.Id("lastName"));
        private IWebElement UserEmail => _driver.FindElement(By.Id("userEmail"));
        private IWebElement Gender => _driver.FindElement(By.CssSelector("label[for='gender-radio-2']"));
        private IWebElement MobileNumber => _driver.FindElement(By.CssSelector("input[placeholder='Mobile Number']"));
        private IWebElement DateOfBirth => _driver.FindElement(By.Id("dateOfBirthInput"));
        private IWebElement Month => _driver.FindElement(By.CssSelector("option[value='2']"));
        private IWebElement Year => _driver.FindElement(By.CssSelector("option[value='1988']"));
        private IWebElement Day => _driver.FindElement(By.CssSelector("div[class='react-datepicker__day react-datepicker__day--005 react-datepicker__day--weekend']"));
        private IWebElement Subjects => _driver.FindElement(By.Id("subjectsInput"));
        private IWebElement Hobbies => _driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-1']"));
        private IWebElement Picture => _driver.FindElement(By.XPath("//*[@id='uploadPicture']"));
        private IWebElement CurrentAddress => _driver.FindElement(By.Id("currentAddress"));
        private IWebElement StateDropDown => _driver.FindElement(By.CssSelector("div[class=' css-1wa3eu0-placeholder']"));
        private IWebElement StateOption => _driver.FindElement(By.Id("react-select-3-option-0"));
        private IWebElement CityDropDown => _driver.FindElement(By.CssSelector("div[class=' css-1wa3eu0-placeholder']"));
        private IWebElement CityOption => _driver.FindElement(By.Id("react-select-4-option-0"));
        private IWebElement Submit => _driver.FindElement(By.Id("submit"));

        private IWebElement UserName => _driver.FindElement(By.Id("userName"));
        private IWebElement PermanentAddress => _driver.FindElement(By.Id("permanentAddress"));

    }
}
