
#region Déclaration de variable
int nombre;
#endregion

#region Récupération saisie utilisateur et affichage informations
Console.WriteLine("--- Les suites chaînées de nombres --- \n");
Console.Write("Merci de saisir un nombre : ");
nombre = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Les chaînes possible sont : ");
#endregion

#region Instruction While pour rechercher les chaînes et les afficher
int i = 1;
while (i <= nombre / 2 + 1)
{
    int sommeTmp = i;
    string chaineTmp = nombre + " = " + i;
    int j = i + 1;
    while (j <= nombre / 2 + 1)
    {
        sommeTmp = sommeTmp + j;
        chaineTmp += "+" + j;
        if (sommeTmp == nombre)
        {
            Console.WriteLine(chaineTmp);
            break;
        }
        else if (sommeTmp > nombre)
            break;
        j++;
    }
    i++;
}
#endregion

Console.WriteLine(Environment.NewLine);
Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();