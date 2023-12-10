using lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace Test2
{
    internal class MyTest : BaseTest
    {

        [Test]
        public void remove_test()
        {
            LoginPage login_page = new LoginPage(driver);

            login_page.set_user_name("problem_user");
            login_page.set_password("secret_sauce");
            InventoryPage inv_page = login_page.click_login();

            inv_page.click_add_cart();

            CartPage cart = inv_page.click_cart_link();

            cart.click_remove();


            NUnit.Framework.Assert.AreEqual(cart.number_of_cart_item(), 0);


        }

   

    }
}