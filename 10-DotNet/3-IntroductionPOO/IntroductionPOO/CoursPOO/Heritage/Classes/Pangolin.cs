using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Classes
{
    class Pangolin : Mammifere
    {
        private string nomPangolin;
        private string typePangolin;

        public Pangolin(string nomPangolin, string typePangolin) : base (nomPangolin, typePangolin)
        {
            this.nomPangolin = nomPangolin;
            this.typePangolin = typePangolin;
        }

        public string NomPangolin { get => nomPangolin; set => nomPangolin = value; }
        public string TypePangolin { get => typePangolin; set => typePangolin = value; }

        public override void Alimentation()
        {
            Console.WriteLine("Je mange des fourmis et des thermites...");
        }
        public override void Expression()
        {
            Console.WriteLine("Heuu......");
        }
        public void Contaminer()
        {
            Console.WriteLine("Ca pour contaminier... Je contamine!\n Je paralyse le monde!!!");
        }
    }
}
