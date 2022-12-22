using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Classes
{
    public class Animal : EtreVivant
    {
        private protected bool battementCoeur;
        private string nom;
        private string type;
        public Animal(string nomAnimal, string typeAnimal) : base(nomAnimal,typeAnimal)
        {
            this.nom = nomAnimal;
            this.type = typeAnimal;
        }

        public bool BattementCoeur { get => battementCoeur; set => battementCoeur = value; }
        

        public override void Naissance()
        {
            BattementCoeur = true;
            Console.WriteLine("Mon coeur bat ! Je suis vivant !");
        }

        public override void Mort()
        {
            BattementCoeur = false;
            Console.WriteLine("Mon coeur à cessé de battre ! Je suis mort !");
        }
    }
}
