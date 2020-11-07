using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTestProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist; //de adaugat


namespace SeleniumTestProject.StepDefinitions
{
    [Binding]
    public class AuthenticationStepDefinition: HooksSpecFlow
    {
        private readonly ScenarioContext _scenarioContext;
        public AuthenticationStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //[Given(@"I login with valid user")]
        //public void GivenILoginWithValidUser()
        //{
        //    HomePage myHomePage = new HomePage(Driver);
        //    myHomePage.GoToAuthentication();
        //    LoginPage myLoginPage = new LoginPage(Driver);
        //    myLoginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
        //    Assert.IsTrue(myHomePage.DeconectareButton.Displayed);
        //}

        [Given(@"I navigate authentication page")]
        public void GivenINavigateAuthenticationPage()
        {
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();
        }

        [When(@"I login with following credentials:")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var myUser = table.CreateInstance<User>();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginIntoApplication(myUser);
        }

        //[When(@"I login with user '(.*)'")]
        //public void WhenILoginWithUser(string userEmailAddress)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    loginPage.EmailFieldTextBox.SendKeys(userEmailAddress); //trebuie pusi locatorii publici
        //}

        //[When(@"password '(.*)'")]
        //public void WhenPassword(string userPassword)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    loginPage.PasswordFieldTextBox.SendKeys(userPassword);  //trebuie pusi locatorii publici
        //    loginPage.AuthenticateButtonLoginPagr.Click();  //trebuie pusi locatorii publici
        //}

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.DeconectareButton.Displayed);
        }

    }
}
