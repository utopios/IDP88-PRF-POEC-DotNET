using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string choix = "-1";
            do
            {
                string pattern = @"^[0-5]{1}$";
                choix = Console.ReadLine();
                Menu();
                while (!Regex.IsMatch(choix, pattern))
                {
                    Console.Write("Veuillez saisir une valeur entre 0 et 5 inclus => ");
                    choix = Console.ReadLine();
                }

                switch (choix)
                {
                    default:
                        break;
                }
            } while (true);
            
            WaitAndClear();
        }

        private void Menu()
        {

        }

        private void WaitAndClear()
        {
            Console.WriteLine("Appuyez sur ENTER pour continuer...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
