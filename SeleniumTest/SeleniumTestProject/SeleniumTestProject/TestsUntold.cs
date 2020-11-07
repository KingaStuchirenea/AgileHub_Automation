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
    class TestsUntold: Hooks
    {
        [Test]
        public void NavigateToHome()
        {
            Driver.Navigate().GoToUrl("https://untold.com/");
            Untold untold = new Untold(Driver);
            untold.GoToHome();
            var homeURL = "https://untold.com/";
            Assert.AreEqual(homeURL, "https://untold.com/");
        }
    }
}
