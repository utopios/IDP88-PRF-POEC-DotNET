using System;
using System.Collections.Generic;
using System.Text;

namespace LesInterfaces.Classes
{
    class Drone : IVolant
    {
        public void Attrerrir()
        {
            Console.WriteLine("J'atteris à la verticale... ou sur les gens!");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle à la verticale");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole tout seul");
        }
    }
}
