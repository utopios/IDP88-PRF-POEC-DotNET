
#region Création d'un tableau et assignation de valeur string

using System.Collections.Immutable;

Console.WriteLine("\nTableau de string");
// Déclaration d'une bvariable de type Array de string
string[] prenoms;
// Affectation des zone mémoire
prenoms = new string[5];

// itération des valeurs de prenoms
for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");

// Affectation des valeurs
prenoms[0] = "Anthony";
prenoms[1] = "Yves";
prenoms[2] = "Charles";
prenoms[3] = "Marie";
prenoms[4] = "Charles";

// itération des valeurs de prenoms
for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");
#endregion

#region Création d'un tableau et assignation de valeur int

Console.WriteLine("\nTableau d'entiers (int)");
// Déclaration d'une bvariable de type Array de string
int[] nombres;
// Affectation des zone mémoire
nombres = new int[5];

// itération des valeurs de prenoms
for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");

// Affectation des valeurs
nombres[0] = 6;
nombres[1] = 1;
nombres[2] = 5;
nombres[3] = 4;
nombres[4] = 2;

// itération des valeurs de prenoms
for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");
#endregion

#region Création d'un tableau et assignation de valeur Object

Console.WriteLine("\nTableau d'objets (object)");
// Déclaration d'une bvariable de type Array de string
object[] tabs;
// Affectation des zone mémoire
tabs = new object[5];

// itération des valeurs de prenoms
for (int i = 0; i < tabs.Length; i++)
    Console.WriteLine($"A l'index {i} : {tabs[i]}");

// Affectation des valeurs
tabs[0] = 12;
tabs[1] = 1.456F;
tabs[2] = "Message";
tabs[3] = true;
tabs[4] = 0.22336587445698M;

// itération des valeurs de prenoms
for (int i = 0; i < tabs.Length; i++)
    Console.WriteLine($"A l'index {i} : {tabs[i]}");
#endregion

#region Declaration et affectation de valeur en même temps
Console.WriteLine("\nTableau de double");
double[] doubles = { 2.2, 3.3, 4.4, 5.5 };

for (int i = 0; i < doubles.Length; i++)
    Console.WriteLine($"A l'index {i} : {doubles[i]}");

Console.WriteLine("Doubles contient : " + doubles.Length + " entrèes.");
#endregion

#region Utilisation de la méthode Sort() pour trier un tableau d'entiers en ordre croissant
Console.WriteLine("\nTri d'un tableau d'entiers Sort()");
// Affichage du contenu de Nombres
for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");

// Tri de la collection
Array.Sort(nombres);
Console.WriteLine("\nTri du tableau...\n");

// Affichage du contenu de Nombres
for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");
#endregion

#region Utilisation de la méthode Sort() pour trier un tableau de string en ordre croissant
Console.WriteLine("\nTri d'un tableau de string avec Sort()");
// Affichage du contenu de Nombres
for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");

// Tri de la collection
Array.Sort(prenoms);
Console.WriteLine("\nTri du tableau...\n");

// Affichage du contenu de Nombres
for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");
#endregion

#region Utilisation de la méthode Revers() pour inverser l'ordre d'un tableau d'entiers
Console.WriteLine("\nInvertion d'un tableau d'entiers Reverse()");
// Affichage du contenu de Nombres
for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");

// Tri de la collection
Array.Reverse(nombres);
Console.WriteLine("\nReverse du tableau...\n");

// Affichage du contenu de Nombres
for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");
#endregion

#region Utilisation de la méthode Revers() pour inverser l'ordre d'un tableau de string
Console.WriteLine("\nInvertion d'un tableau de string avec Reverse()");
// Affichage du contenu de Nombres
for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");

// Tri de la collection
Array.Reverse(prenoms);
Console.WriteLine("\nReverse du tableau...\n");

// Affichage du contenu de Nombres
for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");
#endregion

#region Utilisation de la méthode IndexOf() pour retourner l'index d'une valeur Int
Console.WriteLine("\nRechercher la position d'un nombre avec IndexOf()\n");
int index = Array.IndexOf(nombres, 3);

// Affichage du contenu de Nombres
for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");

if (index == -1)
    Console.WriteLine($"\nLe nombre 3 ne se trouve pas dans le tableau");
else
    Console.WriteLine($"\nLe nombre 3 se touve à l'index : {index}");
#endregion

#region Utilisation de la méthode IndexOf() pour retourner l'index d'une valeur string
Console.WriteLine("\nRechercher la position d'une chaine avec IndexOf()\n");
index = Array.IndexOf(prenoms, "Charles");

// Affichage du contenu de Nombres
for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");

if (index == -1)
    Console.WriteLine($"\nLe prenom Charles ne se trouve pas dans le tableau");
else
    Console.WriteLine($"\nLe premier prenom Charles se trouve à l'index : {index}");
#endregion

#region Utilisation de la méthode LastIndexOf() pour retourner le dernier index d'une valeur string
Console.WriteLine("\nRechercher la derniere position d'une chaine avec LastIndexOf()\n");
index = Array.LastIndexOf(prenoms, "Charles");

// Affichage du contenu de Nombres
for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");

if (index == -1)
    Console.WriteLine($"\nLe prenom Charles ne se trouve pas dans le tableau");
else
    Console.WriteLine($"\nLe dernier prenom Charles se trouve à l'index : {index}");
#endregion





Console.WriteLine("\nAppuyez sur Enter pour fermer le programme");
Console.Read();