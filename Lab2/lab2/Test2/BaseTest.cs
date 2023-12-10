using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Test2
{
    public class BaseTest
    {
        protected IWebDriver? driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        }

        [TearDown]
        public void TearDown()
        {
            //driver.Close();


        }

    }
}