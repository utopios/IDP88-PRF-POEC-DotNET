using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageWPF.DAO;

namespace TpCompteBancaireHeritageWPF.Classes
{
    internal class CompteEpargne : Compte
    {
        private decimal taux;

        public decimal Taux { get => taux; set => taux = value; }
        
        public CompteEpargne(decimal taux) 
        {
            Taux = taux;
           
        }
        public CompteEpargne(decimal solde, Client client, decimal taux) : base(solde, client)
        {
            Taux = taux;            
        }

        public decimal CalculerInteret()
        {
            return Solde * Taux / 100;
        }
    }
}
