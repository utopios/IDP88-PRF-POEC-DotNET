using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionPOO.Classes
{
    internal class Voiture : object
    {
        // Attributs (privée)
        private string model;
        private string couleur;
        private int autonomie;
        private int reservoir;

        public Voiture()
        {

        }

        public Voiture(string model, string couleur, int autonomie, int reservoir)
        {
            Model = model;
            Couleur = couleur;
            Autonomie = autonomie;
            Reservoir = reservoir;
        }


        // Propriètés (Publique)
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


        public override string ToString()
        {
            return $"Model : {Model} => Couleur : {Couleur} - Range : {Autonomie} km - Réservoir : {Reservoir}L";
        }
    }
}
