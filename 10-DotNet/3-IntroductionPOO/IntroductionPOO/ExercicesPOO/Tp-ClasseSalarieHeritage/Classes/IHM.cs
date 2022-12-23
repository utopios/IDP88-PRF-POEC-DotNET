using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpClassSalarie.Classes;

namespace Tp_ClasseSalarieHeritage.Classes
{
    internal class IHM
    {
        private Salarie[] employes;
        private int maxEmployes = 20;

        public IHM()
        {
            employes = new Salarie[maxEmployes];
        }

        public void Start()
        {
            string choix="";

            do
            {
                switch (choix)
                {
                    default:
                        break;
                }
            } while (choix != "0");
        }
    }
}