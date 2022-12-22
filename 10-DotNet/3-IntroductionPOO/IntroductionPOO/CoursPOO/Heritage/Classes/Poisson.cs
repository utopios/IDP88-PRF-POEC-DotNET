using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Classes
{
    public class Poisson : Animal
    {
        private string nomPoisson;
        private string typePoisson;
        bool nageoires;

        public Poisson(string NomPoisson, string TypePoisson) : base(NomPoisson, TypePoisson)
        {
            this.nomPoisson = NomPoisson;
            this.typePoisson = TypePoisson;
            Nageoires = true;
        }

        public string NomPoisson { get => nomPoisson; set => nomPoisson = value; }
        public string TypePoisson { get => typePoisson; set => typePoisson = value; }
        public bool Nageoires { get => nageoires; set => nageoires = value; }

        public override void Reproduction()
        {
            Console.WriteLine("Je me reproduit en pondant des oeufs");
        }

        public override void Oxigenation()
        {
            Console.WriteLine("Mes muscles operculaires font circuler l'eau dans mes branchies");
        }

        public override void Alimentation()
        {
            Console.WriteLine("Je mange du plancton, quelques algues");
        }

        public override void Expression()
        {
            Console.WriteLine("Bloubloup...!");
        }
    }
}
