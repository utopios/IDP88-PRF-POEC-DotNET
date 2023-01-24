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
    public class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
       
        public Client()
        {
            
        }
       

        public Client(string nom, string prenom, string telephone) :this()
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }

   
        public override string ToString()
        {
            return $"Id: {Id} - Nom : {Nom}, Prénom :{Prenom}, Téléphone : {Telephone}";
        }       
    }
}
