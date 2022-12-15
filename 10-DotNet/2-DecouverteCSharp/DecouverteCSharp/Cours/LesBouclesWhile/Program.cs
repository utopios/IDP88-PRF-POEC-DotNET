Console.WriteLine("Les Boucles While (tant que...)");

#region La boucle While simple
int compteur = 1;
while (compteur <= 50)
{
    Console.WriteLine($"Le compteur affiche {compteur}");
    compteur++;
}
#endregion

#region La boucle While simple
int compteur2 = 1;
bool valid = false;
while (!valid)
{
    Console.WriteLine($"Le compteur affiche {compteur2}");
    if (compteur2 == 50)
    {
        valid = true;
    }
    compteur2++;
}
#endregion

Console.Write("Appuyez sur Enter pour fermer le programme...");
Console.Read();