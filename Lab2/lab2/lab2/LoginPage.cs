using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class LoginPage: BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        IWebElement user_name => driver.FindElement(By.XPath("//input[@name='user-name']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@name='password']"));

        IWebElement btn => driver.FindElement(By.XPath("//input[@name='login-button']"));


        



        public void set_user_name(string name) => user_name.SendKeys(name);

        public void set_password(string pass) => password.SendKeys(pass);

        public InventoryPage click_login() {
            btn.Click();
            
            return new InventoryPage(driver);

        }

    }
}
