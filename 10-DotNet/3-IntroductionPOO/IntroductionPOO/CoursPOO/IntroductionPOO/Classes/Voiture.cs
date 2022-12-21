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
        #endregion

        #region Constructeurs
        public Voiture()
        {
            Demaree = false;
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

        }

        public void Rouler()
        {

        }

        public void Stoper()
        {

        }

        public void Klaxonner()
        {

        }

        public void FaireLePlein()
        {

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
