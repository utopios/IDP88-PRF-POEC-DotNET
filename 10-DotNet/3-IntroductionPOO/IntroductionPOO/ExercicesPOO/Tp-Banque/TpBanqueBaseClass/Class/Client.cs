using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TpBanqueBaseClass.Tools;

namespace TpBanqueBaseClass.Class
{
    public class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private static int compteur = 0;

        public Client()
        {
            id = ++compteur;
        }
        public Client(string nom, string prenom, string telephone) : this()
        {
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
                if (MyRegex.IsName(value))
                    nom = value;
                else
                    throw new FormatException("Erreur nom");
            }
        }
        public string Prenom 
        { 
            get => prenom;
            set
            {
                if (MyRegex.IsName(value))
                    prenom = value;
                else
                    throw new FormatException("Erreur prénom");
            }
        }
        public string Telephone
        {
            get => telephone;
            set
            {
                if (MyRegex.IsPhone(value))
                    telephone = value;
                else
                    throw new FormatException("Erreur Téléphone");
            }
        }
        public static int Compteur { get => compteur; set => compteur = value; }

        public override string ToString()
        {
            return $" Nom : {Nom}, Prénom : {Prenom}\n Téléphone : {Telephone}";
        }
    }
}
