using SeleniumTestProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace SeleniumTestProject.StepDefinitions
{
    [Binding]
    public sealed class DemoQaStepDefinition : HooksSpecFlow
    {
        private readonly ScenarioContext _scenarioContext;

        public DemoQaStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"i navigate to page demoqa\.com/automation-practice-form")]
        public void GivenINavigateToPageDemoqa_ComAutomation_Practice_Form()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
        }

        [When(@"i populate all the fields and submit")]
        public void WhenIPopulateAllTheFieldsAndSubmit()
        {
            DemoQa demoQa = new DemoQa(Driver);
            demoQa.PopulatePageAndSubmit();
        }

        [Then(@"thanks for submitting the page text is displayed")]
        public void ThenThanksForSubmittingThePageTextIsDisplayed()
        {
            DemoQa demoQa = new DemoQa(Driver);
            Assert.IsTrue(demoQa.ThanksForSubmittingThePAge.Displayed);
        }

        [Given(@"i navigate to page demoqa\.com/textbox")]
        public void GivenINavigateToPageDemoqa_ComText_Box()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        [When(@"i populate all fields and submit")]
        public void WhenIPopulateAllFieldsAndSubmit()
        {
            DemoQa demoQa = new DemoQa(Driver);
            demoQa.PopulateAndSubmit();
            Thread.Sleep(1000);
        }

        [Then(@"name details are displayed")]
        public void ThenNameDetailsAreDisplayed()
        {
            DemoQa demoQa = new DemoQa(Driver);
            Assert.IsTrue(demoQa.NameDetailsDisplayed.Displayed);
        }






    }
}
