﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class HomePage
    {
       
        
        public void GoToAuthentication()
        {
            AutentificationButton.Click();
        }

        public void GoToSignUp()
        {
            InscriereButton.Click();
        }

    }
}
