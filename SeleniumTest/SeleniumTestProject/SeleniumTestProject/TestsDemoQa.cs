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
    class TestsDemoQa: Hooks
    {
        [Test]
        public void AutomationPracticeFormSubmit()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            DemoQa demoQa = new DemoQa(Driver);
            demoQa.PopulatePageAndSubmit();
            Assert.IsTrue(demoQa.ThanksForSubmittingThePAge.Displayed);
        }

        [Test]
        public void TextBoxSubmit()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            DemoQa demoQa = new DemoQa(Driver);
            demoQa.PopulateAndSubmit();
            Thread.Sleep(1000);
            Assert.IsTrue(demoQa.NameDetailsDisplayed.Displayed);
        }
    }
}
