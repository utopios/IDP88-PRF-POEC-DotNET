using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanqueBaseClass.Class
{
    public class Compte
    {
        private int id;
        private decimal solde;
        private Client client;
        private List<Operation> operations;

        public Compte(decimal solde, Client client)
        {
            Solde = solde;
            Client = client;
            Operations = new List<Operation>();
        }

        public int Id { get => id; set => id = value; }
        public decimal Solde { get => solde; set => solde = value; }
        public Client Client { get => client; set => client = value; }
        public List<Operation> Operations { get => operations; set => operations = value; }


        public virtual bool Depot(Operation operation)
        {
            if (operation.Montant > 0)
            {
                Operations.Add(operation);
                Solde += operation.Montant;
                return true;
            }
            return false;
        }

        public virtual bool Retrait(Operation operation)
        {
            if (operation.Montant < 0)
            {
                Operations.Add(operation);
                Solde += operation.Montant;
                if (Solde < 0)
                {
                    // Notification de découvert
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string chaine  = $"----------------- Compte N°{Id} -----------------";
            chaine += $"Client: {Client}\n";
            chaine += $"\n\t\t\t\t\t\tSolde: : {Solde}€";
            chaine += $"--------------- listes Opérations ---------------";
            foreach (Operation o in Operations)
            {
                chaine += $"{o}\n";
            }
            chaine += $"-------------------------------------------------";
            return chaine;
        }
    }
}
