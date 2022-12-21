using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionPOO.Classes
{
    internal class Voiture
    {
        #region Attributs
        private string model;
        private string couleur;
        private int autonomie;
        private int reservoir;
        private bool demaree;
        private bool roule;
        #endregion

        #region Constructeurs
        public Voiture()
        {
            Demaree = false;
            Roule = false;
        }

        public Voiture(string model, string couleur, int autonomie, int reservoir) : this()
        {
            Model = model;
            Couleur = couleur;
            Autonomie = autonomie;
            Reservoir = reservoir;
        }
        #endregion

        #region Propriètés
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > 1)
                    model = value;
                else
                    //throw new Exception("Erreur format Model");
                    Console.WriteLine("Erreur, le nom doit comporter au moins deux caractères...");
            }
        }
        public string Couleur { get => couleur; set => couleur = value; }
        public int Autonomie { get => autonomie; set => autonomie = value; }
        public int Reservoir { get => reservoir; set => reservoir = value; }
        public bool Demaree { get => demaree; set => demaree = value; }
        public bool Roule { get => roule; set => roule = value; }
        #endregion

        #region Methodes
        public void Demarrer()
        {
            if (!demaree)
            {
                demaree = true;
                Console.WriteLine("La voiture est démarée... le moteur tourne");
            }            
            else
                Console.WriteLine("La voiture est déjà démarée ! ! !");
        }

        public void Arreter()
        {
            if (demaree)
            {
                if (Roule)
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
            if (demaree)
            {
                if (!roule)
                {
                    if (Reservoir >= 10)
                    {
                        Console.WriteLine("La voiture roule...");
                        roule = true;
                        reservoir -= 10;
                        Console.WriteLine("il vous reste " + Reservoir + " litres de carburants");
                    }
                    else
                    {
                        Console.WriteLine("Il n'y a plus assez de carburant, faites le plein");
                    }
                }
                else
                    Console.WriteLine("Le véhicule roule déjà!");

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
                Roule = false;
            }
            else
            {
                Console.WriteLine("La voiture n'est pas en train de rouler!");
            }
        }

        public void Refueler(int nbLitre)
        {
            if (!Roule)
            {
                if (!demaree)
                {
                    Console.WriteLine($"Nous ajoutons {nbLitre}L au réservoir...");
                    reservoir += nbLitre;
                }
                else
                {
                    Console.WriteLine("Vous devez arreter le moteur avant de faire le plein.");
                }
            }
            else
            {
                Console.WriteLine("Vous devez arrêter le véhicule pour faire le plein");
            }
        }

        public void Klaxonner()
        {
            Console.WriteLine("Pouet! Pouet!!!");
        }

        public void Afficher()
        {
            Console.WriteLine($"La voiture est une {Model} de couleur {Couleur}, avec une autonomie de {Autonomie}km avec un réservoir de {Reservoir}L.");
        }

        public override string ToString()
        {
            return $"Model : {Model} => Couleur : {Couleur} - Range : {Autonomie} km - Réservoir : {Reservoir}L";
        }
        #endregion
    }
}
