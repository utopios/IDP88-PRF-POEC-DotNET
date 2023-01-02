using System;
using System.Collections.Generic;
using System.Text;


namespace LesGeneriques.Classes
{
    class Voiture
    {
        private string model;
        private string couleur;
        private int reservoir;
        private int autonomie;
        private bool demaree;
        private bool roule;

        public Voiture()
        {

        }

        public Voiture(string Model, string Couleur, int Reservoir, int Autonomie)
        {
            this.model = Model;
            this.couleur = Couleur;
            this.reservoir = Reservoir;
            this.autonomie = Autonomie;
            this.demaree = false;
            this.roule = false;
        }
        // Exemple de vérification
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > 2)
                {
                    model = value;
                }
                else
                    //throw new Exception("Erreur Model");
                    Console.WriteLine("Erreur, le nom doit comporter au moins deux caractères");
            }
        }
        public string Couleur { get => couleur; set => couleur = value; }
        public int Reservoir { get => reservoir; set => reservoir = value; }
        public int Autonomie { get => autonomie; set => autonomie = value; }
        public bool Demaree { get => demaree; }
        public bool Roule { get => roule; }

        public override string ToString()
        {
            return "Voiture : " + model + " " + couleur + ", Reservoir : " + reservoir + " L " + autonomie + " km";
        }
        public void Klaxonner()
        {
            Console.WriteLine("Pouet! Pouet!!!");
        }
        public void Demarrer()
        {
            if (!demaree)
            {
                demaree = true;
                Console.WriteLine("La voiture est démarée... le moteur tourne!");
            }
            else
            {
                Console.WriteLine("La voiture est déja démarée ! ! ! ");
            }
        }
        public void Arreter()
        {
            if (demaree)
            {
                if (roule)
                {
                    Console.WriteLine("La voiture roule, vous ne pouvez pas arréter le moteur !!!");
                }
                else
                {
                    demaree = false;
                    Console.WriteLine("Le moteur est arrété!");
                }                
            }
            else
            {
                Console.WriteLine("La moteur ne tourne pas ! ! ! ");
            }
        }
        public void Rouler()
        {
            if (Demaree)
            {
                if (Reservoir >= 10)
                {
                    Console.WriteLine("La voiture roule...");
                    roule = true;
                    Reservoir = Reservoir - 10;
                    Console.WriteLine("il vous reste " + Reservoir +" litres de carburants");
                }
                else
                {
                    Console.WriteLine("Il n'y a plus assez de carburant, faites le plein");
                }
            }
            else
            {
                Console.WriteLine("Le moteur est arreté, il faut demarrer la voiture avant!");
            }            
        }
        public void Stoper()
        {
            if (Roule)
            {
                Console.WriteLine("La voiture s'est arrétée de rouler.");
                roule = false;
            }
            else
            {
                Console.WriteLine("La voiture n'est pas en train de rouler!");
            }
        }        
    }    
}
