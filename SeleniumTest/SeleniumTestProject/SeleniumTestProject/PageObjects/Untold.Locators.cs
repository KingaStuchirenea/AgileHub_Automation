using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class Untold
    {
        private IWebElement Menu => _driver.FindElement(By.XPath("//*[@id='untold-container']/header/div[2]/div[3]/div/button"));
        private IWebElement Home => _driver.FindElement(By.XPath("//*[@id='untold-container']/header/div[2]/div[2]/div[1]/nav/div[1]/a[1]"));
    }
}
