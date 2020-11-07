using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class HomePageGoogleDriver
    {
        private IWebElement googleTextBoxField => _driver.FindElement(By.CssSelector("input[name='q']"));
        private IWebElement searchButton => _driver.FindElement(By.CssSelector("input[value='Google Search' and div:nth-child(2)]"));
        private IWebElement suntDeAcordButton => _driver.FindElement(By.CssSelector("div[id='introAgreeButton']"));
        private IWebElement imaginiButton => _driver.FindElement(By.CssSelector("div#hdtb-msb-vis>div:nth-of-type(2)>a"));
        public IWebElement firstPic => _driver.FindElement(By.XPath("//img[@alt='Paris - Wikipedia']"));
        //public IWebElement imagesButton => _driver.FindElement(By.XPath("//*[@id='yDmH0d']/div[2]/c-wiz/div[1]/div/div[1]/div[1]/div/div/span"));
        
    }
}
