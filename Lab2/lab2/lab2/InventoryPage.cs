using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class InventoryPage : BasePage
    {

        public InventoryPage(IWebDriver driver) : base(driver)
        {

        }

       
        IWebElement add_cart => driver.FindElement(By.XPath("//button[@name='add-to-cart-sauce-labs-backpack']"));

        IWebElement cart_link => driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));

        


        public void click_add_cart()
        {
            add_cart.Click();

        }


        public CartPage click_cart_link()
        {
            cart_link.Click();

            return new CartPage(driver);

        }
    }
}
