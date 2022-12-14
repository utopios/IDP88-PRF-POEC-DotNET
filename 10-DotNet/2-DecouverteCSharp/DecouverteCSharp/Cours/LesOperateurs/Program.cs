#region Addition
// Opérateur + avec des valeurs numériques
int nb1 = 10, nb2 = 20;
int somme = nb1 + nb2; // =30

Console.WriteLine($"La somme de {nb1} + {nb2} est égal à {somme}.");

// Avec opérateurs combinés
somme += nb2; // =50
Console.WriteLine($"La somme de {nb1+nb2} + {nb2} est égal à {somme}.");

// Opérateur d'incrémentation ++
Console.WriteLine($"Si je rajoute 1 à {somme} alors la nouvelle valeur est {++somme}."); // 51

#endregion

#region Soustraction
// Opérateur - avec des valeurs numériques
somme = nb1 - nb2; // =-10

Console.WriteLine($"La somme de {nb1} - {nb2} est égal à {somme}.");

// Avec opérateurs combinés
somme -= nb2; // =-30
Console.WriteLine($"La somme de {nb1 - nb2} - {nb2} est égal à {somme}.");

// Opérateur d'incrémentation ++
Console.WriteLine($"Si je soustrait 1 à {somme} alors la nouvelle valeur est {--somme}."); //-31

#endregion

#region multiplication
// Opérateur * avec des valeurs numériques
somme = nb1 * nb2; // =200

Console.WriteLine($"La somme de {nb1} x {nb2} est égal à {somme}.");

// Avec opérateurs combinés
somme *= nb2; // =4000
Console.WriteLine($"La somme de {nb1 * nb2} x {nb2} est égal à {somme}.");

#endregion

#region division
// Opérateur / avec des valeurs numériques
double nb3 = 10.00, nb4 = 20.00;
double sommeDouble;
sommeDouble = nb3 / nb4; // =0,5

Console.WriteLine($"La somme de {nb3} / {nb4} est égal à {sommeDouble}.");

// Avec opérateurs combinés
sommeDouble /= nb4; // =0,025
Console.WriteLine($"La somme de {nb3 / nb4} / {nb4} est égal à {sommeDouble}.");

#endregion

#region modulo
// Opérateur % avec des valeurs numériques
somme = nb2 % nb1;

Console.WriteLine($"{nb2} modulo {nb1} est égal à {somme}.");
#endregion




Console.WriteLine("\nAppuyez sur ENTER pour fermer le programme...");
Console.Read();
