using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpClassSalarie.Classes
{
    public class Salarie
    {
        private int id;
        private string matricule;
        private string categorie;
        private string service;
        private string nom;
        private decimal salaire;
        private static int counter = 0;
        private static decimal totalSalaires = 0;

        public Salarie()
        {
            id = ++counter;
        }

        public Salarie(string name) : this()
        {
            Nom = name;
        }
        public Salarie(string matricule, string categorie, string service, string nom, decimal salaire) : this(nom)
        {
            Matricule = matricule;
            Categorie = categorie;
            Service = service;
            Salaire = salaire;
            TotalSalaires += salaire;
        }

        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal Salaire { get => salaire; set => salaire = value; }
        public int Id { get => id; set => id = value; }
        public static int Counter { get => counter; set => counter = value; }
        public static decimal TotalSalaires { get => totalSalaires; set => totalSalaires = value; }

        public virtual void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire fixe de {Nom} est de {Salaire}€");
        }

        public static void AfficherSommeSalaire()
        {
            Console.WriteLine($"Le montant total des salaires mensuels est de {TotalSalaires}€");
        }

        public static void DisplayCounter()
        {
            Console.WriteLine($"Le nombre de salarié : {Counter}");
        }
        
        public static void ResetCounter(int value = 0)
        {
            Counter = value;
        }

        ~Salarie()
        {
            Console.WriteLine("Destruction...");
        }

    }
}
