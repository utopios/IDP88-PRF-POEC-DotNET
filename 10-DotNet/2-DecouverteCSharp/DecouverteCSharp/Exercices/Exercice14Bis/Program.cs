
Console.WriteLine("\n--- Quelle taille dois-je prendre ? --- \n");

#region Récupération des saisies utilisateur
Console.Write("Entrez votre taille (en cm) : ");
int taille = Convert.ToInt32(Console.ReadLine());
Console.Write("Entrez votre poids (en kg) : ");
int poids = Convert.ToInt32(Console.ReadLine());

#endregion

#region Structure conditionelle pour affichage des résultats

switch (taille)
{
    case int n when n >= 145 && n < 172 && poids >= 43 && poids <= 47 ||
                    n >= 145 && n < 169 && poids >= 48 && poids <= 53 ||
                    n >= 145 && n < 166 && poids >= 54 && poids <= 59 ||
                    n >= 145 && n < 163 && poids >= 60 && poids <= 65:
        Console.WriteLine("\nPrennez la taille 1.\n");
        break;
    case int n when n >= 169 && n < 183 && poids >= 48 && poids <= 53 ||
                    n >= 166 && n < 178 && poids >= 54 && poids <= 59 ||
                    n >= 163 && n < 175 && poids >= 60 && poids <= 65 ||
                    n >= 160 && n < 172 && poids >= 66 && poids <= 71:
        Console.WriteLine("\nPrennez la taille 2.\n");
        break;
    case int n when n >= 178 && n <= 183 && poids >= 54 && poids <= 59 ||
                    n >= 175 && n <= 183 && poids >= 60 && poids <= 65 ||
                    n >= 172 && n <= 183 && poids >= 66 && poids <= 71 ||
                    n >= 163 && n <= 183 && poids >= 72 && poids <= 77:
        Console.WriteLine("\nPrennez la taille 3.\n");
        break;
    default:
        Console.WriteLine("\nAucune taille ne vous correspond...");
        break;
}

#endregion

Console.WriteLine("\nAppuyez sur une touche pour fermer le programme...");
Console.Read();