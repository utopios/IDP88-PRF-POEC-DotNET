
#region Version if...else simple
Console.WriteLine("--- Le nombre est-il divisible par...? --- \n");
Console.Write("Entrez un chiffre/nombre entier : ");
int nombre = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez le chiffre/nombre diviseur : ");
int diviseur = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");

if (nombre % diviseur == 0)
    Console.WriteLine("Le chiffre/nombre est divisible par " + diviseur + "\n");
else
    Console.WriteLine("Le chiffre/nombre n'est pas divisible par " + diviseur + "\n");
#endregion


#region Version if...else imbriquée
Console.WriteLine("--- Le nombre est-il divisible par...? --- \n");
Console.Write("Entrez un chiffre/nombre entier : ");
int nombre1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez le chiffre/nombre diviseur : ");
int diviseur1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
if (nombre1 > 9)
{
    if (nombre1 % diviseur1 == 0)
        Console.WriteLine("Le nombre est divisible par " + diviseur1 + "\n");
    else
        Console.WriteLine("Le nombre n'est pas divisible par " + diviseur1 + "\n");
}
else
{
    if (nombre1 % diviseur1 == 0)
        Console.WriteLine("Le chiffre est divisible par " + diviseur1 + "\n");
    else
        Console.WriteLine("Le chiffre n'est pas divisible par " + diviseur1 + "\n");
}
#endregion


Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();