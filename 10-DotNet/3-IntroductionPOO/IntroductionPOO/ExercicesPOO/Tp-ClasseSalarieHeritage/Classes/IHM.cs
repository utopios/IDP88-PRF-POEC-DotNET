using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpClassSalarie.Classes;

namespace Tp_ClasseSalarieHeritage.Classes
{
    internal class IHM
    {
        private Salarie[] employes;
        private int maxEmployes = 20;

        public IHM()
        {
            employes = new Salarie[maxEmployes];
        }

        public void Start()
        {
            string choix = "";

            do
            {
                bool valid = false;
                MenuPrincipal();
                Console.Write("Entrez votre choix : ");
                choix = Console.ReadLine();
                while (!valid)
                {
                    if (choix != "1" && choix != "2" && choix != "3" && choix != "0")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Erreur de saisie, entrez votre choix : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        choix = Console.ReadLine();
                    }
                    else
                        valid = true;
                }
                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        ActionCreationEmployes();
                        break;
                    case "2":
                        Console.Clear();
                        ActionAfficherSalaries();
                        break;
                    case "3":
                        Console.Clear();
                        ActionRechercherSalaries();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
            } while (choix != "0");
        }

        private void MenuPrincipal()
        {
            Console.WriteLine("===== Gestion des employés =====");
            Console.WriteLine("1- Ajouter un Salarié");
            Console.WriteLine("2- Afficher le salaire des employés");
            Console.WriteLine("3- Rechercher un employé\n");
            Console.WriteLine("0-- Quitter\n");
        }

        private void MenuCreationEmployes()
        {
            Console.WriteLine("===== Ajouter un employé =====");
            Console.WriteLine("1- Ajouter un Salarié");
            Console.WriteLine("2- Ajouter un commercial\n");
            Console.WriteLine("0-- Retour\n");
        }

        private void ActionCreationEmployes()
        {
            bool valid = false;
            MenuCreationEmployes();
            Console.Write("Entrez votre choix : ");
            string choix = Console.ReadLine();
            while (!valid)
            {
                if (choix != "1" && choix != "2" && choix != "0")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Erreur de saisie, entrez votre choix : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    choix = Console.ReadLine();
                }
                else
                    valid = true;
            }
            /// Création d'une instance de Salarié null
            Salarie s = null;

            switch (choix)
            {
                case "1":
                    s = ActionCreationSalarie();
                    break;
                case "2":
                    s = ActionCreationCommercial();
                    break;
                case "0":
                    break;
            }

            if (s != null)
            {
                for (int i = 0; i < employes.Length; i++)
                {
                    if (employes[i] == null)
                    {
                        employes[i] = s;
                        break;
                    }
                }
            }

            Console.Clear();
        }


        private Salarie ActionCreationSalarie()
        {
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le matricule : ");
            string matricule = Console.ReadLine();
            Console.Write("Merci de saisir le categorie : ");
            string categorie = Console.ReadLine();
            Console.Write("Merci de saisir le service : ");
            string service = Console.ReadLine();
            Console.Write("Merci de saisir le salaire : ");
            decimal salaire = Convert.ToDecimal(Console.ReadLine());

            return new Salarie(matricule, categorie, service, nom, salaire);
        }

        private Commercial ActionCreationCommercial()
        {
            Salarie tmp = ActionCreationSalarie();
            Console.Write("Merci de saisir le chiffre d'affaire du commercial : ");
            decimal chiffreAffaire = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Merci de saisir le taux de commission : ");
            int commission = Convert.ToInt32(Console.ReadLine());

            return new Commercial(tmp.Matricule, tmp.Categorie, tmp.Service, tmp.Nom, tmp.Salaire, chiffreAffaire, commission);
        }

        private void ActionAfficherSalaries()
        {
            Console.WriteLine("===== Salaire des employes =====");

            for (int i = 0; i < employes.Length; i++)
            {
                if (employes[i] != null)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(employes[i].GetType());
                    //Console.WriteLine(employes[i]);

                    if (employes[i] is Commercial c)
                    {
                        c.AfficherCommercial();
                    }

                    employes[i].AfficherSalaire();
                    Console.WriteLine("----------------------");
                }
            }
        }

        private void ActionRechercherSalaries()
        {
            Console.WriteLine("\n===== Recherche d'un employé par nom =====");

            Console.Write("Merci de saisir le nom du salarié : ");
            string nom = Console.ReadLine();
            Salarie s = null;
            for (int i = 0; i < employes.Length; i++)
            {
                if (employes[i].Nom == nom)
                {
                    s = employes[i];
                    break;
                }
            }
            if (s != null)
            {
                s.AfficherSalaire();
            }
            else
                Console.WriteLine("Aucune salarie avec ce nom...");
        }
    }
}