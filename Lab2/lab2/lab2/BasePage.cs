﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class BasePage
    {

        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
                this.driver = driver;
        }

    }
}