/**
 * Foreach => Lesture Seule
 */


#region Foreach avec des types integer
Console.WriteLine("Création d'un tableau d'entiers");
int[] T1 = { 1, 2, 3, 4, 5 };
Console.WriteLine("Itération du tableau T1");
foreach (int nombre in T1)
{
    //if (nombre % 2 == 0)
    //{
    //    nombre = 100;
    //} // Nombre ne contien pas les valeur du tableau mais représente notre variable d'itération
    Console.WriteLine(nombre);
}

#endregion


#region Foreach avec des types integer
Console.WriteLine("Création d'un tableau de chaînes de caractères");
string[] T2 = { "1", "2", "3", "4", "5" };
Console.WriteLine("Itération du tableau T2");
foreach (string valeur in T2)
{
    Console.WriteLine(valeur);
}

#endregion



Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
Console.Read();
