
#region Déclaration des variables
double revenus = 0;
int nbAdulte = 0;
int nbEnfants = 0;
double nbParts;
double revenuImposable = 0;
double montantImpot = 0;
#endregion

#region Récupération des saisies Utilisateur
Console.WriteLine("\n--- Quelle sera le montant des mes impôts ? --- \n");

Console.Write("Entrez le montant net imposable du foyer (en Euros): ");
revenus = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez le nombre d'adulte(s) du foyer : ");
nbAdulte = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez le nombre d'enfant(s) du foyer : ");
nbEnfants = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n");
#endregion

#region Calcul du nombre de parts du foyer            
if (nbEnfants <= 2)
    nbParts = nbAdulte + nbEnfants * 0.5;
else
    nbParts = nbAdulte + nbEnfants - 1;
#endregion

#region Sugar Syntaxe (ternaire) pour le Calcul du nombre de parts
//nbParts = nbEnfants <= 2 ? nbAdulte + nbEnfants * 0.5 : nbAdulte + nbEnfants - 1;
#endregion

#region Calcul du montant de l'impôt  
// Calcul du Revenu imposable
revenuImposable = revenus / nbParts;

// Etablissement Structure If() pour calculer le montant de l'impôt
if (revenuImposable >= 10226 && revenuImposable <= 26070)
    montantImpot = (revenuImposable - 10225) * 0.11;
else if (revenuImposable >= 26071 && revenuImposable <= 74545)
    montantImpot = (revenuImposable - 26070) * 0.3 + (26070 - 10226) * 0.11;
else if (revenuImposable >= 74546 && revenuImposable <= 160336)
    montantImpot = (revenuImposable - 74545) * 0.41 + (74545 - 26070) * 0.3 + (26070 - 10226) * 0.11;
else if (revenuImposable >= 160337)
    montantImpot = (revenuImposable - 160336) * 0.45 + (160336 - 74545) * 0.41 + (74545 - 26070) * 0.3 + (26070 - 10226) * 0.11;

// Calcul de l'impôt
montantImpot = Math.Round(montantImpot * nbParts,0);
#endregion

#region Affichage des résultats
Console.WriteLine("Vous allez payer " + montantImpot + " Euros\n");
#endregion


Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();