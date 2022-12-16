int compteur = 0;

// Création d'une boucle For qui s'executera 100 fois
for (int i = 0; i < 100; i++)
{
    // Chaque tout de boucle on incrément le compteur
    compteur++;
    // Si la valeur du compteur atteint 50
    if (compteur ==50)
    {        
        continue; // Passage à l'itération suivante
    }
    // Sinon affichage de la valeur du compeur dans la console
    Console.WriteLine(compteur);

    // Si la valeur du compteur atteint 55
    if (compteur == 55)
    {
        break; // On stope la boucle même s'il reste des itérations...
    }

}


Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();
