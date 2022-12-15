
#region Déclaration des Variables
double nbhabitant = 96809;
double taux = 0.89/100;
int date = 2015;
int nbAnnee = 0;
#endregion

#region Boucle for pour simuler l'accroissement de la population
for (int i = 1; i < 100; i++)
{
    // nbhabitant = nbhabitant + nbhabitant * taux;
    nbhabitant += nbhabitant * taux;
    date++;
    nbAnnee++;
    if (nbhabitant >= 120000)
        break;
}
#endregion

#region Affichage à L'utilisateur
Console.WriteLine("--- Accroissement de population --- \n");
Console.WriteLine("Il faudra " + nbAnnee + " ans, nous serons en " + date);
Console.WriteLine("Il y aura " + Math.Round(nbhabitant, 0) + " habitants en " + date + "\n");
#endregion

Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();