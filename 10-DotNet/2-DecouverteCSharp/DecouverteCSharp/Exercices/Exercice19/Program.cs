

#region Déclaration des variables
double revenus;
int nbAdulte;
int nbEnfants;
double nbParts;
double revenuImposable;
double montantImpot;
#endregion

#region Demande les saisies utilisateur et les stockes dans des variables
Console.WriteLine("--- Quelle sera le montant des mes impôts ? --- \n");
Console.Write("Entrez le montant net imposable du foyer (en Euros): ");
revenus = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez le nombre d'adulte du foyer : ");
nbAdulte = Convert.ToInt32(Console.ReadLine());
Console.Write("Entrez le nombre d'enfants du foyer : ");
nbEnfants = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");
#endregion

#region Calcul du nombre de parts du foyer
if (nbEnfants <= 2)
    nbParts = nbAdulte + nbEnfants * 0.5;
else
    nbParts = nbAdulte + nbEnfants - 1;
#endregion

#region Sugar Syntaxe pour calcul du nombre de parts
//double nbParts= nbEnfants <= 2 ? nbAdulte + nbEnfants * 0.5 : nbAdulte + nbEnfants - 1;
#endregion

#region Calcul du montant de l'impôt            
revenuImposable = revenus / nbParts;
montantImpot = 0;

switch (revenuImposable)
{
    case double montantImposable when montantImposable >= 10065 && montantImposable <= 25659:
        montantImpot = Math.Round((revenuImposable - 10064) * 0.11, 0); break;
    case double montantImposable when montantImposable >= 25660 && montantImposable <= 73369:
        montantImpot = Math.Round((revenuImposable - 25659) * 0.3 + 1715.34, 0); break;
    case double montantImposable when montantImposable >= 73370 && montantImposable <= 157806:
        montantImpot = Math.Round((revenuImposable - 73369) * 0.41 + 1715.34 + 14312.7, 0); break;
    case double montantImposable when (montantImposable >= 157807):
        montantImpot = Math.Round((revenuImposable - 157806) * 0.45 + 1715.34 + 14312.7 + 34618.8, 0); break;
}

montantImpot = montantImpot * nbParts;
#endregion

#region Affichage à l'utilisateur
Console.WriteLine("Vous allez payer " + montantImpot + " Euros\n");
#endregion

Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();