
#region Déclaration des variables
int[] tab = new int[0];
Random rnd = new Random();
#endregion

#region Récupération des saisies utilisateur
Console.WriteLine("--- Est pair...? Est impair...? ---");
Console.Write("Combiens de valeurs contiendra le tableau ? : ");
if (int.TryParse(Console.ReadLine(), out int nombre))
    tab = new int[nombre];
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\tErreur de saisie, merci de saisir un chiffre/nombre : ");
    Console.ForegroundColor = ConsoleColor.White;
}
#endregion

#region Affectation de valeurs entières, prise au hasard entre 1 et 10, au tableau
Console.WriteLine("Affectation automatique des valeurs...\n");
for (int i = 0; i < tab.Length; i++)
    tab[i] = rnd.Next(1, 51);

#endregion

#region Affichage des résultats
Console.WriteLine("Vérification des valeurs du tableau : ");
for (int i = 0; i < tab.Length; i++)
{
    if (tab[i] % 2 == 0)
        Console.WriteLine("\tLa valeur " + tab[i] + " est pair.");
    else
        Console.WriteLine("\tLa valeur " + tab[i] + " est impair.");
}
#endregion

Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
Console.Read();
