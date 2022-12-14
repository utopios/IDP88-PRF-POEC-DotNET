

#region Les Chaines de caractères
// Les chaines sont de type string
// Déclaration d'une variable string
using System.Threading.Channels;

string prenom;
// Affectation de valeur à la variable string
prenom = "Anthony";
// Déclaration et affectation de valeur en une instruction
string nom = "Di Persio";

// Afectation de valeur a nom2 avec la valeur de nom (valeur et non ref)
string nom2 = nom;

// Test logique Les valeur sont elle identiques ?
Console.WriteLine(nom == nom2);
// Modificication de la valeur de nom2
Console.Write("Veuillez saisir une nouvelle valeur pour nom2 : ");
// nom2 = Console.ReadLine();
nom2 = "Titi";
// Test logique Les valeur sont elle identiques ?
Console.WriteLine(nom == nom2);

// Affichage avec surcharge de la méthode WriteLine
Console.WriteLine("Mon nom complet est {0} {1}.", prenom, nom);
// Affichage avec les litteraux de gabarits
Console.WriteLine($"Mon nom complet est {prenom} {nom}.");

// Affichage du premier caractere d'une chaine
Console.WriteLine(prenom[0]);

#endregion

#region Les variables numeriques
// Les nombres entiers sont de type int => integer
// Déclaration d'une variable int
int age;
// Affectation de valeur à la variable int
age = 25;
// Déclaration et affectation de valeur en une instruction
Console.Write("Veuillez saisir votre age : ");
int age2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Avec affectation de valeur à la création : ");
// Affichage avec les litteraux de gabarits
Console.WriteLine($"Mon age est de {age} ans.");
Console.WriteLine($"Dans une an, j'aurai {age + 1} ans.");

Console.WriteLine("Avec affectation de valeur par un Console.ReadLine(): ");
// Affichage avec les litteraux de gabarits
Console.WriteLine($"Mon age est de {age2} ans.");
Console.WriteLine($"Dans une an, j'aurai {age + 1} ans.");

// Les nombres décimaux sont de type float ,double, decimal

Console.WriteLine("Veuillez saisir un nombre décimal: ");
double nb = Convert.ToDouble(Console.ReadLine());

float nb1 = 3.1416F;
double nb2 = 3.1416;
decimal nb3 = 3.14159265358979323846264338327950288419716939937510582M;

Console.WriteLine(nb);
Console.WriteLine(nb1.GetType());
Console.WriteLine(nb2.GetType());
Console.WriteLine(nb3.GetType());

#endregion

#region Les variables de type Object
// Declaration
object monObjet;

// Initialisation et affectation de valeur
monObjet = "Ma chaine Objet";

Console.WriteLine(monObjet);
#endregion


Console.WriteLine("\nAppuyez sur ENTER pour fermer le programme...");
Console.Read();


