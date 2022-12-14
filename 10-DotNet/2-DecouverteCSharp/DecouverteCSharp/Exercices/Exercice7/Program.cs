
Console.Write("--- Calcul de la longeur de l'hypothénuse ---" + Environment.NewLine);

#region Déclaration des variables
double premierCote,
        deuxiemeCote,
        sommeDesCarres,
        resultat;
#endregion


#region Recupération des saisies utilisateur
Console.Write("Entrez la longeur du premier coté (en cm) : ");
premierCote = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la longeur du deuxième coté (en cm) : ");
deuxiemeCote = Convert.ToDouble(Console.ReadLine());
#endregion


#region Calcul de l'hypothénuse
sommeDesCarres = Math.Pow(premierCote, 2) + Math.Pow(deuxiemeCote, 2);
resultat = Math.Round(Math.Sqrt(sommeDesCarres), 2);
#endregion


#region Affichage des résultats
Console.WriteLine($"La longueur de l'hypothénuse est {resultat} cm\n");
#endregion

Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();