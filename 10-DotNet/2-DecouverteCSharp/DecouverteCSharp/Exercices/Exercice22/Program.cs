
Console.WriteLine("--- Les tables de multiplication --- \n");


// Permet de faire une boucle itérative allant de 1 à 10 pour numeros de table
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Table de " + i + " : ");
    // Boucles itérative imbriquée allant de 1 à 10 pour la deuxieme partie de la table
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine("\t- " + i + " x " + j + " = " + (i * j));
    }
    Console.WriteLine("");
}
Console.WriteLine("");

Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();