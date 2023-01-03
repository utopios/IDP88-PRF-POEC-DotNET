

using ExceptionRegex.Class;

#region REGEX
string maChaine = "Anthony";

Console.WriteLine(Tools.IsName(maChaine));

// +33 6 12 34 56 78 || +33612345678 || 0612345678 || 06.12.34.56.78 || 33-6-12-34-56-78 || 33612345678
maChaine = "33612345678";

Console.WriteLine(Tools.IsPhone(maChaine));


Client c = new();
try
{
    c.Nom = "Di Persio";
    c.Prenom = "Anthony";
    c.Telephone = "+33 6 12 34 56 78";
    c.Email = "anthony@test.utopios.net";
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine(c);
}
#endregion


#region SafeDivision Exception
Console.WriteLine("----------- SafeDivision -----------");
Console.Write("Veuillez saisir un premier chffre/nombre => ");
double nb1 = 0;
while (!double.TryParse(Console.ReadLine(), out nb1))
{
    Console.WriteLine("Erreur de saisie, veuillez saisir un chiffre/nombre...");
}

double nb2 = 0;

Console.Write("Veuillez saisir un deuxième chffre/nombre => ");

while (!double.TryParse(Console.ReadLine(), out nb2))
{
    Console.WriteLine("Erreur de saisie, veuillez saisir une chiffre/nombre...");
}

double result;

try
{
    result=ExceptionTest.safeDivision(nb1,nb2);
    Console.WriteLine($"{nb1} divisé par {nb2} = {result}");
}
catch (DivideByZeroException d)
{
    Console.WriteLine(d.Message);
}

#endregion








Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();
