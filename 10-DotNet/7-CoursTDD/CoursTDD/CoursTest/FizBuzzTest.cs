using CoursTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTest
{
    [TestClass]
    public class FizBuzzTest
    {
        private FizBuzz fizBuzz;

        [TestMethod]
        public void TestFizBuzzWhenNumer_3_Then_Fiz()
        {
            fizBuzz = new FizBuzz(3);

            string result = fizBuzz.Run();

            Assert.AreEqual("fiz", result);
        }

        [TestMethod]
        public void TestFizBuzzWhenNumer_5_Then_Buzz()
        {
            fizBuzz = new FizBuzz(10);

            string result = fizBuzz.Run();

            Assert.AreEqual("buzz", result);
        }
        [TestMethod]
        public void TestFizBuzzWhenNumer_5_3_Then_FizBuzz()
        {
            fizBuzz = new FizBuzz(15);

            string result = fizBuzz.Run();

            Assert.AreEqual("fizbuzz", result);
        }

        [TestMethod]
        public void TestFizBuzzWhenNumer_Other_Then_number()
        {
            fizBuzz = new FizBuzz(26);

            string result = fizBuzz.Run();

            Assert.AreEqual("26", result);
        }
    }
}
