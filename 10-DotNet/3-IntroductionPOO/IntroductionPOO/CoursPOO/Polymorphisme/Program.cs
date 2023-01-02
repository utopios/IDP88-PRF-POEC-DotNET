
#region Class Parametrique

using Polymorphisme.Classes;


Console.WriteLine(Parametriques.Additionner("14", "10"));

Console.WriteLine("Le résultat est {0}",Parametriques.Additionner(14, 10));


#endregion

#region Stock / Produits
// Instanciation de l'objet estock
Stock stock = new();

// Création d'un Produit(nom,description,quantité)
Produit p1= new Produit();
p1.Nom = "MarioParty";
p1.Description = "Jeux viéo pour nintendo Switch";
p1.Quantite = 5;

// Ajout du produit au stock
stock.AjouterProduit(p1);

// Création d'un Produit(nom,description,quantité)
Produit p2 = new Produit("Xbox","Console de jeu Microsoft", 4);

// Ajout du produit au stock
stock.AjouterProduit(p2);

stock.AjouterProduit("PS5","Console Playstation de Sony", 5);

Console.WriteLine($"Mon tableau contient {stock.AvoirStockProduit()}");




#endregion


// Fin du programme
Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
Console.Read();