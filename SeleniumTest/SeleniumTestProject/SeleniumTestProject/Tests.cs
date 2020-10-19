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
    class Tests : Hooks
    {
        [Test]
        public void MyFirstTest()
        {
            HomePage myPage = new HomePage(Driver);
            myPage.AutentificationButton.Click();
            Thread.Sleep(1000);
        }

        [Test]
        public void MySecondTest()
        {
            Thread.Sleep(1000);
        }

        [Test]
        public void MyThirdTest()
        {
            Thread.Sleep(1000);
        }
    }
}
