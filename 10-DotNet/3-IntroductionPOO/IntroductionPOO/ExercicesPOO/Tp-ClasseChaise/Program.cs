using Tp_ClasseChaise.Classes;

#region Chaise 1
// Création d'une instance de chaise
Chaise Chaise1 = new Chaise();
// Affectation de valeur aux Props
Chaise1.Couleur = "Bleu";
Chaise1.Materiaux = "Bois";
Chaise1.NbPieds = 4;
// Utilisation de la méthode Afficher()
Chaise1.Afficher();
#endregion

#region Chaise 2
// Création d'une instance de chaise
Chaise Chaise2 = new Chaise(4,"Blanche", "métal");

// Utilisation de la méthode Afficher()
Chaise2.Afficher();
#endregion

#region Chaise 3
// Création d'une instance de chaise
Chaise Chaise3 = new Chaise(1,"Transparente","Plexiglass");

// Utilisation de la méthode Afficher()
Chaise3.Afficher();
#endregion


#region Fin du Programme
Console.WriteLine("Appuyez sur enter pour fermer le programme");
Console.Read();
#endregion
