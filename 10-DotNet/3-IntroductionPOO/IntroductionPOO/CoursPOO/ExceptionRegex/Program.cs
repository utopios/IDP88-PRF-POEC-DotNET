

using ExceptionRegex.Class;

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








Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();
