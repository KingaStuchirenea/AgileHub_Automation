﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class ProductPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void AddProductInCart()
        {
            SelectProduct.Click();
            SeeDetails.Click();
            AddToCart.Click();
        }
    }
}
