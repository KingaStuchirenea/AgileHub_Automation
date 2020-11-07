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
    public class GooglePageStepDefinition : HooksSpecFlow
    {
        private readonly ScenarioContext _scenarioContext;
        public GooglePageStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"i search for paris on google homepage")]
        public void GivenISearchForParisOnGoogleHomepage()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");
            HomePageGoogleDriver homePageGoogle = new HomePageGoogleDriver(Driver);
            homePageGoogle.SearchInGoogle("paris");
        }

        [When(@"i go to images first picture and back")]
        public void WhenIGoToImagesFirstPictureAndBack()
        {
            HomePageGoogleDriver homePageGoogle = new HomePageGoogleDriver(Driver);
            homePageGoogle.SearchImagesFirstPicture();
        }

        [Then(@"the first picture with paris is displayed")]
        public void ThenTheFirstPictureWithParisIsDisplayed()
        {
            HomePageGoogleDriver homePageGoogle = new HomePageGoogleDriver(Driver);
            Assert.IsTrue(homePageGoogle.firstPic.Displayed);
        }
    }
}
