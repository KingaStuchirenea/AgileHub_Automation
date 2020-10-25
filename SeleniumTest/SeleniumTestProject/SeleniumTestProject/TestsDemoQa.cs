using NUnit.Framework;
using SeleniumTestProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject
{
    [TestFixture]
    class TestsDemoQa: Hooks
    {
        [Test]
        public void AutomationPracticeFormSubmit()
        {
            DemoQa demoQa = new DemoQa(Driver, "https://demoqa.com/automation-practice-form");
            demoQa.PopulatePageAndSubmit();
        }

        [Test]
        public void TextBoxSubmit()
        {
            DemoQa demoQa = new DemoQa(Driver, "https://demoqa.com/text-box");
            demoQa.PopulateAndSubmit();
        }
    }
}
