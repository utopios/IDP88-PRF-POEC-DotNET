
#region Déclaration des variables
string[] moisAnnee = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
#endregion

#region Enumeration du tableau avec foreach
Console.WriteLine("Enumération du tableau avec un foreach :");
string chaine = "";
foreach (string mois in moisAnnee)
{
    Console.WriteLine(chaine + mois);
    chaine += "\t";
}
#endregion


Console.WriteLine("Appuyez sur Enter pour fermer le programme");
Console.ReadLine();