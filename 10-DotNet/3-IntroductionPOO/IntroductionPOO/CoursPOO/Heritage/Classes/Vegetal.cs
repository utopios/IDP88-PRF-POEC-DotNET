using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Classes
{
    public class Vegetal : EtreVivant
    {
        private string nomVegetal;
        private string typeVegetal;

        public string TypeVegetal { get => typeVegetal; set => typeVegetal = value; }
        public string NomVegetal { get => nomVegetal; set => nomVegetal = value; }

        public Vegetal(string NomVegetal, string TypeVegetal) : base(NomVegetal, TypeVegetal)
        {
            this.nomVegetal = NomVegetal;
            this.typeVegetal = TypeVegetal;
        }
        public override void Mort()
        {
            Console.WriteLine("Je fanne...");
            Vivant = false;
        }
        public override void Naissance()
        {
            Console.WriteLine("Je pousse du bas vers le haut...");
            Vivant = true;
        }
        public override void Expression()
        {
            Console.WriteLine("...");
        }
        public override void Alimentation()
        {
            Console.WriteLine("Je me nourris par les racines");
        }
        public override void Oxigenation()
        {
            Console.WriteLine("La nuit je rejette du gaz carbonique. Le jour, je photosynthèse...");
        }
    }
}
