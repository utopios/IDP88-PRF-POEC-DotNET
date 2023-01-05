

using ExtentionMethode.Class;
#region Additionner (int et Double)

int a = 10;
int b = 20;
int c;

// Acces à la méthode par une instance de class
c = Extention.Additionner(a, b);


// Acces à la méthode par une instance d'objet
c = a.Additionner(b);

Console.WriteLine(c);


double d = 3.25;
double e = 4.75;

double f = d.Additionner(e);

Console.WriteLine(f);
#endregion

#region Extention Class List<T>
List<int> liste = new List<int>() { 1, 2, 3, 4, 5, 6 };
liste.Shuffle();

foreach (int i in liste)
{
    Console.WriteLine(i);
}
#endregion



Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();
