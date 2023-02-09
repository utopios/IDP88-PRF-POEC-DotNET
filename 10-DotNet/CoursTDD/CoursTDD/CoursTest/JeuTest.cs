using CoursTDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTest
{
    [TestClass]
    public class JeuTest
    {
        [TestMethod]
        public void JouerTestWin()
        {
            //Jeu jeu = new Jeu(new FakeDeWin());
            IDe de = Mock.Of<IDe>();
            Mock.Get(de).Setup((de) => de.Lancer()).Returns(20);
            Jeu jeu = new Jeu(de);
            bool res = jeu.Jouer();

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void JouerTestLose()
        {
            //Jeu jeu = new Jeu(new FakeDeLose());
            IDe de = Mock.Of<IDe>();
            Mock.Get(de).Setup((de) => de.Lancer()).Returns(10);
            Jeu jeu = new Jeu(de);
            bool res = jeu.Jouer();

            Assert.IsFalse(res);
        }
    }
}
