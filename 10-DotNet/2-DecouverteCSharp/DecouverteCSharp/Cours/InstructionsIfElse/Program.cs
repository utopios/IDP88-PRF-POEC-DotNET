// Utilisation du charset UTF-8
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Récupération de la valeur du compte
Console.Write("Veuillez saisir le montant du compte en banque : ");
double compteEnBanque = Convert.ToDouble(Console.ReadLine());

#region If... Else....
// Structure if avec une seule condition
if (compteEnBanque > 0)
    Console.WriteLine("Votre compte en banque est créditeur...");

// Structure if avec plusieurs instructions
if (compteEnBanque > 0)
{
    Console.WriteLine("Votre compte en banque est créditeur...");
    Console.WriteLine($"Solde restant : {compteEnBanque}€");
}

// Plusieurs vérifications (Plusieurs test logiques)
if (compteEnBanque > 0)
    Console.WriteLine("Votre compte en banque est créditeur...");
if (compteEnBanque == 0)
    Console.WriteLine("Le solde de votre compte est nul...");
if (compteEnBanque < 0)
    Console.WriteLine("Votre compte en banque est débiteur...");


// Plusieurs vérifications avec cas par defaut
if (compteEnBanque > 0)
    Console.WriteLine("Votre compte en banque est créditeur...");
if (compteEnBanque == 0) // Utilité du Else...if...
    Console.WriteLine("Le solde de votre compte est nul...");
else
    Console.WriteLine("Votre compte en banque est débiteur...");

// Plusieurs vérifications (boucles imbriquées)
if (compteEnBanque > 0)
{
    Console.WriteLine("Votre compte en banque est créditeur...");
}
else
{
    if (compteEnBanque == 0)
    {
        Console.WriteLine("Le solde de votre compte est nul...");
    }
    else
    {
        Console.WriteLine("Votre compte en banque est débiteur...");
    }

}
#endregion


#region If... ElseIf... Else...

// Avec une seule instruction
if (compteEnBanque > 0)
    Console.WriteLine("Votre compte en banque est créditeur...");
else if (compteEnBanque == 0)
    Console.WriteLine("Le solde de votre compte en banque est nul...");
else
    Console.WriteLine("Votre compte en banque est débiteur...");


// Avec Blocks d'instructions
if (compteEnBanque > 0)
{
    Console.WriteLine("Votre compte en banque est créditeur...");
    Console.WriteLine($"Solde restant : {compteEnBanque}€");
}
else if (compteEnBanque == 0)
{
    Console.WriteLine("Le solde de votre compte en banque est nul...");
    Console.WriteLine($"Solde restant : {compteEnBanque}€");
}
else
{
    Console.WriteLine("Votre compte en banque est débiteur...");
    Console.WriteLine($"Solde restant : {compteEnBanque}€");
}
#endregion


Console.WriteLine("\nAppuyez sur Enter pour fermer le programme...");
Console.Read();
