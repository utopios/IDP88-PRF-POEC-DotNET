
#region Déclaration des variables
double maxNote = 0;
double minNote = 20;
double moyNote = 0;
double noteTmp = 0;
int nbNote = 0;
#endregion

#region While pour les saisies des notes de l'utilisateur
Console.WriteLine("--- Gestion des notes --- \n");
Console.WriteLine("Veuillez saisir les notes : ");
Console.WriteLine("(999 pour calculer) \n");
while (noteTmp != 999)
{
    noteTmp = 0;
    Console.Write("\t- Merci de saisir la note " + (nbNote + 1) + " (sur /20) : ");
    //noteTmp = Convert.ToDouble(Console.ReadLine());
    if (int.TryParse(Console.ReadLine(), out int nb))    
        noteTmp = nb;    
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\tErreur de saisie, merci de saisir un chiffre/nombre! ");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    if (noteTmp == 999)
    {
        break;
    }
    else if (noteTmp > 20 || noteTmp < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    moyNote += noteTmp;
    if (noteTmp > maxNote)
        maxNote = noteTmp;
    if (noteTmp < minNote)
        minNote = noteTmp;
    nbNote++;
}
#endregion

#region Calcul de la moyenne
moyNote = Math.Round(moyNote / nbNote, 1);
#endregion

#region Affichage des résultats de l'utilisateur
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("la meilleure note est " + maxNote + "/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("la moins bonne note est " + minNote + "/20");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("La moyenne des " + nbNote + " notes est " + moyNote + "/20\n");
#endregion

Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();