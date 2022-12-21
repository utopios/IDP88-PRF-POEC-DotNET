using IntroductionPOO.Classes;

//static void Afficher(Voiture v)
//{
//    Console.WriteLine($"La voiture est une {v.Model} de couleur {v.Couleur}, avec une autonomie de {v.Autonomie}km avec un réservoir de {v.Reservoir}L.");
//}

// Instanciation d'un objet voiture
//Voiture voitureDeNicolas = new Voiture();
Voiture voitureDeNicolas = new ();
// Modifier les props de l'objet voitureDeNicolas
voitureDeNicolas.Model = "Clio";
voitureDeNicolas.Couleur = "Noir";
voitureDeNicolas.Reservoir = 50;
voitureDeNicolas.Autonomie = 900;

//Console.WriteLine(voitureDeNicolas);

//Afficher(voitureDeNicolas);

//voitureDeNicolas.Afficher();


Voiture voitureDeJeanne = new Voiture("208", "Blanche", 800, 45);
//Console.WriteLine(voitureDeJeanne);

//Afficher(voitureDeJeanne);

//voitureDeJeanne.Afficher();

Voiture[] voitures = new Voiture[] { voitureDeJeanne, voitureDeNicolas };

foreach (Voiture voiture in voitures)
{
    voiture.Afficher();
    voiture.Klaxonner();
    voiture.Demarrer();
    //voiture.Demarrer();
    voiture.Rouler();
    voiture.Klaxonner();
    voiture.Stoper();
    voiture.Rouler();
    voiture.Stoper();
    voiture.Rouler();
    voiture.Stoper();
    voiture.Rouler();
    voiture.Stoper();
    voiture.Arreter();
    voiture.Refueler(10);
    voiture.Demarrer();
    voiture.Rouler();
    voiture.Stoper();
    voiture.Arreter();
    voiture.Arreter();
    voiture.Klaxonner();

}


Console.WriteLine("Appuyez sur enter pour fermer le programme");
Console.Read();
