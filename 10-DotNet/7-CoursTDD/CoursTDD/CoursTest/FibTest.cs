using CoursTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTest
{
    [TestClass]
    public class FibTest
    {
        private Fib fib;

        private void SetUp(int r)
        {
            fib = new Fib(r);
        }

        [TestMethod]
        public void GetFibSeriesTestWhen_1_ThenNotEmpty()
        {
            SetUp(1);
            //Act
            List<int> result = fib.GetFibSeries();
            Assert.AreEqual(1, result.Count);
        }
        [TestMethod]
        public void GetFibSeriesTestWhen_1_ThenResultContains_0()
        {
            SetUp(1);
            List<int> expected = new() { 0 };
            //Act
            List<int> result = fib.GetFibSeries();
            
            //Assert.ReferenceEquals(expected, result) ;
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetFibSeriesTestWhen_Range_6_ThenResultContains_3()
        {
            SetUp(6);
            
            //Act
            List<int> result = fib.GetFibSeries();

            Assert.IsTrue(result.Contains(3)) ;
            
        }

        [TestMethod]
        public void GetFibSeriesTestWhen_Range_6_ThenResultCount_6()
        {
            SetUp(6);

            //Act
            List<int> result = fib.GetFibSeries();

            Assert.AreEqual(6, result.Count);

        }
        [TestMethod]
        public void GetFibSeriesTestWhen_Range_6_ThenResultDontContains_4()
        {
            SetUp(6);

            //Act
            List<int> result = fib.GetFibSeries();

            Assert.IsFalse(result.Contains(4));

        }

        [TestMethod]
        public void GetFibSeriesTestWhen_Range_6_ThenResultIsSorted()
        {
            SetUp(6);
            List<int> expected = new() { 0, 1, 1, 2, 3, 5 };
            //Act
            List<int> result = fib.GetFibSeries();

            CollectionAssert.AreEqual(expected, result);

        }

    }
}
