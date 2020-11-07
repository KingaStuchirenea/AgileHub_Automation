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
    class TestsTeatrulSicaAlexandrescu: Hooks
    {
        [Test]
        public void FirstMemberFirstShow()
        {
            Driver.Navigate().GoToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");
            TeatrulSicaAlexandrescu teatrulSicaAlexandrescu = new TeatrulSicaAlexandrescu(Driver);
            teatrulSicaAlexandrescu.SelectTeamMember();
            teatrulSicaAlexandrescu.SelectShow();
            var showURL = "http://www.teatrulsicaalexandrescu.ro/prins-in-plasa/";
            Assert.AreEqual(showURL, "http://www.teatrulsicaalexandrescu.ro/prins-in-plasa/");
        }
    }
}
