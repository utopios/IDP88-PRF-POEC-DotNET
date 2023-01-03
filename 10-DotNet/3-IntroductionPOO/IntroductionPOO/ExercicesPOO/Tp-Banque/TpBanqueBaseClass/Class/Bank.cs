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
