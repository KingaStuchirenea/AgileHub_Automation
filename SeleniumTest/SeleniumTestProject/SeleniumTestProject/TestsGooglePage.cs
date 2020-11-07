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
    class TestsGooglePage : Hooks
    {
        [Test]
        public void GoogleSearchPic()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");
            HomePageGoogleDriver homePageGoogle = new HomePageGoogleDriver(Driver);
            homePageGoogle.SearchInGoogle("paris");
            homePageGoogle.SearchImagesFirstPicture();
            Assert.IsTrue(homePageGoogle.firstPic.Displayed);
        }
        
    }
}
