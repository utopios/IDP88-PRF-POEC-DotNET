using System;
using System.Collections.Generic;
using System.Text;

namespace LesStructures.Structures
{
    struct PersonneStruct
    {
        public string Nom { get; init; }
        public string Prenom { get ; init; }
      

        public PersonneStruct(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }


        public void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, Prénom: {Prenom}");
        }
    }
    struct AdresseStruct
    {
        public string Rue { get; set; }
        public string CodePostal { get; set; }

        public AdresseStruct(string rue, string codePostal)
        {
            Rue = rue;
            CodePostal = codePostal;
        }
    }
}
