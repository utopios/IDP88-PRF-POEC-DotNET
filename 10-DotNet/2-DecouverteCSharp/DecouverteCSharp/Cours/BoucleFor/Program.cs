
#region Déclaration de variable et ulilisation dans la boucle [Slide 65]
int compteur;
for (compteur = 1; compteur <= 10; compteur++)
{
    Console.WriteLine("L'instruction à été executée: " + compteur + " fois");
}
#endregion

#region Déclaration de la variable d'itération à la volée
for (int i = 0; i <= 10; i = i + 2)
{
    Console.WriteLine(i);
}
#endregion

#region Variable de décrementation
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
#endregion

#region Intéraration de caractères
for (char c = 'A'; c <= 'Z'; c++)
{
    Console.WriteLine(c);
}
#endregion

#region Boucles imbriquées
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("i = " + i);
    for (int j = 0; j <= 9; j++)
    {
        Console.WriteLine("j = " + j);
    }
}
#endregion

Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
Console.Read();
