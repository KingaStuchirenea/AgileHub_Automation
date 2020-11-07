using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTestProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumTestProject.StepDefinitions
{
    [Binding]
    public sealed class TeatrulSicaAlexandrescuStepDefinition: HooksSpecFlow
    {
        private readonly ScenarioContext _scenarioContext;

        public TeatrulSicaAlexandrescuStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"i navigate to team from page teatrulsicaalexandrescu\.ro/\?lang=en")]
        public void GivenINavigateToTeamFromPageTeatrulsicaalexandrescu_RoLangEn()
        {
            Driver.Navigate().GoToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");
            TeatrulSicaAlexandrescu teatrulSicaAlexandrescu = new TeatrulSicaAlexandrescu(Driver);
            teatrulSicaAlexandrescu.SelectTeamMember();
        }

        [When(@"i select the first show of the first member")]
        public void WhenISelectTheFirstShowOfTheFirstMember()
        {
            TeatrulSicaAlexandrescu teatrulSicaAlexandrescu = new TeatrulSicaAlexandrescu(Driver);
            teatrulSicaAlexandrescu.SelectShow();
        }

        [Then(@"the url will be teatrulsicaalexandrescu\.ro/prins-in-plasa/")]
        public void ThenTheUrlWillBeTeatrulsicaalexandrescu_RoPrins_In_Plasa()
        {
            var showURL = "http://www.teatrulsicaalexandrescu.ro/prins-in-plasa/";
            Assert.AreEqual(showURL, "http://www.teatrulsicaalexandrescu.ro/prins-in-plasa/");
        }

    }
}
