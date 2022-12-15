
#region Déclaration des variables
int nbNotes;
double maxNote = 0;
double minNote = 20;
double moyNote = 0;
#endregion

#region Demande de saisie utilisateur et traitement des notes
Console.WriteLine("--- Gestion des notes --- \n");
Console.Write("Combiens de notes allez-vous saisir ? : ");
nbNotes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Veuillez saisir les " + nbNotes + " notes : \n");
for (int i = 1; i <= nbNotes; i++)
{
    Console.Write("\t- Merci de saisir la note " + i + " (sur /20) : ");
    double noteTmp = Convert.ToDouble(Console.ReadLine());
    // Ajoute la note saisie au total
    moyNote += noteTmp;
    // Verifie si la note saisie est supérieure à la note max, Si oui Note max prend la valeur de noteTmp
    if (noteTmp > maxNote)
        maxNote = noteTmp;
    // Verifie si la note saisie est inférieure à la note min, Si oui note min prend la valeur de noteTmp
    if (noteTmp < minNote)
        minNote = noteTmp;
}
#endregion

#region Calcul de la moyenne
moyNote = Math.Round(moyNote / nbNotes, 2);
#endregion

#region Affichage utilisateur
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("la meilleure note est " + maxNote + "/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("la moins bonne note est " + minNote + "/20");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("La moyenne des notes est " + moyNote + "/20\n");
#endregion

Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();