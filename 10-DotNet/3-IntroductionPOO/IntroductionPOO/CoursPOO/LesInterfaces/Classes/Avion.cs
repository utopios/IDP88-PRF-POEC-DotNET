using System;
using System.Collections.Generic;
using System.Text;

namespace LesInterfaces.Classes
{
    class Avion : IVolant
    {
        public void Attrerrir()
        {
            Console.WriteLine("J'attéris sur une piste");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle depuis une piste");

        }

        public void Voler()
        {
            Console.WriteLine("Je peux voler grâce à des réacteurs");
        }
    }
}
