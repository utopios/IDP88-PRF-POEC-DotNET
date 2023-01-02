using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.IHM
{
    internal class IHM
    {
        public void Start()
        {
            Console.WriteLine("Start...");
            WaitUser();
        }

        public void WaitUser()
        {
            Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
            Console.Read();
        }
    }
}
