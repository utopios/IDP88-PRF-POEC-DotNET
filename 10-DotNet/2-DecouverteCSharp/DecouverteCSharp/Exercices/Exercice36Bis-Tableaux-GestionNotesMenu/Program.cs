
#region Déclaration des variables
double[] notes = new double[0];
string choixMenu;
int nbNote = 1;
#endregion

#region MyRegion
Console.WriteLine("***** Tableaux des notes *****");
Console.Write("Combiens de notes comportera le tableaux : ");
bool ok = false;
while (!ok)
{
    if (int.TryParse(Console.ReadLine(), out nbNote))
    {
        notes = new double[nbNote];
        ok = true;
        Console.Clear();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\tErreur de saisie, merci de saisir un chiffre/nombre : ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
#endregion


#region Interface Utilisateur
do
{
    Console.WriteLine("--- Gestion des notes avec menu --- \n");
    Console.WriteLine("1----Saisir les notes");
    Console.WriteLine("2----La plus grande note");
    Console.WriteLine("3----La plus petite note");
    Console.WriteLine("4----La moyenne des notes");
    Console.WriteLine("0----Quitter\n");
    Console.Write("Faites votre choix : ");
    choixMenu = Console.ReadLine();
    while (choixMenu != "1" && choixMenu != "2" && choixMenu != "3" && choixMenu != "4" && choixMenu != "0")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erreur de saisie...");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Faites votre choix : ");
        choixMenu = Console.ReadLine();
    }

    Console.Clear();
    switch (choixMenu)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"------ Saisir les {nbNote} notes ------\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < notes.Length; i++)
            {
                Console.Write("Merci de saisir la note " + (i+1) + " (sur /20) : ");
                while (!double.TryParse(Console.ReadLine(), out notes[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tErreur de saisie, merci de saisir un chiffre/nombre! ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }           
            Console.Clear();
            break;
        case "2":
            if (notes[0] != 0.0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------ La plus grande note ------\n");
                
                Console.WriteLine("La note la plus grande est : " + notes.Max() + "/20\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------ La plus grande note ------\n");
                Console.WriteLine("Veuillez saisir des notes avant... \n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            break;
        case "3":
            if (nbNote > 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------ La plus petite note ------\n");
                Console.WriteLine("La note la plus petite est : " + notes.Min() + "/20\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------ La plus petite note ------\n");
                Console.WriteLine("Veuillez saisir des notes avant... \n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            break;
        case "4":
            if (nbNote > 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------ La moyenne des notes ------\n");
                //moyNote = Math.Round(moyNote / nbNote, 1);
                Console.WriteLine("La moyenne est de : " + notes.Average() + "/20\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------ La moyenne des notes ------\n");
                Console.WriteLine("Veuillez saisir des notes avant... \n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            break;
        case "0":
            //Fermer une console
            Environment.Exit(0);
            break;

    }
} while (choixMenu != "0");
#endregion