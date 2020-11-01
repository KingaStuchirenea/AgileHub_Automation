using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class UserPage
    {
        private IWebElement EditButton => _driver.FindElement(By.XPath("//a[@href='/user/edit/168']"));
        private IWebElement RoleDropdown => _driver.FindElement(By.CssSelector("select[name=role]"));
        public IWebElement NumeHeader => _driver.FindElement(By.XPath("/html/body/div/div/div/table/thead/tr/th[2]"));
        public IWebElement UserRole => _driver.FindElement(By.XPath("/html/body/div/form/div/div[2]/div[1]/select/option[1]"));
    }
}
