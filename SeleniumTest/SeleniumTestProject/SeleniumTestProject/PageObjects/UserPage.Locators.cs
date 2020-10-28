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
    }
}
