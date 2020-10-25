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
    class TestsGooglePage : Hooks
    {
        [Test]
        public void GoogleSearchPic()
        {
            HomePageGoogle homePageGoogle = new HomePageGoogle(Driver);
            homePageGoogle.SearchInGoogle("paris");
            homePageGoogle.SearchImagesFirstPicture();
        }
        
    }
}
