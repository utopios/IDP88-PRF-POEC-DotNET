using System.Linq;


// Création d'un tableau avec affectation des valeurs
int nbTirages = 0;
string[] candidats = new string[] { "Simon", "Sébastien", "Maxime", "Benoit.C", "Olivier", "Nicolas", "Jean-Emmanuel", "Christophe", "Paul", "Amandine", "Benoit.L", "Allison", "Sondes", "Fares" };
string[] gagnants = new string[14];


// Création du menu
bool menu = true;
Console.Clear();
do
{
    Console.WriteLine("\n--- LE GRAND TIRAGE AU SORT ---\n\n");
    Console.WriteLine("\n1--- Effectuer un tirage\n2---Voir la liste des personnes déja tirées\n3---Voir la liste des personnes restantes\n0---Quitter");
    Console.Write("Faites votre choix : ");
    int choix = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (choix)
    {
        case 1:
            {
                nbTirages++;
                // Génération d'un nombre aléatoire entre 0 et 13 (index)
                Random n = new Random();
                int indexGrandGagnant = n.Next(0, candidats.Length);
                string grandGagnant = candidats[indexGrandGagnant];

                //Affichage
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n*******************************");
                Console.WriteLine($"Le Grand Gagnant est : {grandGagnant}");
                Console.WriteLine("*******************************\n");
                Console.ForegroundColor = ConsoleColor.White;

                // Copie du gagnant dans le second tableau
                for (int i = 0; i <= nbTirages; i++)
                    if (i < nbTirages)
                    {
                        continue;
                    }
                    else if (i == nbTirages && i < 14)
                    {
                        gagnants[i] = grandGagnant;
                    }
                    else if (i == 14)
                    {
                        Console.WriteLine("Il n'y a plus de candidats...");
                        Console.WriteLine("Réinitialisation de la liste de candidats...");
                        nbTirages = 0;
                        gagnants = new string[14];
                        candidats = new string[] { "Simon", "Sébastien", "Maxime", "Benoit.C", "Olivier", "Nicolas", "Jean-Emmanuel", "Christophe", "Paul", "Amandine", "Benoit.L", "Allison", "Sondes", "Fares" };
                    }

                // Suppression du grandGagnant dans le tableau initial
                candidats = candidats.Except(new string[] { grandGagnant }).ToArray();

            }
            break;
        case 2:
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*******************************");
                Console.WriteLine("Liste des personnes déja tirées");
                Console.WriteLine("*******************************\n");
                Console.ForegroundColor = ConsoleColor.White;

                // Affichage des personnes tirées au sort
                Console.WriteLine($"Nombre de tirages : {nbTirages}\n");
                foreach (var gagnant in gagnants)
                {
                    Console.WriteLine(gagnant);
                }
            }
            break;
        case 3:
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*******************************");
                Console.WriteLine("Liste des personnes restantes");
                Console.WriteLine("*******************************\n");
                Console.ForegroundColor = ConsoleColor.White;

                // Affichage du tableau candidats
                foreach (var candidat in candidats)
                {
                    Console.WriteLine(candidat);
                }
            }
            break;
        case 0:
            {
                Environment.Exit(0);
            }
            break;
    }


} while (!menu == false);

Console.WriteLine("\n\nAppuyez sur Enter pour fermer le programme");
Console.Read();

