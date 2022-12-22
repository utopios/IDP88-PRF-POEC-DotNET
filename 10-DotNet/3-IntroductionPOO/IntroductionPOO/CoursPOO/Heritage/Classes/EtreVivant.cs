using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Classes
{
    public class EtreVivant
    {
        bool vivant;
        private string nom;
        private string type;

        public EtreVivant(string Nom, string Type)
        {
            this.nom = Nom;
            this.type = Type;
        }

        public bool Vivant { get => vivant; set => vivant = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Type { get => type; set => type = value; }

        public virtual void Naissance()
        {
            Console.WriteLine("Tous les êtres vivant naissent...");
            Vivant = true;
        }

        public virtual void Mort()
        {
            Console.WriteLine("Tous les êtres vivant meurent...");
            Vivant = false;
        }

        public virtual void Reproduction()
        {
            Console.WriteLine("Tous les êtres vivant se reproduisent...");
        }

        public virtual void Alimentation()
        {
            Console.WriteLine("Tous les êtres vivant doivent manger...");
        }

        public virtual void Expression()
        {
            Console.WriteLine("Tous les êtres vivant s'expriment...");
        }

        public virtual void Oxigenation()
        {
            Console.WriteLine("Tous les êtres vivant doivent s'oxigèner...");
        }

        public override string ToString()
        {
            return "Je suis un être vivant de type "+ Type + " et je m'appelle " + Nom;
        }
    }
}
