
#region Déclaration des variables
double prixObjetHt;
double tauxTva;
double mtTva;
double prixObjetTtc;
#endregion


#region Récupération des saisies utilisateur
Console.Write("Entrez le prix HT de l'objet (en Euros) : ");
prixObjetHt = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez le taux de TVA (en %) : ");
tauxTva = Convert.ToDouble(Console.ReadLine());
#endregion


#region Calcul du montant de la T.V.A et du prix T.T.C
mtTva = prixObjetHt * tauxTva / 100;
prixObjetTtc = prixObjetHt + mtTva;
#endregion


#region Affichage des résultats
Console.WriteLine("Le montant de la T.V.A est de " + mtTva + " Euros");
Console.WriteLine("Le prix TTC de l'objet est de " + prixObjetTtc + " Euros\n");
#endregion

Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();