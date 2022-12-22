using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_LePendu.Classes
{
    internal class IHM
    {

        #region Déclaration Des Variables Globale
        LePendu pendu;
        bool ok = false;
        #endregion


        public void Start()
        {
            // Nouvelle instance de Pendu
            pendu = new();

            while (pendu.NbreEssais > 0)
            {
                // Affichage des infos de jeu
                Menu(pendu);
                // Récupération de la saisie utilisateur
                PickChar(pendu);
                // Test si la partie est gagnée
                if (pendu.TestWin())
                {
                    Win(pendu);

                    Exit();
                }

                // Attendre que l'utilisateur ai eu les temps de lire le message
                WaitUser();
            }
            Loose(pendu);

            Exit();
        }

        private static void Menu(LePendu p)
        {
            // Affichage des informations de jeux

            Console.WriteLine("-------- Le Jeu du Pendu --------\n");
            Console.WriteLine($"Le mot à trouver : {p.Masque}\n");
            Console.WriteLine($"Il vous reste : {p.NbreEssais} essais\n");

            switch (p.NbreEssais)
            {
                case 10:
                    Console.WriteLine("");
                    break;
                case 9:
                    Console.WriteLine("---");
                    break;
                case 8:
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine("---");
                    break;
                case 7:
                    Console.WriteLine("  _____");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine("---");
                    break;
                case 6:
                    Console.WriteLine("  _____");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine("---");
                    break;
                case 5:
                    Console.WriteLine("  _____");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" |     O");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine("---");
                    break;
                case 4:
                    Console.WriteLine("  _____");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" |     O");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine("---");
                    break;
                case 3:
                    Console.WriteLine("  _____ ");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" |     O");
                    Console.WriteLine(" |    /|");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine("---");
                    break;
                case 2:
                    Console.WriteLine("  _____ ");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" |     O");
                    Console.WriteLine(" |    /|\\");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" | ");
                    Console.WriteLine(" | ");
                    Console.WriteLine("---");
                    break;
                case 1:
                    Console.WriteLine("  _____");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" |     O");
                    Console.WriteLine(" |    /|\\");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" |    /");
                    Console.WriteLine(" | ");
                    Console.WriteLine("---");
                    break;
                case 0:
                    Console.WriteLine("  _____ ");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" |     O");
                    Console.WriteLine(" |    /|\\");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" |    / \\");
                    Console.WriteLine(" | ");
                    Console.WriteLine("---");
                    break;
                default:
                    Console.WriteLine("Erreur affichage du nombre de coup restant...");
                    break;
            }
        }
        
        private static void PickChar(LePendu p)
        {
            char lettre = ' ';
            // Méthode pour la récupération de la saisie utilisateur et convertion en char

            Console.Write("Veuillez saisir une lettre : ");
            while (!char.TryParse(Console.ReadLine(), out lettre))            
                OnRedLine("Erreur, veuillez saisir une lettre : ");

            // Retourne le caractere à la méthode testChar afin de savoir si il est présent dant motATouver
            if (p.TestChar(lettre))
                OnCyan("Bravo! Vous avez trouvé une lettre...");
            else
                OnRed("Et....Non!");
        }

        private static void Loose(LePendu p)
        {
            Menu(p);
            OnRed("\nVous avez perdu...\n");
            Console.WriteLine($"Le mot à trouvé était : {p.MotATrouver}");
        }

        private static void Win(LePendu p)
        {
            OnGreen("\n**************************************\n" +
                $"Vous avez gagné ! \n\n\t Il vous restait {p.NbreEssais} coups!\n\n" +
                $"Le mot à trouver était {p.MotATrouver}\n" +
                "\n**************************************\n");
        }

        private static void OnRed(string message)
        {
            // Méthode pour afficher le message en param de la couleur de la méthode
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        } 
        private static void OnRedLine(string message)
        {
            // Méthode pour afficher le message en param de la couleur de la méthode
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnCyan(string message)
        {
            // Méthode pour afficher le message en param de la couleur de la méthode
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void WaitUser()
        {
            Console.WriteLine("\nAppuyez sur Enter pour proposer une nouvelle lettre...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Exit()
        {
            Console.WriteLine("\nAppuyez sur Enter pour fermer le programme...");
            Console.Read();
            Environment.Exit(0);
        }
    }
}
