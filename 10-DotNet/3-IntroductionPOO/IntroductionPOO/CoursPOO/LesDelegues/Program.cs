
using LesDelegues.Class;

#region Avec un retour
Calculatrice c = new();

// utilisation d'une fonction locale à la class => Addition
c.Calcule(10, 20, Addition);

// Utilisation du delegate avec une méthode de soustraction anonyme (expression Lambda)
c.Calcule(30,40, delegate (double a, double b) { return a - b; });

// Utilisation du delegate avec une méthode de multiplication anonyme (expression Lambda)
c.Calcule(30, 40, (double a, double b) => { return a * b; });

// Utilisation du delegate avec une méthode de division anonyme (expression Lambda)
// Si il n'y qu'une seule instruction => les accolades sont facultative
c.Calcule(30, 40, ( a, b) =>  a / b );

#endregion

#region Délégués sans retour
c.HowToDisplay("Salut à tous!", Afficher);
#endregion



double Addition(double a, double b){return a+b;}

void Afficher(string s) { Console.WriteLine(s); }
void AfficherPlus(string s) { Console.WriteLine(s+"... et j'en affiche plus!"); }

Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();
