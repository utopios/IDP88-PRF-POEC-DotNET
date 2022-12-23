using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEnums
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            Saison a = Saison.Hiver;
            Console.WriteLine($"La valeur numérique de {a} est {(int)a}");

            var b = (Saison)1;
            Console.WriteLine(b);
            
            Saison c = (Saison)0;
            Console.WriteLine(c);



            Console.WriteLine("\nAppuyez sur enter pour fermer le programme");
            Console.Read();
        }

        public enum Saison
        {
            Printemps,//0
            Eté,//1
            Automne,//2
            Hiver//3
        }

    }
}
