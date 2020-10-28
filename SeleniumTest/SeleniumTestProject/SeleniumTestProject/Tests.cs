using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestProject
{
    [TestFixture]
    class Tests : Hooks
    {
        //[Test, Category("Login")]
        [Test]
        public void ValidareLoginIntoApplicationWithValidCredentials()
        {
            // Arrange
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            Thread.Sleep(1000);
            // Act
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            Thread.Sleep(1000);
            // Assert
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
            Thread.Sleep(1000);
        }

        //[Test]
        //public void SignUp()
        //{
        //    // Arrange
        //    HomePage homePage = new HomePage(Driver);
        //    homePage.GoToSignUp();
        //    Thread.Sleep(1000);
        //    // Act
        //    Thread.Sleep(1000);
        //    // Assert
        //    Thread.Sleep(1000);
        //}

        [Test]
        public void LoginUser()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("john.miller@xyz.com", "!123John");
            Thread.Sleep(1000);
        }

        [Test]
        public void AddProductInCartAsUser()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("john.miller@xyz.com", "!123John");
            Thread.Sleep(1000);
            ProductPage productPage = new ProductPage(Driver);
            productPage.AddProductInCart();
        }

        [Test]
        public void AddProductInCartAsAdmin()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            Thread.Sleep(1000);
            ProductPage productPage = new ProductPage(Driver);
            productPage.AddProductInCart();
        }

        [Test]
        public void SignUpAndLogin()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToSignUp();
            Thread.Sleep(1000);
            SignUpPage signUpPage = new SignUpPage(Driver);
            signUpPage.PopulateSignUpPage();
            signUpPage.LoginNewUser();
        }

        [Test]
        public void LogInLogOut()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("john.miller@xyz.com", "!123John");
            Thread.Sleep(1000);
            homePage.SignOut();
        }

        [Test]
        public void GoTroughtOrizontalMenus()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.LaptopuriMenu();
            homePage.TelefoaneMenu();
            homePage.FotoMenu();
            homePage.CartiMenu();
            homePage.AccesoriiMenu();
        }

        [Test]
        public void AsAdminOpenAdministrare()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            Thread.Sleep(1000);
            homePage.GoToAdministrare();
        }

        [Test]
        public void AsAdminOpenUtilizatori()
        {
            HomePage homePage = new HomePage(Driver);
            AsAdminOpenAdministrare();
            Thread.Sleep(1000);
            homePage.GoToUtilizatori();
        }

        [Test]
        public void AsAdminEditUser()
        {
            AsAdminOpenUtilizatori();
            //scrolls down page 8000px
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,8000)", "");
            Thread.Sleep(2000);
            UserPage userPage = new UserPage(Driver);
            userPage.GoToEditAUserPage();
            userPage.SelectARoleForTheUser("user");
        }

    }
}
