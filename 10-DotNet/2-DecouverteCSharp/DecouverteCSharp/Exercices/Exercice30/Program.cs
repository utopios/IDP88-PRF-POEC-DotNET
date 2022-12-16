
#region Déclaration des variables
string choix = "";
string poursuivre = "NON";
#endregion


#region Demande de réponse utilisateur et traitement de sa réponse
do
{
    Console.Clear();
    #region Affichage de la question
    Console.WriteLine("--- Question à choix multiple --- \n");
    Console.WriteLine("Quelle est l'instruction qui permet de sortir d'une boucle en C# ?");
    Console.WriteLine("\ta) quit\n\tb) continue\n\tc) break\n\td) exit\n");
    #endregion
    bool ok = false;
    while (!ok)
    {
        string chaine = "ABCD";
        Console.Write("Entrez votre réponse :");
        choix = Console.ReadLine().ToUpper();
        ok = chaine.Contains(choix);
    }

    if (choix == "C")
    {        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nBravo!!! C'est la bonne réponse \n");
        Console.ForegroundColor = ConsoleColor.White;
        poursuivre = "NON";
    }    
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrecte!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Un nouvel essai ? Oui / Non : ");
        ok = false;
        while (!ok)
        {
            poursuivre = Console.ReadLine().ToUpper();
            if (poursuivre != "OUI" && poursuivre != "NON")
                Console.WriteLine("Erreur de saisie...");
            else
                ok = true;
        }      
    }    
} while (poursuivre == "OUI");
#endregion

Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();