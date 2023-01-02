using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisme.Classes
{
    class Produit
    {
        #region Déclaration des variables
        private string nom;
        private string description;
        private int quantite;
        #endregion

        #region Constructeur
        public Produit()
        {
            
        }
        public Produit(string Nom, string Description, int Quantite)
        {
            this.nom = Nom;
            this.description = Description;
            this.quantite = Quantite;
        }
        #endregion

        #region Propriétés
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        #endregion

        #region Méthodes
        public string AfficherNom()
        {
            return Nom;
        }
        public string AfficherDescriptionProduit()
        {
            return Description;
        }
        public int AfficherQuantite()
        {
            return Quantite;
        }
        public override string ToString()
        {
            return "Nom du Produit " + Nom + " Description : " + Description + "Quantité : " + Quantite;
        }
        #endregion
    }
}
