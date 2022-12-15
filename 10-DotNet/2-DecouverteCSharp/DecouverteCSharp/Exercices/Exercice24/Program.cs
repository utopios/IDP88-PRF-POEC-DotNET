
Console.WriteLine("--- Les suites chaînées de nombres --- \n");
Console.Write("Merci de saisir un nombre : ");
int nombre = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nLes chaînes possible sont : ");
for (int i = 1; i <= nombre / 2 + 1; i++)
{
    int somme = i;
    string chaine = nombre + " = " + i;
    for (int j = i + 1; j <= nombre / 2 + 1; j++)
    {
        //somme = somme + j;
        somme += j;
        chaine += "+" + j;
        if (somme == nombre)
        {
            Console.WriteLine(chaine);
            break;
        }
        else if (somme > nombre)
            break;
    }
}
Console.WriteLine("");
Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
Console.Read();