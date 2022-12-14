
#region Avec une variable type int (entier)
Console.Write("Veuillez saisir un nombre : ");
int premierNombre = Convert.ToInt32(Console.ReadLine());
Console.Write("Veuillez saisir un autre nombre : ");
int deuxiemeNombre = Convert.ToInt32(Console.ReadLine());
int resultat = premierNombre + deuxiemeNombre;
Console.WriteLine("La somme de ces deux nombres est : " + resultat + "\n");
//Console.WriteLine("La somme de ces deux nombres est : " + (premierNombre + deuxiemeNombre) + "\n");
#endregion

#region Avec une variable type double (décimal)
Console.Write("Veuillez saisir un nombre : ");
double premierNombreBis = Convert.ToDouble(Console.ReadLine());
Console.Write("Veuillez saisir un autre nombre : ");
double deuxiemeNombreBis = Convert.ToDouble(Console.ReadLine());
double resultatBis = premierNombreBis + deuxiemeNombreBis;
Console.WriteLine("La somme de ces deux nombres est : " + resultatBis + "\n");
#endregion




Console.Write("Appuyez sur Enter pour fermer le programme...");
Console.Read();