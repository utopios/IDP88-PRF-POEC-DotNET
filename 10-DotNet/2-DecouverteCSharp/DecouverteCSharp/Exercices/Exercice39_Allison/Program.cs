using System;
string[] restants = { "Sondes", "Fares", "Allison", "BenoitL", "Amandine", "Paul", "Christophe", "Jean-Emmanuel", "Nicolas", "Olivier", "BenoitC", "Sebastien", "Simon", "Maxime" };
string[] gagnants = new string[0];
bool exit = false;
int choix;

do
{
    Console.WriteLine("\n  --- Le grand tirage au sort ---\n\n" +
    "  1----Effectuer un tirage\n" +
    "  2----Voir la liste des personnes déjà tirées\n" +
    "  3----Voir la liste des personnes restantes\n" +
    "  0----Quitter\n");

    Console.Write("Faites votre choix : ");
    while (!int.TryParse(Console.ReadLine(), out choix))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\tErreur de saisie! Faites votre choix : ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    switch (choix)
    {
        case 1:
            Console.Clear();
            // Quand le tableau gagnants est rempli et que le tableau restants est vide, restants se reremplit et gagnants se vide
            if (gagnants.Length == 14) 
            {
                restants = (string[])gagnants.Clone(); 
                Array.Resize(ref gagnants, 0); 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Remise à 0 de la liste des personnes tirées car ils ont tous déjà été tirés au sort.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Tirer au sort un gagnant qui ne figure pas encore dans le tableau gagnants
            string gagnant;
            int positionGagnant;
            do
            {
                positionGagnant = new Random().Next(0, restants.Length); 
                gagnant = restants[positionGagnant]; 
            } while (gagnants.Contains(gagnant));

            // Ajouter le gagnant dans le tableau gagnants
            Array.Resize(ref gagnants, gagnants.Length + 1);
            gagnants[gagnants.Length - 1] = gagnant; 

            // Retirer le gagnant du tableau restants
            restants = restants.Where(personne => personne != gagnant).ToArray(); 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"*************\nL'heureux gagnant est : {gagnant}\n*************");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        case 2: // Afficher le tableau gagnants
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*************\nListe des personnes déjà tirées : \n*************");
            Console.ForegroundColor = ConsoleColor.White;
            Array.Sort(gagnants);
            for (int i = 0; i < gagnants.Length; i++)
                Console.WriteLine(new String(' ', i) + gagnants[i]);
            break;
        case 3: // Afficher le tableau restants
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************\nN'ont pas encore fait de correction : \n*************");
            Console.ForegroundColor = ConsoleColor.White;
            Array.Sort(restants);
            for (int i = 0; i < restants.Length; i++)
                Console.WriteLine(new String(' ', i) + restants[i]);
            break;
        case 0:
            exit = true;
            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur de saisie! Veuillez ne rentrer que 1, 2, 3 ou 0\n");
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }
} while (!exit);