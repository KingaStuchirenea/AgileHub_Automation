using NUnit.Framework;
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



    }
}
