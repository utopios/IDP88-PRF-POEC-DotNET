using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpBanqueBaseClass.Class;

namespace TpBanqueIHMConsole.Class
{
    internal class IHM
    {
        public IHM()
        {
            Client c = new();
        }

        public void Start()
        {

            WaitAndClear();
        }

        public void WaitAndClear()
        {
            Console.WriteLine("Appuyez sur ENTER pour continuer...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
