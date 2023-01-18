using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DécouverteWPF.Models
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;

        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return $"Nom : {Nom} - Prénom : {Prenom} -  Age : {Age}";
        }
    }
}
