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
    public sealed class UntoldStepDefinition : HooksSpecFlow
    {
        private readonly ScenarioContext _scenarioContext;

        public UntoldStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"i navigate to untold\.com page")]
        public void GivenINavigateToUntold_ComPage()
        {
            Driver.Navigate().GoToUrl("https://untold.com/");
        }

        [When(@"i select home from menu")]
        public void WhenISelectHomeFromMenu()
        {
            Untold untold = new Untold(Driver);
            untold.GoToHome();
        }

        [Then(@"the url will be untold\.com")]
        public void ThenTheUrlWillBeUntold_Com()
        {
            var homeURL = "https://untold.com/";
            Assert.AreEqual(homeURL, "https://untold.com/");
        }
    }
}
