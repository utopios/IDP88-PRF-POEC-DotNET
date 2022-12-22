using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Classes
{
    public class Fleur : Vegetal
    {
        private string nomFleur;
        private string typeFleur;

        public string NomFleur { get => nomFleur; set => nomFleur = value; }
        public string TypeFleur { get => typeFleur; set => typeFleur = value; }

        public Fleur(string NomFleur, string TypeFleur) : base(NomFleur, TypeFleur)
        {
            this.nomFleur = NomFleur;
            this.typeFleur = TypeFleur;
        }

        public override void Reproduction()
        {
            Console.WriteLine("J'attends le pollen d'une autre fleur...");
        }

        

        

        
    }
}
