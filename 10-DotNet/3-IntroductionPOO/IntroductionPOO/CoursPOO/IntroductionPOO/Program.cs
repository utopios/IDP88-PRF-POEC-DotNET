using IntroductionPOO.Classes;

static void Afficher(Voiture v)
{
    Console.WriteLine($"La voiture est une {v.Model} de couleur {v.Couleur}, avec une autonomie de {v.Autonomie}km avec un réservoir de {v.Reservoir}L.");
}

// Instanciation d'un objet voiture
//Voiture voitureDeNicolas = new Voiture();
Voiture voitureDeNicolas = new();
// Modifier les props de l'objet voitureDeNicolas
voitureDeNicolas.Model = "Clio";
voitureDeNicolas.Couleur = "Noir";
voitureDeNicolas.Reservoir = 50;
voitureDeNicolas.Autonomie = 900;

Console.WriteLine(voitureDeNicolas);

Afficher(voitureDeNicolas);


Console.WriteLine("Appuyez sur enter pour fermer le programme");
Console.Read();
