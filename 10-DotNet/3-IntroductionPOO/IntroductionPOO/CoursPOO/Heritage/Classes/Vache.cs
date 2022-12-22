using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Classes
{
    public class Vache : Mammifere
    {
        private string nomVache;
        private string typeVache;

        public string NomVache { get => nomVache; set => nomVache = value; }
        public string TypeVache { get => typeVache; set => typeVache = value; }

        public Vache(string NomVache, string TypeVache) : base(NomVache, TypeVache)
        {
            this.NomVache = NomVache;
            this.TypeVache = TypeVache;
        }

        public override void Alimentation()
        {
            Console.WriteLine("Je rumine... je mange de l'herbe!");
        }
        public override void Expression()
        {
            Console.WriteLine("Meuhhhhhhh !");
        }

        public override string ToString()
        {
            return "Je suis une vache de race " + TypeVache + " et je m'appelle " + NomVache;
        }
    }
}
