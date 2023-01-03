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

        public void ActionNotificationADecouvert(decimal solde, int compte)
        {
            OnRed($"\n Le compte numéro {compte} est à découvert ! ");
            Console.Write("\n\t\tVoici le nouveau solde : ");
            OnRed($"{solde}€");
        }

        public void OnDarkCyan(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void OnDarkCyanInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void OnCyanInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void OnRed(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void OnGrayInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void OnGreen(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void WaitAndClear()
        {
            Console.WriteLine("Appuyez sur ENTER pour continuer...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
