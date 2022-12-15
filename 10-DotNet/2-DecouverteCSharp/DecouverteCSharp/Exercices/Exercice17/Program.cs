
#region Déclaration variable
string choix;
string message;
#endregion

#region Récupération choix utilisateur
Console.WriteLine("--- Quelle boisson souhaitez-vous?\n");
Console.WriteLine("Liste des boissons disponibles :");
Console.WriteLine("\t1)Eau Plate");
Console.WriteLine("\t2)Eau Gazeuse");
Console.WriteLine("\t3)Coca-Cola");
Console.WriteLine("\t4)Fanta");
Console.WriteLine("\t5)Sprite");
Console.WriteLine("\t6)Orangina");
Console.WriteLine("\t7)7Up");
Console.Write("Faites votre choix (1 à 7) : ");
choix = Console.ReadLine();
#endregion

#region Switch pour tester la saisie utilisateur et afficher le résultat
Console.WriteLine("");
switch (choix)
{
    case "1": message = "Votre eau plate est servie...\n"; break;
    case "2": message = "Votre eau gazeuse est servie...\n"; break;
    case "3": message = "Votre Coca-Cola est servi...\n"; break;
    case "4": message = "Votre Fanta est servi...\n"; break;
    case "5": message = "Votre Sprite est servi...\n"; break;
    case "6": message = "Votre Orangina est servi...\n"; break;
    case "7": message = "Votre 7Up est servi...\n"; break;
    default: message = "Mauvais choix !\n"; break;
}
#endregion

#region Affichage du résultat
Console.WriteLine(message);
#endregion

Console.WriteLine("Appuyez sur enter pour fermer le programme...");
Console.Read();