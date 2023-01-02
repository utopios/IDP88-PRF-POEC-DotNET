using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisme.Classes
{
    class Stock
    {
        #region Déclaration des variables
        private Produit[] produits;
        private Produit produit;
        #endregion

        #region Constructeur
        public Stock()
        {
            Produits = new Produit[0];
        }
        #endregion

        #region Propriétés
        public Produit[] Produits { get => produits; set => produits = value; }
        public Produit Produit { get => produit; set => produit = value; }
        #endregion

        #region Méthodes
        public void AjouterProduit(string NomProduit, string DescriptionProduit, int Quantite)
        {
            produit = new Produit(NomProduit, DescriptionProduit, Quantite);
            Produit[] tmp = new Produit[Produits.Length + 1];
            Produits.CopyTo(tmp, 0);            
            tmp[tmp.Length - 1] = produit;
            Produits = new Produit[tmp.Length];
            tmp.CopyTo(Produits, 0);
            Console.WriteLine("Le produit {0} viens d'être ajouté au stock." + Environment.NewLine, NomProduit);
        }
        public void AjouterProduit(Produit p)
        {
            Produit[] tmp = new Produit[Produits.Length + 1];
            Produits.CopyTo(tmp, 0);            
            tmp[tmp.Length - 1] = p;
            Produits = new Produit[tmp.Length];
            tmp.CopyTo(Produits, 0);
            Console.WriteLine("Le produit {0} viens d'être ajouté au stock." + Environment.NewLine, p.Nom);
        }
        public void AfficherStock()
        {
            Console.WriteLine("---------------------- Affichage du Stock ----------------------" + Environment.NewLine);
            for (int i = 0; i < Produits.Length; i++)
            {
                Console.WriteLine("*** Produit n°{0} ***", i + 1);
                Console.WriteLine("Nom du produit : {0}", Produits[i].AfficherNom());
                Console.WriteLine("Description du produit : {0}", Produits[i].AfficherDescriptionProduit());
                Console.WriteLine("Quantité de produit(s) disponible : {0} unité(s)" +Environment.NewLine, Produits[i].AfficherQuantite());
            }
            Console.WriteLine("----------------------------------------------------------------" + Environment.NewLine);
        }
        public void SupprimerProduit(Produit p)
        {
            int index = Array.IndexOf(produits, p);
            if (index < 0)
                Console.WriteLine("Produit non trouvé");
            else
            {
                Produit[] tmp = new Produit[Produits.Length - 1];
                for (int i = 0; i < Produits.Length; i++)
                {
                    if (i < index)
                        tmp[i] = Produits[i];
                    else if (i == index)
                    {
                        Console.WriteLine("Le produit {0} a été suprimmé" +Environment.NewLine, p.Nom);
                    }
                    else
                        tmp[i - 1] = Produits[i];
                }
                Produits = new Produit[tmp.Length];
                tmp.CopyTo(Produits, 0);
            }
        }
        public void SupprimerProduit(string Nom)
        {
            int index = -1;
            for (int i=0; i< Produits.Length; i++)
            {
                if (Produits[i].Nom == Nom)
                    index = i;                    
            }            
            if (index < 0)
                Console.WriteLine("Produit non trouvé");
            else
            {
                Produit[] tmp = new Produit[Produits.Length - 1];
                for (int i = 0; i < Produits.Length; i++)
                {
                    if (i < index)
                        tmp[i] = Produits[i];
                    else if (i == index)
                    {
                        Console.WriteLine("Le produit {0} a été suprimmé" + Environment.NewLine, Nom);
                    }
                    else
                        tmp[i - 1] = Produits[i];
                }
                Produits = new Produit[tmp.Length];
                tmp.CopyTo(Produits, 0);
            }
        }
        public string AvoirStockProduit()
        {
            int stock = Produits.Length;
            return stock.ToString();
        }
        #endregion
    }
}
