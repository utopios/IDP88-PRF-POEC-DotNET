
#region Carré

Console.WriteLine("--- Calcul du périmètre et de l'aire d'un carré ---" + Environment.NewLine);

Console.Write("Entrez la longeur d'un coté du carré (en cm) : ");
double longeurCote = Convert.ToDouble(Console.ReadLine());

double perimetre = longeurCote * 4;
double aire = longeurCote * longeurCote;

Console.WriteLine("Le périmètre du carré est : " + perimetre + " cm");
Console.WriteLine("L'aire du carré est : " + aire + " cm²\n");

#endregion



#region Rectangle

Console.WriteLine("--- Calcul du périmètre et de l'aire d'un rectangle ---" + Environment.NewLine);

Console.Write("Entrez la longeur du rectangle (en cm) : ");
double longeur = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la largeur du rectangle (en cm) : ");
double largeur = Convert.ToDouble(Console.ReadLine());

double perimetreRect = Math.Round(longeur * 2 + largeur * 2, 2);
double aireRect = Math.Round(longeur * largeur, 2);

Console.WriteLine("Le périmètre du rectangle est : " + perimetreRect + " cm");
Console.WriteLine("L'aire du carré est : " + aireRect + " cm²\n");
#endregion

Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();