#region Déclaration des variables
using Exercice39_TheGreatTP_PRF2022;

string[] Origine = new string[] { "Rock", "Mathieu", "Jonathan", "Patrick", "Alexandre", "Franck", "Soukaïna", "Romain", "Thomas", "Dylan", "Sofiane", "Benjamin", "Emmanuel", "Audrey", "Myriam" };
string[] Tiree = new string[Origine.Length];
int compteur = 0;
MyFunctions myFunction = new();
string choix;
#endregion

do
{
    // Affichage du menu
    myFunction.MainMenu();
    // Récupération du choix de l'utilisateur
    choix = myFunction.GetUserValue("1230");   
    // Clear console()
    Console.Clear();

    // switch case
    switch (choix)
    {
        case "1":
            myFunction.DrawLots(ref compteur, Origine, Tiree);
            break;
        case "2":
            myFunction.DisplayArray(Tiree,"Liste des personnes déjà tirées","red");
            break;
        case "3":
            myFunction.DisplayArray(Origine, "N'ont pas encore fait de correction", "cyan");
            break;
    }
} while (choix != "0");