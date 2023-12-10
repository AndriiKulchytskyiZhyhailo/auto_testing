using lab2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class MyTest: BaseTest
    {

        [Test]
        public void remove_test()
        {
            LoginPage login_page = new LoginPage(driver);

            login_page.set_user_name("problem_user");
            login_page.set_password("secret_sauce");
            InventoryPage inv_page = login_page.click_login();

            inv_page.click_add_cart();

            CartPage cart = inv_page.Click_cart_link();

            cart.click_remove();

            Assert.ThrowsException<OpenQA.Selenium.NoSuchElementException>(() => cart.click_remove());

            
        }

    }
}
