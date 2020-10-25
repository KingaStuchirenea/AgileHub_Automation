using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class TeatrulSicaAlexandrescu
    {
        private IWebElement SelectTeam => _driver.FindElement(By.XPath("//*[@id='menu-item-2914']/a/span[2]"));
        private IWebElement SelectMember => _driver.FindElement(By.XPath("//*[@id='av-masonry-1-item-2697']"));
        private IWebElement SelectFirstShow => _driver.FindElement(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]"));

    }
}
