using System;

namespace Exercice39_TheGreatTP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prenomOrigine = new string[] { "Jérome", "Yves", "Aguit", "Olivier", "Walid", "Stéphanie", "Dominique", "Brice", "Yannick", "Anthony", "Christopher", "Allan", "Adrien", "Eric", "Sébastien" };
            string[] prenomTire = new string[0];
            string choix;
            Random tirage = new Random();
            string selectionne = "";

            do
            {
                Console.WriteLine("  --- Le grand tirage au sort ---\n");
                Console.WriteLine("  1---Effectuer un tirage");
                Console.WriteLine("  2---Voir la liste des personnes déja tirées");
                Console.WriteLine("  3---Voir la liste des personnes restantes");
                Console.WriteLine("  0---Quitter\n");
                Console.Write("Faites votre choix : ");
                choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        bool valid = false;
                        do
                        {
                            // Vérification du tableau prenom tire, si tout le monde à été tiré, on réinitialise le tableau
                            if (prenomTire.Length >= 15)
                            {
                                prenomTire = new string[0];
                            }
                            // Tirage aléatoire d'un prenom
                            selectionne = prenomOrigine[tirage.Next(prenomOrigine.Length)];
                            // Si le prénom tiré n'a pas été déjà tiré
                            if (Array.IndexOf(prenomTire, selectionne) == -1)
                            {
                                // Création d'un tableau temporaire tmp de la taille de prenomTire +1
                                string[] tmp = new string[prenomTire.Length + 1];
                                // Copie de prenomTire dans tmp
                                prenomTire.CopyTo(tmp, 0);
                                // Copie du nouveau prénom tiré dans tmp
                                tmp[tmp.Length - 1] = selectionne;
                                // Création d'un nouveau tableau prenomTire de la taille du tableau temporaire tmp
                                prenomTire = new string[tmp.Length];                                
                                // Copie de tmp dans le nouveau tableau prenomTire
                                tmp.CopyTo(prenomTire, 0);
                                // On bascule valid pour sortir de la boucle do...while
                                valid = true;
                            }
                        } while (!valid);
                        // Initialisation d'une chaine vide
                        string chaine = "";
                        // Pour chaque caractères du prénom on ajoute une *
                        foreach (char l in selectionne)
                            chaine += "*";
                        // Affichage du gagnant
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("****************************" + chaine);
                        Console.WriteLine("* L'heureux gagnant est : {0} * ", selectionne);
                        Console.WriteLine("****************************" + chaine);
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    case "2":
                        // Block titre de la section
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("****************************************");
                        Console.WriteLine("* Liste des personnes déja été tirés : *");
                        Console.WriteLine("****************************************");
                        Console.ForegroundColor = ConsoleColor.White;
                        // Inititalisation d'une chaine vide
                        string chaine2 = "";
                        // Pour chaque prénom dans le tableau prenomTire
                        foreach (string prenom in prenomTire)
                        {
                            // Affichage du prénom
                            Console.WriteLine(chaine2 + prenom);
                            // Incrémentation de la chaine de deux caractères vides
                            chaine2 += "  ";
                        }
                        break;
                    case "3":
                        // Block titre de la section
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("* N'ont pas encore fait de correction : * ");
                        Console.WriteLine("*****************************************");
                        Console.ForegroundColor = ConsoleColor.White;
                        // Inititlisation de la chaine
                        string chaine3 = "";
                        // Pour chaque prébom dans la liste origine
                        foreach (string prenom in prenomOrigine)
                        {
                            // On vérifie qu'il ne soit pas déja tiré
                            if (Array.IndexOf(prenomTire, prenom) == -1)
                            {
                                // S'il n'est pas déja tiré, on l'affiche
                                Console.WriteLine(chaine3 + prenom);
                                chaine3 += "  ";
                            }
                        }
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }

            } while (choix != "0");

            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}
