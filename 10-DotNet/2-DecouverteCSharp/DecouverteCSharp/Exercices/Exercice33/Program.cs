
#region Déclaration et initialisation du tableau de char
char[] alphabet = new char[26];
string chaine = "";
#endregion

#region Assignation des valeurs
for (int i = 0; i < alphabet.Length; i++)
{
    alphabet[i] = Convert.ToChar(65 + i);
}
#endregion

#region Affichage des valeurs
for (int i = 0; i < alphabet.Length; i++)
{
    Console.WriteLine(chaine + alphabet[i]);
    chaine += "  ";
}
#endregion

// Fermeture du programme
Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
Console.Read();