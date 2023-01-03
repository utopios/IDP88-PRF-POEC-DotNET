using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionRegex.Class
{
    internal class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string email;

        public Client()
        {

        }

        public Client(int id, string nom, string prenom, string telephone)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string Nom
        {
            get => nom;
            set
            {
                if (Tools.IsName(value))
                    nom = value;
                else
                    throw new FormatException("Erreur format nom.");
            }
        }
        public string Prenom
        {
            get => prenom;
            set
            {
                if (Tools.IsName(value))
                    prenom = value;
                else
                    throw new FormatException("Erreur format prénom.");
            }
        }
        public string Telephone 
        {
            get => telephone;
            set
            {
                if (Tools.IsPhone(value))
                    telephone = value;
                else
                    throw new FormatException("Erreur format téléphone.");
            }
        }

        public string Email 
        { 
            get => email;
            set
            {
                if (Tools.IsEmail(value))
                    email = value;
                else
                    throw new FormatException("Erreur format Email.");
            }
        }

        public override string ToString()
        {
            return $"Nom : {Nom} - Prénom : {Prenom} - Téléphone : {Telephone} - Email : {Email}";
        }
    }
}
