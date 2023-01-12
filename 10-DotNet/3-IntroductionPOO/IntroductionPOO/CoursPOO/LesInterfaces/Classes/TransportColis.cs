using System;
using System.Collections.Generic;
using System.Text;

namespace LesInterfaces.Classes
{
    class TransportColis
    {
        private IVolant volant;

        public TransportColis(IVolant v)
        {
            volant = v;
        }

        public void Transporter()
        {
            volant.Voler();
            Console.WriteLine("Et je livre des colis !");
        }

        public void livrer()
        {
            volant.Attrerrir();
        }
    }
}
