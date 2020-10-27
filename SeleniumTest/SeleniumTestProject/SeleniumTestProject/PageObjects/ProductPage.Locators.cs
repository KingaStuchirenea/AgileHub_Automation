using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class ProductPage
    {
        private IWebElement SelectProduct => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[2]"));
        private IWebElement SeeDetails => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div/div/div/div/a"));
        private IWebElement AddToCart => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div/div[2]/a"));
    }
}
