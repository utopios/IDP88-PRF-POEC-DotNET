using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanqueBaseClass.Class
{
    public class Bank
    {
        private List<Compte> comptes;

        public Bank()
        {
            Comptes = new List<Compte>();
        }

        public List<Compte> Comptes { get => comptes; set => comptes = value; }

        public void Injecter()
        {
            Client c1 = new("Di Persio", "Anthony", "+33 6 12 34 56 78");
            Client c2 = new("Abadi", "Ihab", "+33 6 98 76 54 32");
            Client c3 = new("Abadi", "Marine", "+33 6 41 52 63 78");

            Compte Compte1 = new(100, c1);
            Operation o1 = new(75);
            Operation o2 = new(-50);
            Compte1.Depot(o1);
            Compte1.Retrait(o2);
            Comptes.Add(Compte1);
            Compte Compte2 = new CompteEpargne(100, c2, 4);
            Operation o3 = new(75);
            Operation o4 = new(-50);
            Compte2.Depot(o3);
            Compte2.Retrait(o4);
            Comptes.Add(Compte2);
            Compte Compte3 = new ComptePayant(100, c3, 2);
            Operation o5 = new(75);
            Operation o6 = new(-50);
            Compte3.Depot(o5);
            Compte3.Retrait(o6);
            Comptes.Add(Compte3);
        } 

        public bool AjouterCompte(Compte compte)
        {
            int nb1 = Comptes.Count;
            Comptes.Add(compte);
            int nb2 = Comptes.Count;
            return nb2 - nb1 == 1;
        }

        public Compte RechercherCompte(int id)
        {
            return Comptes.Find(compte => compte.Id == id);
        }

    }
}
