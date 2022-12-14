
Console.WriteLine("--- Calcul des intérêts --- \n");

#region Déclaration des variables
double capitalDepart;
double tauxInteret;
double duree;
double capitalFinal;
double interets;
#endregion


#region Récupération des saisies utilisateur
Console.Write("Entrez Capital de départ (en Euros) : ");
capitalDepart = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez le taux d'intérêt (en %) : ");
tauxInteret = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la durée de l'épargne (en années) : ");
duree = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
#endregion


#region Calcul des Intérêts et du Capital Final
capitalFinal = Math.Round(capitalDepart * Math.Pow(1 + (tauxInteret / 100), duree), 2);
interets = Math.Round(capitalFinal - capitalDepart, 2);
#endregion


#region Affichage des résultats
//Console.WriteLine("Le montant des intérêts sera de " + Math.Round(Math.Round(capitalDepart * Math.Pow(1 + (tauxInteret / 100), duree), 2) - capitalDepart, 2) + "euros après " + duree + " ans.\n" + "Le capital final sera de " + Math.Round(capitalDepart * Math.Pow(1 + (tauxInteret / 100), duree), 2) + "euros.\n");
Console.WriteLine("Le montant des intérêts sera de " + interets + " Euros après " + duree + " ans");
Console.WriteLine("Le capital final sera de " + capitalFinal + " Euros\n");
#endregion


Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();