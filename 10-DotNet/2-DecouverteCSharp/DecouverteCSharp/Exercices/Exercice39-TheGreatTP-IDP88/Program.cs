#region Déclaration des variables
string[] Origine = new string[] { "Sondes.M", "Fares.D", "Allison.T", "Benoït.L", "Amandine.A", "Paul.S", "Christophe.R", "Jean.Emmanuel.M", "Nicolas.B", "Olivier.B", "Simon.D", "Sébastien.D", "Maxime.L", "Benoît.C" };
string[] Tiree = new string[Origine.Length];
int compteur = 0;
string chaine = "";
Random r = new Random();
string choix;
#endregion

do
{
    // Affichage du menu
    Console.WriteLine("----- Le grand tirage au sort -----\n");
    Console.WriteLine("1-- Effectuer un tirage ");
    Console.WriteLine("2-- Voir la liste des personnes déjà tirées");
    Console.WriteLine("3-- Voir la liste des personnes restantes");
    Console.WriteLine("\n0--- Quitter");
    // Recupératon du choix
    string possibleChoice = "1230";
    choix = "-1";
    while (!possibleChoice.Contains(choix))
    {
        Console.Write("\nVotre choix (0,1,2,3) => ");
        choix = Console.ReadLine();
    }
   
    // Clear console()
    Console.Clear();

    // switch case
    switch (choix)
    {
        case "1":
            string element;
            int index;
            chaine = "";
            if (compteur < Origine.Length)
            {
                do
                {
                    index = r.Next(0, Origine.Length);
                    element = Origine[index];
                
                } while (element == null);
                foreach (char c in element)
                    chaine += "*";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n**********************************{chaine}");
                Console.WriteLine($"***** L'heureux gagnant est {element} *****");
                Console.WriteLine($"**********************************{chaine}\n");
                Console.ForegroundColor = ConsoleColor.White;
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
            break;
        case "2":
            chaine = "";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Liste des personnes déjà tirées *****");
            Console.WriteLine("*******************************************");
            Console.ForegroundColor = ConsoleColor.White;
            if (compteur>0)
            {
                foreach (string nom in Tiree)
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
            break;
        case "3":
            chaine = "";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************************************");
            Console.WriteLine("***** N'ont pas encore fait de correction : *****");
            Console.WriteLine("*************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string nom in Origine)
            {
                if (nom != null)
                {
                    Console.WriteLine(chaine + nom);
                    chaine += "   ";
                }
            }
            Console.WriteLine("\nAppuyez sur ENTER pour retourner au menu principal...");
            Console.Read();
            Console.Clear();
            break;
    }
} while (choix != "0");