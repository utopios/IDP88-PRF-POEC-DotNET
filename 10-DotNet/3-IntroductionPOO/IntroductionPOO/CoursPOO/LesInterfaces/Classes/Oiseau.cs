using System;
using System.Collections.Generic;
using System.Text;

namespace LesInterfaces.Classes
{
    class Oiseau : IVolant
    {
        public void Attrerrir()
        {
            Console.WriteLine("J'atterris... comme je peux!");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle depuis la branche d'un arbre");
        }

        public void Voler()
        {
            Console.WriteLine("Je peux voler grâce à des ailes");
        }
    }
}
