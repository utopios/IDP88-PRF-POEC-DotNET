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

            Console.WriteLine("Le jeu est démarré!");
        }

        private static void Menu(LePendu p)
        {
            // Méthode affichant le menu pour jouer
        }

        private static void PickChar(LePendu p)
        {
            // Méthode pour la récupération de la saisie utilisateur
        }

        private static void Loose(LePendu p)
        {
            // Méthode pour indiquer que la partie est perdu
        }

        private static void Win(LePendu p)
        {
            // Méthode pour indiquer que la partie est gagnée
        }

        private static void OnRed(string message)
        {
            // Méthode pour afficher le message en param de la couleur de la méthode
        } 
        
        private static void OnGreen(string message)
        {
            // Méthode pour afficher le message en param de la couleur de la méthode
        }

        private static void OnCyan(string message)
        {
            // Méthode pour afficher le message en param de la couleur de la méthode
        }

        private static void WaitUser()
        {
            Console.WriteLine("Appuyez sur Enter pour proposer une nouvelle lettre...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Exit()
        {
            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
            Environment.Exit(0);
        }
    }
}
