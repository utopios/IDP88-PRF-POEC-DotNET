using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Classes
{
    public sealed class Chien : Mammifere
    {
        private string nomChien;
        private string typeChien;

        public Chien(string NomChien, string TypeChien) : base(NomChien, TypeChien)
        {
            this.nomChien = NomChien;
            this.typeChien = TypeChien;
        }

        public string NomChien { get => nomChien; set => nomChien = value; }
        public string TypeChien { get => typeChien; set => typeChien = value; }

        public override void Alimentation()
        {
            base.Alimentation();
            Console.WriteLine("Je mange des croquettes pour chien!");
        }
        public void Aboyer()
        {
            Console.WriteLine("Wouaf! Wouaf !");
        }

        public override string ToString()
        {
            return base.ToString() + " avec un truc en plus...";
        }
    }
}
