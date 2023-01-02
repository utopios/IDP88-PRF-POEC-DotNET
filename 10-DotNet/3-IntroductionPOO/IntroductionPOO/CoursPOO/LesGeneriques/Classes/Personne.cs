using System;
using System.Collections.Generic;
using System.Text;

namespace LesGeneriques.Classes
{
    class Personne
    {
        private string prenom;
        private string numero;

        public string Prenom { get => prenom; set => prenom = value; }
        public string Numero { get => numero; set => numero = value; }
    }
}
