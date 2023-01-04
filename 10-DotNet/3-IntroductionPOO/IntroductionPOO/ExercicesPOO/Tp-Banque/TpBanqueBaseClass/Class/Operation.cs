using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanqueBaseClass.Class
{
    public class Operation
    {
        private int id;
        private decimal montant;
        private DateTime dateOperation;
        private static int counter = 0;

        public Operation(decimal montant)
        {
            Id = ++counter;
            Montant = montant;
            DateOperation = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateOperation { get => dateOperation; set => dateOperation = value; }

        public override string ToString()
        {
            return $"Id:{(Id<10?"0"+Id:Id)}, Date:{DateOperation} - Montant: {Montant}€";
        }
    }
}
