
#region Incrémentation d'un compteur
int compteur = 1;
do
{
    Console.WriteLine($"Le compteur affiche {compteur}");
    compteur++;
} while (compteur<=50);

Console.WriteLine($"Une fois sorti de la premiere boucle Do...While, le compteur vaut {compteur}");

do
{
    Console.WriteLine($"Le compteur affiche {compteur}");
    compteur++;
} while (compteur <= 50);

Console.WriteLine($"Une fois sorti de la deuxieme boucle Do...While, le compteur vaut {compteur}");
#endregion




Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();
