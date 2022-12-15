
Console.WriteLine("--- Menus et sous-menus --- \n");
Console.WriteLine("Table des matières :\n");

// Permet de faire une boucle itérative allant de 1 à 3 pour les chapitres
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("\tChapitre " + i);
    // Boucle imbriquée alant de 1 à 3 pour les sous-menus
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($"\t\t-Partie {i}.{j}");
    }
}
Console.WriteLine("");

Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();