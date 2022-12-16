
#region Déclaration des variables
Random aleatoire = new Random();
int nbMystere = aleatoire.Next(1, 51);
int nbCoups = 0;
bool trouve = false;
#endregion

#region Boucle While : Tant que le nombre mystère n'est pas trouvé
Console.WriteLine("--- Trouver le nombre mystère --- \n");
// Tant que le booléen trouve ne vaut pas true
while (!trouve)
{
    Console.Write("\tVeuillez saisir un nombre : ");
    int nbTmp = Convert.ToInt32(Console.ReadLine());
    if (nbTmp == nbMystere)       
        trouve = true;    
    else if (nbTmp < nbMystere)
    {       
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tLe nombre mystère est plus grand");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tLe nombre mystère est plus petit");
        Console.ForegroundColor = ConsoleColor.White;
    }
    nbCoups++;
    Console.WriteLine("Appuyer sur 'Enter' pour continuer...");
    Console.ReadLine();
    Console.Clear();
}
#endregion

#region Affichage du résultat
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nBravo !!!! Vous avez trouvé le nombre mystère !\n");
Console.WriteLine("Vous avez trouvé en " + nbCoups + " coups.\n");
Console.ForegroundColor = ConsoleColor.White;
#endregion

Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();