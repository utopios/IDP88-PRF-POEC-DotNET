using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteConsole
{
    public class Start
    {
        public static void Main(string[] args)
        {
            #region Affichage dans la console
            // Affiche le message sans retour à la ligne
            Console.Write("Je m'affiche...");
            Console.Write("sans retour à ligne!");

            // Affiche le message dans la console avec un retour à la ligne
            Console.WriteLine("J'ai un retour à la ligne...");
            Console.WriteLine("La preuve!");

            #endregion

            #region Lecture saisies utilisateur
            // Afficher un lessage a l'utilisateur
            //Console.Write("Veuillez saisir une chaîne de caractères : ");
            //// Lire un caractere dans la console => Console.Read();
            //char @char = (char)Console.Read();
            //// Afficher le contenu de ma variable @char
            //Console.WriteLine(@char);

            //// Lire une chaine de caractères depuis le flux clavier
            //string maChaine1 = Console.ReadLine();
            //Console.Write("Veuillez saisir une autre chaîne de caractères : ");
            //string maChaine2 = Console.ReadLine();
            //Console.Write("Veuillez saisir une derniere chaîne de caractères : ");
            //string maChaine3 = Console.ReadLine();
            //// Afficher le contenu de ma variable maChaine
            //Console.WriteLine(maChaine1);

            //// Surcharge de Méthode WriteLine(string Format, object obj1,object obj2,object obj3)
            //Console.WriteLine("Je formate ma chaine avec {0} et avec {1} et avec {2}", maChaine1, maChaine2, maChaine3);

            #endregion

            #region Changement de Couleur dans la console
            // Couleur de police
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Je suis en vert");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Je suis en rouge");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Je suis en gray");
            Console.ForegroundColor = ConsoleColor.White;
            // Couleur de fond
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Mon fond est Vert");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Mon fond est Rouge");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Mon fond est Gris Foncé");
            Console.BackgroundColor = ConsoleColor.Black;
            #endregion

            #region Les caractères spéciaux
            Console.WriteLine("\nLes caractères spéciaux\n");

            // Afficher un chemin d'accès dans la console
            Console.WriteLine("c:\\repertoire\\MonFichier.cs");
            Console.WriteLine(@"c:\repertoire\MonFichier.cs");

            // Le \ devant les "
            Console.WriteLine("Bonjour, je m'appelle \"Anthony\"");

            // Mise en forme de texte evaec \n et \t
            Console.WriteLine("Je saute une ligne après\n");
            Console.WriteLine("La preuve!");

            Console.WriteLine("Liste des choses à faire : ");
            Console.WriteLine("\tApprendre de C#. ");
            Console.WriteLine("\tFaire les exercices. ");
            Console.WriteLine("\tCréer un projet perso. ");

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("€uro");
            #endregion

            #region Affichage Date et Heure
            DateTime date = DateTime.Now;
            Console.WriteLine("Date et Heure: {0:d} at {0:t}",date);
            #endregion


            Console.WriteLine("\n\nAppuyez sur Enter pour fermer le programme...");
            Console.Read();

        }
    }
}
