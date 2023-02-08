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
    }
}
