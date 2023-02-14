using CoursTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTest
{
    [TestClass]
    public class GradingCalculatorTest
    {
        private GradingCalculator gradingCalculator;
        
        
        [TestMethod]
        public void WhenGetGrade_95_90_Then_A()
        {
            //GradingCalculator gradingCalculator = new GradingCalculator()
            //{
            //    Score = 95,
            //    AttendancePercentage = 90
            //};

            SetUp(95, 90);

            char c = gradingCalculator.GetGrade();

            Assert.AreEqual('A', c);
        }

        [TestMethod]
        public void WhenGetGrade_85_90_Then_B()
        {           
            SetUp(85, 90);
            char c = gradingCalculator.GetGrade();
            Assert.AreEqual('B', c);
        }

        [TestMethod]
        public void WhenGetGrade_65_90_Then_C()
        {
            SetUp(65, 90);
            char c = gradingCalculator.GetGrade();
            Assert.AreEqual('C', c);
        }

        [TestMethod]
        public void WhenGetGrade_95_65_Then_B()
        {
            SetUp(95, 65);
            char c = gradingCalculator.GetGrade();
            Assert.AreEqual('B', c);
        }

        [TestMethod]
        public void WhenGetGrade_95_55_Then_F()
        {
            SetUp(95, 55);
            char c = gradingCalculator.GetGrade();
            Assert.AreEqual('F', c);
        }

        [TestMethod]
        public void WhenGetGrade_65_55_Then_F()
        {
            SetUp(65, 55);
            char c = gradingCalculator.GetGrade();
            Assert.AreEqual('F', c);
        }
        [TestMethod]
        public void WhenGetGrade_50_90_Then_F()
        {
            SetUp(50, 90);
            char c = gradingCalculator.GetGrade();
            Assert.AreEqual('F', c);
        }

        private void SetUp(int s, int p)
        {
            gradingCalculator = new GradingCalculator()
            {
                Score = s,
                AttendancePercentage = p
            };
        }
    }
}
