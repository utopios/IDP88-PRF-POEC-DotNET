using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme.Classes
{
    internal class Parametriques
    {
        public static int Additionner( int a, int b)
        {
            return a + b;
        }

        public static string Additionner(string a, string b)
        {
            double resultat = Convert.ToDouble(a) + Convert.ToDouble(b);
            return $"Le résultat est {resultat}";
        }
    }
}
