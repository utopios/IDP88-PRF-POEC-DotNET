
#region Variables
int[] tab = new int[10];
Random r = new Random();
#endregion

#region Initialisation du tableau
Console.WriteLine("Insertion des valeurs du tableau :");
for (int i = 0; i < tab.Length; i++)
{
    #region Saisie utilisateur
    Console.Write("Saisir la valeur {0} : ", i + 1);
    while (!int.TryParse(Console.ReadLine(), out tab[i]))
        Console.Write("Erreur lors de la saisie, veuillez réessayer : ");
    #endregion

    #region Remplissage automatique
   //tab[i] = r.Next(1, 501);
    #endregion
}
#endregion

#region Affichage du tableau
for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine(new String('\t', i) + tab[i]);
}
#endregion

#region Fin du programme
Console.WriteLine("\nAppuyez sur une touche pour fermer le programme...");
Console.ReadLine();
#endregion