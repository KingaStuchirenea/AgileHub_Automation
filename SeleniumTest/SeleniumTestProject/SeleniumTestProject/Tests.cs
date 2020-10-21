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

        [Test]
        public void MySecondTest()
        {
            Thread.Sleep(1000);

        }

        [Test]
        public void MyThirdTest()
        {
            Thread.Sleep(1000);
        }
    }
}
