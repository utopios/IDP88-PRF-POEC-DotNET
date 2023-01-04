using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TpBanqueBaseClass.Class;
using TpBanqueIHMConsole.Tools;

namespace TpBanqueIHMConsole.Class
{
    internal class IHM
    {
        private Bank banque;
        public IHM()
        {
            Init();
        }

        private void Init()
        {
            banque = new();
            banque.Injecter();
            for (int i = 0; i < banque.Comptes.Count; i++)
                banque.Comptes[i].ADecouvert += ActionNotificationADecouvert;
        }

        public void Start()
        {
            string choix = "-1";
            do
            {
                string pattern = @"^[0-5]{1}$";

                Menu();

                TryRead("\n Faites votre choix => ", () => choix = Console.ReadLine());

                while (!Regex.IsMatch(choix, pattern))
                {
                    MyConsoleColor.OnCyanInput("Veuillez saisir une valeur entre 0 et 5 inclus => ");
                    choix = Console.ReadLine();
                }
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        ActionCreationCompte();
                        break;
                    case "2":
                        ActionDepot();
                        break;
                    case "3":
                        ActionRetrait();
                        break;
                    case "4":
                        ActionAffichageCompte();
                        break;
                    case "5":
                        ActionInterets();
                        break;
                    default:
                        break;
                }
            } while (choix != "0");

            WaitAndClear();
        }

        private void Title()
        {
            MyConsoleColor.OnDarkCyan("\n----------------- Banque Peu Populaire ----------------\n");
        }

        private void Menu()
        {
            Title();
            MyConsoleColor.OnDarkCyan("\n     ------------ MenuPrincipal ------------\n");
            Console.WriteLine("\t1- Créer un compte bancaire" +
                                "\n\t2- Effectuer un dépôt" +
                                "\n\t3- Effectuer un retrait" +
                                "\n\t4- Opérations et solde" +
                                "\n\t5- Calcul des Interêts");
            MyConsoleColor.OnRed("\n\t0-- Quitter\n\n");
        }

        private void TryRead(string message, Action ReadElement)
        {
            bool valid = false;
            do
            {
                MyConsoleColor.OnCyanInput(message);
                try
                {
                    ReadElement();
                    valid = true;
                }
                catch (Exception ex)
                {
                    MyConsoleColor.OnRed(ex.Message);
                }
            } while (!valid);
        }

        private void ActionCreationCompte()
        {
            MyConsoleColor.OnDarkCyan("\n-------------------------- Création Client --------------------------");
            Client client = new();
            TryRead("\nVeuillez saisir le nom : ", () => client.Nom = Console.ReadLine());
            TryRead("\nVeuillez saisir le prénom : ", () => client.Prenom = Console.ReadLine());
            TryRead("\nVeuillez saisir le téléphone : ", () => client.Telephone = Console.ReadLine());

            decimal solde = 0;
            MyConsoleColor.OnDarkCyan("\n ----------- Création du Compte -----------");
            TryRead("\nVeuillez saisir le solde à l'ouverture du compte : ", () => solde = Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("\n1-- Compte Normal");
            Console.WriteLine("2-- Compte Epargne");
            Console.WriteLine("3-- Compte Payant");

            string pattern = @"^[1-3]{1}$";
            string choix = "-1";
            TryRead("\nVeuillez saisir votre choix => ", () => choix = Console.ReadLine());
            while (!Regex.IsMatch(choix, pattern))
            {
                MyConsoleColor.OnCyanInput("Veuillez saisir une valeur entre 1 et 3 inclus => ");
                choix = Console.ReadLine();
            }

            Compte compte = null;

            switch (choix)
            {
                case "1":
                    compte = new Compte(solde, client);
                    break;
                case "2":
                    decimal taux=0;
                    TryRead("Veuillez indiquer le taux d'épargne => ", () => taux = Convert.ToDecimal(Console.ReadLine()));
                    compte = new CompteEpargne(solde, client, taux);
                    break;
                case "3":
                    decimal cout = 0;
                    TryRead("Veuillez indiquer le coût par opération => ", () => cout = Convert.ToDecimal(Console.ReadLine()));
                    compte = new ComptePayant(solde, client, cout);
                    break;
            }

            if (compte != null)
            {
                compte.ADecouvert += ActionNotificationADecouvert;

                if (banque.AjouterCompte(compte))                
                    MyConsoleColor.OnGreen($"\n\nCompte ajoutée avec le numéro {compte.Id}");                
                else                
                    MyConsoleColor.OnRed($"\nErreur lors de l'ajout du compte...");
                WaitAndClear();
            }

        }

        private void ActionDepot()
        {
    
            MyConsoleColor.OnDarkCyan("\n--------------------------      Dépot      --------------------------");
            Compte compte = ActionRechercheCompte();

            if (compte != null)
            {
                decimal montant = 0;
                TryRead("\n Merci de saisir le montant du dépôt => ", () => montant = Convert.ToDecimal(Console.ReadLine()));
                Operation operation = new(montant);
                if (compte.Depot(operation))
                    MyConsoleColor.OnGreen("\n\n Dépôt Effectué !");
                else
                    MyConsoleColor.OnRed("\n\n Erreur lors du Dépôt !");

                WaitAndClear();
            }

        }
        private void ActionRetrait()
        {
            MyConsoleColor.OnDarkCyan("\n--------------------------     Retrait     --------------------------");

            Compte compte = ActionRechercheCompte();

            if (compte != null)
            {
                decimal montant = 0;
                TryRead("\n Merci de saisir le montant du retrait => ", () => montant = (Convert.ToDecimal(Console.ReadLine()))*-1);
                Operation operation = new(montant);
                if (compte.Retrait(operation))
                    MyConsoleColor.OnGreen("\n\n Retrait Effectué !");
                else
                    MyConsoleColor.OnRed("\n\n Erreur lors du Retrait !");

                WaitAndClear();
            }


        }

        private void ActionAffichageCompte()
        {
            MyConsoleColor.OnDarkCyan("\n------------------ Afficher un compte -----------------");

            Compte compte = ActionRechercheCompte();

            if (compte != null)
            {
                MyConsoleColor.OnDarkCyanInput("\n--------------------- Compte N° ");
                Console.Write($"{compte.Id}");
                MyConsoleColor.OnDarkCyanInput($" ---------------------\n\n Nom : ");
                Console.Write($"{compte.Client.Nom}");
                MyConsoleColor.OnDarkCyanInput($"\tPrénom : ");
                Console.WriteLine($"{compte.Client.Prenom}");
                MyConsoleColor.OnDarkCyanInput($" Téléphone : ");
                Console.WriteLine($"{compte.Client.Telephone}");
                MyConsoleColor.OnDarkCyanInput("\n\t\t\t\t\tSolde : ");
                if (compte.Solde >= 0)
                    MyConsoleColor.OnGreen($"{Math.Round(compte.Solde, 2)}€");
                else
                    MyConsoleColor.OnRed($"{Math.Round(compte.Solde, 2)}€");

                MyConsoleColor.OnDarkCyan("\n---------------------- Opérations ---------------------\n");
                if (compte.Operations.Count > 0)
                {
                    foreach (Operation o in compte.Operations)
                    {
                        MyConsoleColor.OnGrayInput($"{o.ToString()} - Montant : ");
                        if (o.Montant >= 0)
                            MyConsoleColor.OnGreen($"{Math.Abs(o.Montant)}€");
                        else
                            MyConsoleColor.OnRed($"{Math.Abs(o.Montant)}€");
                    }
                }
                else
                    Console.WriteLine("   Aucune opération enrigistrée sur ce compte...");

                MyConsoleColor.OnDarkCyan("\n-------------------------------------------------------");
            }
            WaitAndClear();
        }

        private void ActionInterets()
        {
            MyConsoleColor.OnDarkCyan("\n--------------------- Opérations ---------------------");

            MyConsoleColor.OnDarkCyan("\n------------ Ajouter les intérêts annuels ------------");

            Compte compte = ActionRechercheCompte();
            if (compte != null && compte is CompteEpargne compteEpargne)
            {
                if (compteEpargne.CalculInterets())
                    MyConsoleColor.OnGreen("\n\n Interêts ajoutés...");
                else
                    MyConsoleColor.OnRed("\n\n Erreur lors de l'ajout des interêts...");
            }
            else if (compte != null)
                MyConsoleColor.OnRed($"\n Erreur, le compte N°{compte.Id} n'est pas un compte épargne");

            WaitAndClear();

        }

        private Compte ActionRechercheCompte()
        {
            int numeroCompte = -1;
            TryRead("\n Veuillez saisir le numéro du compte => ", () => numeroCompte = Convert.ToInt32(Console.ReadLine()));
            Compte compte = banque.RechercherCompte(numeroCompte);
            if (compte == null)            
                MyConsoleColor.OnRed("Aucun compte avec ce numéro!");
            return compte;
        }

        public void ActionNotificationADecouvert(decimal solde, int id)
        {
            MyConsoleColor.OnRed($"\nLe compte n°{id} est à découvert ! ");
            Console.Write("\n\t\tVoici le nouveau solde : ");
            MyConsoleColor.OnRed($"{solde}€");
        }

        private void WaitAndClear()
        {
            MyConsoleColor.OnDarkCyanInput("\nAppuyez sur ENTER pour continuer...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
