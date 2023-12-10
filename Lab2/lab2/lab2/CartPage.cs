using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class CartPage : BasePage
    {

        public CartPage(IWebDriver driver) : base(driver)
        {

        }

        //button[@name='remove-sauce-labs-backpack']


        IWebElement remove => driver.FindElement(By.XPath("//button[@name='remove-sauce-labs-backpack']"));


        

        public CartPage click_remove()
        {
            remove.Click();

            return new CartPage(driver);

        }

        public int number_of_cart_item()
        {
            ReadOnlyCollection<IWebElement> cart_items = driver.FindElements(By.XPath("//div[@class='cart_item']"));

            return cart_items.ToList().Count();
        }
    }
}
