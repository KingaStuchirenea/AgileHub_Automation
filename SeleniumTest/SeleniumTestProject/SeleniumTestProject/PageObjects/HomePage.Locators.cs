using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            //_driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        }
        public IWebElement AutentificationButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement InscriereButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        private IWebElement VeziDetaliiButton => _driver.FindElement(By.CssSelector(".btn-primary"));
        private IWebElement Laptopuri => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[1]"));
        private IWebElement Telefoane => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[2]"));
        private IWebElement Foto => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[3]"));
        private IWebElement Carti => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[4]"));
        private IWebElement Accesorii => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[5]"));
        private IWebElement AdministrareButton => _driver.FindElement(By.XPath("//a[text()='Administrare']"));
        public IWebElement UtilizatoriMenu => _driver.FindElement(By.XPath("//a[text()='Utilizatori']"));
        public IWebElement ComandaAcumButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[2]/th[4]/a"));

    }
}
