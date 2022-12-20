using System;

namespace LesFonctions
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Fonction sans Params et sans retour
            AffichageBienvenue();
            AffichageBienvenue();
            #endregion

            #region Fonction sans Params et avec retour (int)
            Console.WriteLine(AfficherChiffre());
            Console.WriteLine(AfficherMessage());
            #endregion

            #region Fonction Avec Params et sans Retour
            AffichageBienvenue("Anthony", "C#");
            #endregion

            #region Fonction Avec Prams et Avec Retour
            Console.WriteLine(Additionner(25, 14));
            #endregion

            Console.WriteLine("\nAppuyez sur Enter pour fermer le programme...");
            Console.Read();
        }

        // Fonction sans Params et sans retour
        static void AffichageBienvenue()
        {
            Console.WriteLine("\nBonjour\n----------\nBienvenue sur le serveur!\n----------");
        }
        // Fonction sans Params et avec retour(int)
        static int AfficherChiffre()
        {
            int chiffre = 10;
            return chiffre;
        }
        // Fonction sans Params et avec retour (int)
        static string AfficherMessage()
        {
            string chaine = "Salut!";
            return chaine;
        }
        // Fonction Avec Params et sans Retour
        static void AffichageBienvenue(string prenom, string langage)
        {
            Console.WriteLine($"\nBonjour {prenom}\n----------\nVous apprennez le {langage}!\n----------");
        }
        // Fonction Avec Prams et Avec Retour
        static double Additionner(double nb1, double nb2)
        {
            double resultat = nb1 + nb2;
            return resultat;
        }
    }
}







