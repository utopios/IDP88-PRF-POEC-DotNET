using CoursTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTest
{
    [TestClass]
    public class Exercice3Test
    {
        private Exercice3 ex = new Exercice3();
        [TestMethod]
        public void TestLeap_400_Should_True()
        {
            bool res = ex.IsLeap(1200);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestLeap_4_Not_100_Should_True()
        {
            bool res = ex.IsLeap(12);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestLeap_4000_Should_False()
        {
            bool res = ex.IsLeap(8000);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void TestLeap_1999_Should_False()
        {
            bool res = ex.IsLeap(1999);
            Assert.IsFalse(res);
        }
    }
}
