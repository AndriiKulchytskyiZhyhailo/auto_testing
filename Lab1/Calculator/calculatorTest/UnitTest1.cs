using CalcClassBr;  
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;

namespace calculatorTest
{

    [TestClass]

    public class UnitTest1
    {

        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-C170MNN;Initial Catalog=UnitTests;Integrated Security=True", "unitTestAdd", DataAccessMethod.Sequential)]
        public void TestMethod—orrectValue()
        {

            long a = Convert.ToInt64(this.TestContext.DataRow["first_number"]);
            long b = Convert.ToInt64(this.TestContext.DataRow["second_number"]);
            var raw_result = this.TestContext.DataRow["result"];
            int? result = null;

            Console.WriteLine(a);
            Console.WriteLine(b);

            result = Convert.ToInt32(raw_result);
            int funct_result = CalcClass.Add(a, b);
            Assert.AreEqual(result, funct_result);

            //Assert.ThrowsException<ArgumentOutOfRangeException>(() => CalcClass.Add(a, b));

        }
        public TestContext TestContext1 { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-C170MNN;Initial Catalog=UnitTests;Integrated Security=True", "unitTestAddIncorectValue", DataAccessMethod.Sequential)]
        public void TestMethodIncorrectValues()
        {

            long a = Convert.ToInt64(this.TestContext.DataRow["first_number"]);
            long b = Convert.ToInt64(this.TestContext.DataRow["second_number"]);

            Console.WriteLine(a);
            Console.WriteLine(b);


            Assert.ThrowsException<ArgumentOutOfRangeException>(() => CalcClass.Add(a, b));

        }


    }

}