using Microsoft.VisualStudio.TestTools.UnitTesting;
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
       
        
        public void GoToAuthentication()
        {
            AutentificationButton.Click();
        }
        public void GoToSignUp()
        {
            InscriereButton.Click();
        }
        public void SignOut()
        {
            DeconectareButton.Click();
        }
        public void LaptopuriMenu()
        {
            Laptopuri.Click();
        }
        public void TelefoaneMenu()
        {
            Telefoane.Click();
        }
        public void FotoMenu()
        {
            Foto.Click();
        }
        public void CartiMenu()
        {
            Carti.Click();
        }
        public void AccesoriiMenu()
        {
            Accesorii.Click();
        }
        public void GoToAdministrare()
        {
            AdministrareButton.Click();
        }
        public void GoToUtilizatori()
        {
            UtilizatoriMenu.Click();
        }

        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);
        }

    }
}
