using CoursTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTest
{
    [TestClass]
    public class RechercheVilleTest
    {
        private RechercheVille rechercheVille = new RechercheVille();
        [TestMethod]
        public void RechercheTestWhenLess_2_Char_Then_Raise_NotFoundException()
        {
            Assert.ThrowsException<NotFoundException>(() => rechercheVille.Rechercher("a"));
        }

        [TestMethod]
        public void RechercheTestWhenGt_2_Char_Then_Return_Cities_Started_With_Char()
        {
            rechercheVille.Villes = new List<string> { "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York" };
            List<string> result = rechercheVille.Rechercher("Va");

            CollectionAssert.AreEqual(new List<string>() { "Valence", "Vancouver" }, result);
        }

        [TestMethod]
        public void RechercheTest_No_Case_Sensitive()
        {
            rechercheVille.Villes = new List<string> { "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York" };
            List<string> result = rechercheVille.Rechercher("vA");

            CollectionAssert.AreEqual(new List<string>() { "Valence", "Vancouver" }, result);
        }

        [TestMethod]
        public void RechercheTestWhenGt_2_Char_Then_Return_Cities_Contains_With_Char()
        {
            rechercheVille.Villes = new List<string> { "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York" };
            List<string> result = rechercheVille.Rechercher("Er");

            CollectionAssert.AreEquivalent(new List<string>() { "Amsterdam", "Vancouver" }, result);
        }

        [TestMethod]
        public void RechercheTestWhen_Char_Is_Asterisk_Then_Return_All_Cities()
        {
            rechercheVille.Villes = new List<string> { "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York" };
            List<string> result = rechercheVille.Rechercher("*");

            CollectionAssert.AreEquivalent(new List<string> { "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York" }, result);
        }
    }
}
