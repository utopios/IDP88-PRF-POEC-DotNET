
Console.WriteLine("--- Accroissement de population --- \n");

#region Déclaration des variables
double nbhabitant = 96809;
int date = 2015;
int nbAnnee = 0;
#endregion

#region Accroissement de la population
// Tant que le nombre d'habitants est inférieur à 120.000 Habitants
while (nbhabitant < 120000)
{
    nbhabitant *= 1.0089;
    //Console.WriteLine(nbhabitant);
    date++;
    nbAnnee++;
}
#endregion

#region Affichage des résultats
Console.WriteLine("Il faudra " + nbAnnee + " ans, nous serons en " + date);
Console.WriteLine("Il y aura " + Math.Round(nbhabitant, 0) + " habitants en " + date + "\n");
#endregion

Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();