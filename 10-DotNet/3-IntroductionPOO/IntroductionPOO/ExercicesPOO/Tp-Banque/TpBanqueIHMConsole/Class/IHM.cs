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
        private Bank banque;
        public IHM()
        {
            Init();
        }       

        private void Init()
        {
            banque = new();
            banque.Injecter();
        }

        public void Start()
        {

            WaitAndClear();
        }

        private void WaitAndClear()
        {
            Console.WriteLine("Appuyez sur ENTER pour continuer...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
