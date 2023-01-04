using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerializeDeserialize.Classes
{
    class Produit
    {
        private string nom;
        private double prixHt;
        private double tva;
        private double prixTtc;
        private int quantite;
        private Unite unite;

        public Produit()
        {

        }

        public Produit(string Nom, double PrixHt, double Tva, double PrixTtc, int Quantite, Unite Unite)
        {
            this.Nom = Nom;
            this.PrixHt = PrixHt;
            this.Tva = Tva;
            this.PrixTtc = PrixTtc;
            this.Quantite = Quantite;
            this.Unite = Unite;
        }

        public string Nom { get => nom; set => nom = value; }
        public double PrixHt { get => prixHt; set => prixHt = value; }
        public double Tva { get => tva; set => tva = value; }
        public double PrixTtc { get => prixTtc; set => prixTtc = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public Unite Unite { get => unite; set => unite = value; }

        public override string ToString()
        {
            return "Nom : " + Nom + " - PrixHt : " + PrixHt + "€ - Taux T.V.A : " + Tva + "% - Prix T.T.C : " + PrixTtc + "€ / " + (Unite)Unite + " - Quantité disponible :  " + Quantite + " " + (Unite)Unite;
        }
    }
    enum Unite
    {
        pieces,
        grappe,
        gr,
        kg
    }
}
