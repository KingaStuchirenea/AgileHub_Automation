using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class UserPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public UserPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public void GoToEditAUserPage()
        {
            EditButton.Click();
        }

        public void SelectARoleForTheUser(string roleUser)
        {
            SelectElement role = new SelectElement(RoleDropdown);
            role.SelectByText(roleUser);
        }
    }
}
