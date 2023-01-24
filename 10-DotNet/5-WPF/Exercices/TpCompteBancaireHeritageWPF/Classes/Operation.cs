using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageWPF.DAO;
using TpCompteBancaireHeritageWPF.Tools;

namespace TpCompteBancaireHeritageWPF.Classes
{
    public class Operation
    {
        private int id;
        private DateTime date;
        private decimal montant;

       
        public Operation()
        {
            Date = DateTime.Now;         
        }

        public Operation(decimal montant) : this()
        {
            this.Montant = montant;
        }

        public int Id { get => id; set => id = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime Date { get => date; set => date = value; }

        
        public override string ToString()
        {
            return $"Id: {Id} - Date : {Date}, montant : {Montant}";
        }
    }
}
