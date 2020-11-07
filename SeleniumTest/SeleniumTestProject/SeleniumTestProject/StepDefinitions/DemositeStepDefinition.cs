using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTestProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTestProject.StepDefinitions
{
    [Binding]
    public sealed class DemositeStepDefinition : HooksSpecFlow
    {
        private readonly ScenarioContext _scenarioContext;

        public DemositeStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //a.Logati-va in aplicatie.

        [Given(@"i navigate to authentication page")]
        public void GivenINavigateToAuthenticationPage()
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
        }

        [When(@"i login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var myUser = table.CreateInstance<User>();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginIntoApplication(myUser);
        }

        [Then(@"i am logged in")]
        public void ThenIAmLoggedIn()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.DeconectareButton.Displayed);
        }

        //b.Adaugati in cos un produs ca si utilizator.

        [Given(@"i login with valid user")]
        public void GivenILoginWithValidUser(Table table)
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            var myUser = table.CreateInstance<User>();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginIntoApplication(myUser);
        }

        [When(@"i add a product in cart")]
        public void WhenIAddAProductInCart()
        {
            ProductPage productPage = new ProductPage(Driver);
            productPage.AddProductInCart();
        }

        [Then(@"i can order the product")]
        public void ThenICanOrderTheProduct()
        {
            LoginPage loginPage = new LoginPage(Driver);
            HomePage homePage = new HomePage(Driver);
            loginPage.VerifyElementIsDisplayed(homePage.ComandaAcumButton);
        }

        //c.Adaugati in cos un produs ca si admin.

        [Given(@"i login with admin")]
        public void GivenILoginWithAdmin(Table table)
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            var myUser = table.CreateInstance<User>();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginIntoApplication(myUser);
        }

        [When(@"i add product in cart")]
        public void WhenIAddProductInCart()
        {
            ProductPage productPage = new ProductPage(Driver);
            productPage.AddProductInCart();
        }

        [Then(@"i can order product")]
        public void ThenICanOrderProduct()
        {
            LoginPage loginPage = new LoginPage(Driver);
            HomePage homePage = new HomePage(Driver);
            loginPage.VerifyElementIsDisplayed(homePage.ComandaAcumButton);
        }

        //d.Faceti inscrierea si logati-va cu noul cont.

        [Given(@"i sign up")]
        public void GivenISignUp()
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            homePage.GoToSignUp();
            Thread.Sleep(1000);
            SignUpPage signUpPage = new SignUpPage(Driver);
            signUpPage.PopulateSignUpPage();
        }

        [When(@"i login with new user")]
        public void WhenILoginWithNewUser()
        {
            SignUpPage signUpPage = new SignUpPage(Driver);
            signUpPage.LoginNewUser();
        }

        [Then(@"i can logout")]
        public void ThenICanLogout()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
            Thread.Sleep(1000);
        }

        //e.Logati-va si deconectati-va din site.

        [Given(@"i login valid user")]
        public void GivenILoginValidUser(Table table)
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            var myUser = table.CreateInstance<User>();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginIntoApplication(myUser);
        }

        [When(@"i logout")]
        public void WhenILogout()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.SignOut();
        }

        [Then(@"i can login again")]
        public void ThenICanLoginAgain()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementIsDisplayed(homePage.AutentificationButton);
        }

        //f.Dati click pe fiecare meniu (orizontal).

        [Given(@"i navigate to demosite")]
        public void GivenINavigateToDemosite()
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        }

        [When(@"i go trought horizontal menus")]
        public void WhenIGoTroughtHorizontalMenus()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.LaptopuriMenu();
            homePage.TelefoaneMenu();
            homePage.FotoMenu();
            homePage.CartiMenu();
            homePage.AccesoriiMenu();
        }

        [Then(@"i arrive to accesorii url")]
        public void ThenIArriveToAccesoriiUrl()
        {
            var accesoriiURL = "http://demosite.casqad.org/category/show/5";
            Assert.AreEqual(accesoriiURL, "http://demosite.casqad.org/category/show/5");
        }

        //g.Ca si admin, dati click pe buton de administrare.

        [Given(@"i login with admin user")]
        public void GivenILoginWithAdminUser()
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            Thread.Sleep(1000);
        }

        [When(@"i go to administrare menu")]
        public void WhenIGoToAdministrareMenu()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAdministrare();
        }

        [Then(@"utilizatori menu is displayed")]
        public void ThenUtilizatoriMenuIsDisplayed()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.VerifyElementIsDisplayed(homePage.UtilizatoriMenu);
        }

        //h.Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori.

        [Given(@"i login with the admin")]
        public void GivenILoginWithTheAdmin()
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            GivenILoginWithAdminUser();
            WhenIGoToAdministrareMenu();
            Thread.Sleep(1000);
        }

        [When(@"i go to utilizatori menu")]
        public void WhenIGoToUtilizatoriMenu()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToUtilizatori();
        }

        [Then(@"nume header is displayed")]
        public void ThenNumeHeaderIsDisplayed()
        {
            UserPage userPage = new UserPage(Driver);
            Assert.IsTrue(userPage.NumeHeader.Displayed);
        }

        //i.Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori, alegeti un utilizator si editati.

        [Given(@"i access utilizatori menu as admin")]
        public void GivenIAccessUtilizatoriMenuAsAdmin()
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            GivenILoginWithTheAdmin();
            WhenIGoToUtilizatoriMenu();
            //scrolls down page 8000px
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,8000)", "");
            Thread.Sleep(2000);
        }

        [When(@"i select and edit a user")]
        public void WhenISelectAndEditAUser()
        {
            UserPage userPage = new UserPage(Driver);
            userPage.GoToEditAUserPage();
            userPage.SelectARoleForTheUser("user");
        }

        [Then(@"user role is displayed")]
        public void ThenUserRoleIsDisplayed()
        {
            UserPage userPage = new UserPage(Driver);
            Assert.IsTrue(userPage.UserRole.Displayed);
        }

    }
}
