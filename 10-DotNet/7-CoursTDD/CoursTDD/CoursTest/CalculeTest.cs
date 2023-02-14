using CoursTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTest
{
    [TestClass]
    public class CalculeTest
    {
        [TestMethod]
        public void WhenAddition_10_30_Then_40()
        {
            //Arrange
            Calcule calcule= new Calcule();

            //Act 
            double result = calcule.Addition(10, 30);

            //Assert
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void WhenDivision_30_10Then_3()
        {
            Calcule calcule= new Calcule();

            double result = calcule.Division(30, 10);

            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void WhenDivision_30_0Then_Exception()
        {
            Calcule calcule = new Calcule();

            //double result = calcule.Division(30, 0);

            //Act est fait en même temps que l'assert 
            Assert.ThrowsException<Exception>(() => calcule.Division(30, 0));

        }
    }
}
