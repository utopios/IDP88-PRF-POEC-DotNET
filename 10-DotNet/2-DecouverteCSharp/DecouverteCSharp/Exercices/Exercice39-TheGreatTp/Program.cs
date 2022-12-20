#region Déclaration des variables
int choice;
bool fin = false;
string[] Rest = { "Sondes.M", "Fares.D", "Allison.T", "Benoït.L", "Amandine.A", "Paul.S", "Christophe.R", "Jean.Emmanuel.M", "Nicolas.B", "Olivier.B", "Simon.D", "Sébastien.D", "Maxime.L", "Benoît.C" };
string[] Winners = new string[Rest.Length];
Random aleatoire = new Random();
#endregion

#region Menu

do
{

    #region Indication de réinitialisation imminente si tous les prénoms ont été tirés
    if (fin == true)
    {
        Console.ForegroundColor = System.ConsoleColor.Red;
        Console.WriteLine("***********************************************************************");
        Console.WriteLine("* Tous les prénoms ont été tirés. Réinitialisation au prochain tirage *");
        Console.WriteLine("***********************************************************************");
        Console.ForegroundColor = System.ConsoleColor.Gray;
    }
    #endregion

    #region Titre
    Console.WriteLine("--- Le grand tirage au sort ---\n\n1----Effectuer un tirage\n2----Voir la liste des personne déjà tirées\n3----Voir la liste des personnes restantes\n0----Quitter");
    Console.Write("\nFaites votre choix : ");
    choice = Convert.ToInt32(Console.ReadLine());
    #endregion

    #region Sélection switch
    switch (choice)
    {
        #region 1. Effectuer un tirage
        case int i when i == 1:
            int c = 0; // On réinitialise notre compteur de noms tirés (qui nous servira pour indiquer l'index de Winners[] à compléter
            int pick; // Notre variable aléatoire
            Console.Clear();

            #region Réinitialisation si tous les noms ont été tirés
            if (fin == true)
            {
                Winners.CopyTo(Rest, 0);
                Array.Clear(Winners, 0, Winners.Length);
            }
            #endregion

            #region Choix aléatoire du gagnant
            do // tant que l'aléatoire tombe sur des index vides du tableau, il retire un nouveau numéro
            {
                pick = aleatoire.Next(0, Rest.Length);
            } while (Rest[pick] == null);
            #endregion

            #region Affichage
            Console.ForegroundColor = System.ConsoleColor.Green;
            // Pour avoir des lignes de "*" égales à la longueur du prénom + cadre
            Console.Write("**************************");
            for (int n = 0; n < Rest[pick].Length + 2; n++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n* L'heureux gagnant est : {0} *", Rest[pick]);
            Console.Write("**************************");
            for (int n = 0; n < Rest[pick].Length + 2; n++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ForegroundColor = System.ConsoleColor.Gray;
            #endregion

            #region Addition du nom du gagnant au tableau "Winners"
            while (Winners[c] != null && c < Winners.Length)
            {
                c++;
            }
            // Tant qu'un index de Winners contient un prénom (!null), on passe au suivant, pour déterminer le premier index vide du tableau
            Winners[c] = Rest[pick]; // On copie le prénom depuis Rest vers Winners au bon index
            #endregion

            #region Soustraction du nom du gagnant du tableau "Rest"
            Rest[pick] = null; // Pour utiliser la même méthode de ciblage, on associe "null" à l'index des prénoms tirés de Rest
            #endregion

            #region Vérification de réinitialisation
            if (c == Winners.Length - 1)
            {
                fin = true;
            }
            else
            {
                fin = false;
            }
            // Si c est à Winners.length-1, ça veut dire que tous les prénoms ont été tirés, et qu'il faut indiquer la réinitialisation imminente
            #endregion
            break;
        #endregion

        #region 2. Voir la liste des personnes déjà triées
        case int i when i == 2:
            int x = 0;
            Console.Clear();
            Console.ForegroundColor = System.ConsoleColor.DarkRed;
            Console.WriteLine("***********************************************");
            Console.WriteLine("* Liste des personnes ayant déjà été tirées : *");
            Console.WriteLine("***********************************************");
            Console.ForegroundColor = System.ConsoleColor.Gray;
            for (int j = 0; j < Winners.Length; j++)
            {
                if (Winners[j] != null)
                {
                    for (int k = 0; k < x; k++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(Winners[j]);
                    x++;
                }
            } // On affiche tous les éléments du tableau qui ne sont pas "null"
            break;
        #endregion

        #region 3. Voir la liste des personnes restantes
        case int i when i == 3:
            int y = 0;
            Console.Clear();
            Console.ForegroundColor = System.ConsoleColor.Cyan;
            Console.WriteLine("***************************************************************");
            Console.WriteLine("* Liste des personnes n'ayant pas encore fait de correction : *");
            Console.WriteLine("***************************************************************");
            Console.ForegroundColor = System.ConsoleColor.Gray;
            for (int j = 0; j < Rest.Length; j++)
            {
                if (Rest[j] != null)
                {
                    for (int k = 0; k < y; k++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(Rest[j]);
                    y++;
                }
            } // On affiche tous les éléments du tableau qui ne sont pas "null"
            break;
        #endregion

        #region 0. Quitter
        case int i when i == 0:
            Console.Clear();
            break;
        #endregion

        #region Erreur de saisie
        default:
            Console.Clear();
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine("\tERREUR DE SAISIE");
            Console.ForegroundColor = System.ConsoleColor.Gray;
            break;
            #endregion
    }
    #endregion

} while (choice != 0);


Environment.Exit(0);
#endregion
