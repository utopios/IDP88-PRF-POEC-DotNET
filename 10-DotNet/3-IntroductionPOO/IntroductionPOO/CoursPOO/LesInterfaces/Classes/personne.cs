using System;
using System.Collections.Generic;
using System.Text;
using LesInterfaces.Interfaces;

namespace LesInterfaces.Classes
{
    class personne
    {
        private string nom;
        private string prenom;
        private IAdresse adresse;

        public personne(IAdresse Adresse)
        {
            this.Adresse = Adresse;
            Adresse.AdresseInformation();
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        internal IAdresse Adresse { get => adresse; set => adresse = value; }

        public override string ToString()
        {
            return $"Nom = {Nom}, Prenom = {Prenom}";
        }
    }
}
