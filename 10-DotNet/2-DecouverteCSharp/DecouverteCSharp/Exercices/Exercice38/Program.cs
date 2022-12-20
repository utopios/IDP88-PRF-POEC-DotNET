
Console.WriteLine("--- Où est passé mon numéros ? ---");
int[] tab = new int[10];
Random aleatoire = new Random();
string chaine = "";
int nb = 0;
int index;
Console.WriteLine("Affectation des valeures... \n");
for (int i = 0; i < tab.Length; i++)
    tab[i] = aleatoire.Next(1, 51);

Console.WriteLine("Affichage avant triage : ");
foreach (var i in tab)
{
    Console.WriteLine(chaine + i);
    chaine += "  ";
}
nb = tab[0];
Array.Sort(tab);
chaine = " ";
Console.WriteLine("Après : ");
foreach (var i in tab)
{
    Console.WriteLine(chaine + i);
    chaine += "  ";
}
index = Array.IndexOf(tab, nb) + 1;
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Le nombre {0} se trouvait en 1ère position", nb);
Console.WriteLine("Il se retrouve à la position {0} après triage.", index);
Console.Read();