
// Complétées en C#10 => Les structures sont des types valeur (en opposition aux classes) , une copie est donc faite lors du passage d'une structure en parametre de méthode.

using LesStructures.Structures;

PersonneStruct p = new PersonneStruct { Nom = "Di Persio", Prenom = "Anthony" };
p.Afficher();

AdresseStruct adresse = new AdresseStruct("rue de Douai", "59800");
AdresseStruct adresse2 = adresse with { CodePostal = "59650" };


Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();
