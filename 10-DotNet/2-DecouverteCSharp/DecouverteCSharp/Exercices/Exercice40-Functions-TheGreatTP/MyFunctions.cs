using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercice39_TheGreatTP_PRF2022
{
    internal class MyFunctions
    {
        public void MainMenu()
        {
            // Affichage du menu
            Console.WriteLine("----- Le grand tirage au sort -----\n");
            Console.WriteLine("1-- Effectuer un tirage ");
            Console.WriteLine("2-- Voir la liste des personnes déjà tirées");
            Console.WriteLine("3-- Voir la liste des personnes restantes");
            Console.WriteLine("\n0--- Quitter");
        }

        public static void DisplayWinner(string element, string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n**********************************{chaine}");
            Console.WriteLine($"***** L'heureux gagnant est {element} *****");
            Console.WriteLine($"**********************************{chaine}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DrawLots(ref int compteur, string[] Origine, string[] Tiree)
        {
            string element;
            int index;
            string chaine = "";
            if (compteur < Origine.Length)
            {
                do
                {
                    index = GenerateNumber(0, Origine.Length);
                    element = Origine[index];

                } while (element == null);
                foreach (char c in element)
                    chaine += "*";

                DisplayWinner(element, chaine);

                Tiree[compteur++] = element;
                Origine[index] = null;
            }
            else
            {
                compteur = 0;
                for (int i = 0; i < Origine.Length; i++)
                {
                    Origine[i] = Tiree[i];
                    Tiree[i] = null;
                }
            }
        }

        public string GetUserValue(string possibleValues)
        {
            string choice = "-1";
            while (!possibleValues.Contains(choice))
            {
                Console.Write("\nVotre choix (0,1,2,3) => ");
                choice = Console.ReadLine();
            }
            return choice;
        }

        public static int GenerateNumber(int minValue, int maxValue)
        {
            Random r = new Random();
            return r.Next(minValue, maxValue);
        }

        public void DisplayArray(string[] array, string message, string color)
        {
            string chaine = "";
            Console.ForegroundColor = color == "green" ? ConsoleColor.Green : color == "red" ? ConsoleColor.Red : ConsoleColor.Cyan;
            string space = (color == "cyan") ? "****" : "";
            Console.WriteLine($"*******************************************{space}");
            Console.WriteLine($"***** {message} *****");
            Console.WriteLine($"*******************************************{space}");
            Console.ForegroundColor = ConsoleColor.White;
            if (array.Length > 0)
            {
                foreach (string nom in array)
                {
                    if (nom != null)
                    {
                        Console.WriteLine(chaine + nom);
                        chaine += "   ";
                    }
                }
            }
            else
                Console.WriteLine("\n\nAucune personne dans la liste,\n\n\tVeuillez faire un tirage...\n\n");


            Console.WriteLine("\nAppuyez sur ENTER pour retourner au menu principal...");
            Console.Read();
            Console.Clear();
        }
    }
}
