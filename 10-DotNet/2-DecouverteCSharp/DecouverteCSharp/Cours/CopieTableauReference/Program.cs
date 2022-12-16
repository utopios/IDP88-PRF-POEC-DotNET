#region Création d'un tableau d'entiers et itération de son contenu
Console.WriteLine("Création d'un tableau T1 et itération : ");

int[] T1 = { 1, 2, 3 };

for (int i = 0; i < T1.Length; i++)
    Console.WriteLine(T1[i]);

#endregion

#region Création d'un tableau d'entiers T2 
Console.WriteLine("Création d'un tableau T2 vide et itération : ");

int[] T2 = new int[2];

for (int i = 0; i < T2.Length; i++)
    Console.WriteLine(T2[i]);
#endregion

#region Copie des references de T1 dans T2
Console.WriteLine("\nCopie des references de T1 dans T2...");
T2 = T1;
Console.WriteLine("\nItération de T2 après copie...");
for (int i = 0; i < T2.Length; i++)
    Console.WriteLine(T2[i]);
#endregion

#region Modification de T1
Console.WriteLine("\nModification de T1[0] = 100 ");
T1[0] = 100;
Console.WriteLine("\nItération de T1 après modification...");
for (int i = 0; i < T1.Length; i++)
    Console.WriteLine(T1[i]);
Console.WriteLine("\nItération de T2 après modification...");
for (int i = 0; i < T2.Length; i++)
    Console.WriteLine(T2[i]);
#endregion

Console.WriteLine("\nAppuyez sur Enter pour fermer le programme");
Console.Read();

