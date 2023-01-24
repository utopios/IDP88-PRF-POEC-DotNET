using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageWPF.DAO;
using TpCompteBancaireHeritageWPF.Tools;

namespace TpCompteBancaireHeritageWPF.Classes
{
    public class Compte
    {
        private int id;
        private decimal solde;
        private Client client;
        private List<Operation> operations;
        //private static int counter = 0;
        
        public Compte()
        {
           
        }

        public Compte(decimal solde, Client client) : this()
        {
            Solde = solde;
            Client = client;
        }

        public int Id { get => id; set => id = value; }
        public decimal Solde { get => solde; set => solde = value; }
        internal Client Client { get => client; set => client = value; }
        internal List<Operation> Operations { get => operations; set => operations = value; }
        //public static int Counter { get => counter; }

        public event Action<decimal, int> ADecouvert;

        public virtual bool Depot(Operation operation)
        {

            if (operation.Montant > 0)
            {
                Solde += operation.Montant;
                return true;
            }
            return false;
        }

        public virtual bool Retrait(Operation operation)
        {
            if (operation.Montant < 0)
            {
                Solde += operation.Montant;
                if (Solde < 0)
                {
                    // Déclenchement de l'event ADecouvert
                    if (ADecouvert != null)
                        ADecouvert(solde, id);
                }
                return true;

            }
            return false;
        }


        public override string ToString()
        {
            string result = $"Client : {Client}\n";
            result += $"\n\t\t\t\t\t\tSolde : {Solde} Euros";
            result += $"\n------------------- Operations -------------------\n";
            Operations.ForEach(o =>
            {
                result += $"{o}\n";
            });
            result += $"--------------------------------------------------\n";

            return result;
        }

    }
}
