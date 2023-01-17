using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TpListContactBaseClass.Class;
using TpListContactBaseClass.DAO;
using TpListContactBaseClass.Tools;
using TpListContactIHMConsole.Tools;

namespace TpListContactIHMConsole.Class
{
    internal class IHM
    {
       List<Contact> contacts;
        ContactDAO daoContact;
        public IHM()
        {
            daoContact = new ContactDAO();
            contacts = daoContact.FindAll();
        }

        public void Start()
        {
            string choix = "";
            do
            {
                MainMenu();
                choix = UserChoice();
                switch (choix)
                {
                    case "1":
                        AddContactAction();
                        break;
                    case "2":
                        UpdateContactAction();
                        break;
                    case "3":
                        DeleteContactAction();
                        break;
                    case "4":
                        FindContactAction();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        MyConsoleColor.OnRed("Erreur, verifier votre choix!");
                        WaitUser();
                        break;
                }

            } while (choix != "0");


        }

        public static void AppTitle()
        {
            MyConsoleColor.OnDarkCyan("----------------------------------------------------------------------");
            MyConsoleColor.OnDarkCyan("--------------------- TP List Contact (Annuaire) ---------------------");
            MyConsoleColor.OnDarkCyan("----------------------------------------------------------------------\n");
        }

        private static void MainMenu()
        {
            AppTitle();

            MyConsoleColor.OnDarkCyan("\t\tMain Menu");
            Console.WriteLine("\t1-- Ajouter un Contact");
            Console.WriteLine("\t2-- Modifier un Contact");
            Console.WriteLine("\t3-- Supprimer un Contact");
            Console.WriteLine("\t4-- Rechercher un Contact par Id");
            MyConsoleColor.OnRed("\t0--- Quitter");
        }

        public void AddContactAction()
        {
            // Nettoyage console
            Console.Clear();
            // Affichage du titre de l'application
            AppTitle();
            // Affichage du Titre de la sous partie
            MyConsoleColor.OnDarkCyan("\t\t\tAjouter un contact");

            // Création d'un contact
            Contact c = null;

            // Recupération des saisies utilisateur pour la création d'un nouveau contact
            try
            {
                int day = 0, month = 0, year = 0, number = 0, zipcode = 0;
                string firstname = "", lastname = "", roadName = "", city = "", country = "", phone = "", email = "";
                DateTime dateOfBirth;


                MyConsoleColor.OnDarkCyan("------------------------------ Personne ------------------------------\n");


                do
                {
                    TryRead("Veuillez saisir le nom du contact : ", () => lastname = Console.ReadLine());
                }
                while (!MyRegex.IsName(lastname));

                do
                {
                    TryRead("Veuillez saisir le prénom du contact : ", () => firstname = Console.ReadLine());
                }
                while (!MyRegex.IsName(firstname));


                TryRead("Veuillez saisir le jour de naissance du contact (en chiffre) : ", () => day = Convert.ToInt32(Console.ReadLine()));

                TryRead("Veuillez saisir le mois de naissance du contact (en chiffre) : ", () => month = Convert.ToInt32(Console.ReadLine()));

                TryRead("Veuillez saisir le mois de naissance du contact (en chiffre) : ", () => year = Convert.ToInt32(Console.ReadLine()));

                dateOfBirth = new DateTime(year, month, day);

                MyConsoleColor.OnDarkCyan("------------------------------ Adresse -------------------------------\n");


                TryRead("Veuillez saisir numéro de porte : ", () => number = Convert.ToInt32(Console.ReadLine()));


                do
                {
                    TryRead("Veuillez saisir le nom de la rue : ", () => roadName = Console.ReadLine());
                }
                while (!MyRegex.IsAlphabetic(roadName));


                TryRead("Veuillez saisir le code postal de la ville : ", () => zipcode = Convert.ToInt32(Console.ReadLine()));


                do
                {
                    TryRead("Veuillez saisir le nom de la Ville : ", () => city = Console.ReadLine());
                }
                while (!MyRegex.IsName(city));

                do
                {
                    TryRead("Veuillez saisir le nom du pays : ", () => country = Console.ReadLine());
                }
                while (!MyRegex.IsName(country));

                Address contactAdress = new Address(number, roadName, zipcode, city, country);

                MyConsoleColor.OnDarkCyan("------------------------------ Contact -------------------------------\n");

                do
                {
                    TryRead("Veuillez saisir le numéro de téléphone : ", () => phone = Console.ReadLine());
                }
                while (!MyRegex.IsPhone(phone));

                do
                {
                    TryRead("Veuillez saisir l'email : ", () => email = Console.ReadLine());
                } while (!MyRegex.IsEmail(email));





                // Création du contact

                c = new(firstname, lastname, dateOfBirth, contactAdress, phone, email);
                c.ContactId = new ContactDAO().Create(c);

                if (c.ContactId > 0)
                    MyConsoleColor.OnGreen($"\nContact ajouté avec l'id n°{c.ContactId}!\n");
                else
                    MyConsoleColor.OnRed("\nErreur lors de l'ajout du contact!\n");
            }
            catch (Exception e)
            {
                MyConsoleColor.OnRed(e.Message);
            }


            WaitUser();
        }
        
        public void UpdateContactAction()
        {
            // Nettoyage console
            Console.Clear();
            // Affichage du titre de l'application
            AppTitle();
            // Affichage du Titre de la sous partie
            MyConsoleColor.OnDarkCyan("\n\t\t\tModifier un contact");
            // Création d'un contact
            Contact c = null;
            // Initialisation de l'id du contact a update
            int index = -1;

            // Recupération de la saisie utilisateur pour l'id
            Console.Write("Veuillez saisir l'id du contact à modifier : ");
            while (!int.TryParse(Console.ReadLine(), out index) && index > 0)
                MyConsoleColor.OnRed("Veuillez saisir un entier positif");

            (bool found, Contact tmp) = GetContact(index);
            // Si le contact existe dans la liste
            if (found)
                // Assignation a c du contact
                c = tmp;
            else
            {
                // Sinon affichage de l'erreur
                MyConsoleColor.OnRed("\nAucun contact avec cet ID!\n");
                WaitUser();
                return;
            }



            // Recupération des saisies utilisateur pour la création d'un nouveau contact
            try
            {
                int day, month, year, intTmp;
                MyConsoleColor.OnDarkCyan("------------------------------ Personne ------------------------------\n");


                MyConsoleColor.OnCyanInput($"Veuillez saisir le nom du contact (Actual Value = {c.Lastname} => PRESS ENTER pour conserver) : ");
                string stringTmp = Console.ReadLine();
                c.Lastname = stringTmp == "" ? c.Lastname : stringTmp;

                MyConsoleColor.OnCyanInput($"Veuillez saisir le prénom du contact (Actual Value = {c.Firstname} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                c.Firstname = stringTmp == "" ? c.Firstname : stringTmp;

                MyConsoleColor.OnCyanInput($"Veuillez saisir le jour de naissance du contact (Actual Value = {c.DateOfBirth.Day} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    MyConsoleColor.OnRedInput($"Erreur! Veuillez saisir le jour de naissance du contact (Actual Value = {c.DateOfBirth.Day} => saisir 0 pour conserver) : ");
                day = intTmp == 0 ? c.DateOfBirth.Day : intTmp;

                MyConsoleColor.OnCyanInput($"Veuillez saisir le mois de naissance du contact (Actual Value = {c.DateOfBirth.Month} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    MyConsoleColor.OnRedInput($"Erreur! Veuillez saisir le mois de naissance du contact (Actual Value = {c.DateOfBirth.Month} => saisir 0 pour conserver) : ");
                month = intTmp == 0 ? c.DateOfBirth.Month : intTmp;

                MyConsoleColor.OnCyanInput($"Veuillez saisir le mois de naissance du contact (Actual Value = {c.DateOfBirth.Year} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    MyConsoleColor.OnRedInput($"Erreur! Veuillez saisir le mois de naissance du contact (Actual Value = {c.DateOfBirth.Year} => saisir 0 pour conserver) : ");
                year = intTmp == 0 ? c.DateOfBirth.Year : intTmp;

                if (c.DateOfBirth.Year != year || c.DateOfBirth.Month != month || c.DateOfBirth.Day != day)
                    c.DateOfBirth = new DateTime(year, month, day);



                MyConsoleColor.OnDarkCyan("------------------------------ Adresse -------------------------------\n");


                MyConsoleColor.OnCyanInput($"Veuillez saisir numéro de porte (Actual Value = {c.ContactAddress.Number} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    MyConsoleColor.OnRedInput($"Erreur! Veuillez saisir numéro de porte (Actual Value = {c.ContactAddress.Number} => saisir 0 pour conserver) : ");
                c.ContactAddress.Number = intTmp == 0 ? c.ContactAddress.Number : intTmp;

                MyConsoleColor.OnCyanInput($"Veuillez saisir le nom de la rue (Actual Value = {c.ContactAddress.RoadName} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                c.ContactAddress.RoadName = stringTmp == "" ? c.ContactAddress.RoadName : stringTmp;

                MyConsoleColor.OnCyanInput($"Veuillez saisir le code postal de la ville (Actual Value = {c.ContactAddress.ZipCode} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    MyConsoleColor.OnRedInput($"Erreur! Veuillez saisir le code postal de la ville (Actual Value = {c.ContactAddress.ZipCode} => saisir 0 pour conserver): ");
                c.ContactAddress.ZipCode = intTmp == 0 ? c.ContactAddress.ZipCode : intTmp;

                MyConsoleColor.OnCyanInput($"Veuillez saisir le nom de la Ville (Actual Value = {c.ContactAddress.City} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                c.ContactAddress.City = stringTmp == "" ? c.ContactAddress.City : stringTmp;

                MyConsoleColor.OnCyanInput($"Veuillez saisir le nom du pays (Actual Value = {c.ContactAddress.Country} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                c.ContactAddress.Country = stringTmp == "" ? c.ContactAddress.Country : stringTmp;


                MyConsoleColor.OnDarkCyan("------------------------------ Contact -------------------------------\n");

                MyConsoleColor.OnCyanInput($"Veuillez saisir le numéro de téléphone (Actual Value = {c.Phone} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                c.Phone = stringTmp == "" ? c.Phone : stringTmp;

                MyConsoleColor.OnCyanInput($"Veuillez saisir l'email (Actual Value = {c.Email} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                c.Email = stringTmp == "" ? c.Email : stringTmp;


                // Si la méthode update return false
                if (!new ContactDAO().Update(c))
                    MyConsoleColor.OnRed("\nErreur lors la modification du contact.\n");
                else
                    MyConsoleColor.OnGreen("\nContact modifié avec succès...");
            }
            catch (Exception e)
            {
                MyConsoleColor.OnRed(e.Message);
            }



            WaitUser();
        }
        public void DeleteContactAction()
        {
            // Nettoyage console
            Console.Clear();
            // Affichage du titre de l'application
            AppTitle();
            MyConsoleColor.OnDarkCyan("------------------------- Supprimer Contact -------------------------\n");
            // Initialisation de l'index
            int index = -1;
            // Recupération de la saisie utilisateur pour l'index
            Console.Write("Veuillez saisir l'id du contact à supprimer : ");
            while (!int.TryParse(Console.ReadLine(), out index) && index >= 0)
                MyConsoleColor.OnRed("Veuillez saisir un entier");


            if (new ContactDAO().Delete(index))
                MyConsoleColor.OnGreen("\nContact supprimé avec succès!\n");


            WaitUser();
        }
        public void FindContactAction()
        {
            Console.Clear();

            AppTitle();


            MyConsoleColor.OnDarkCyan("------------------------- Rechercher Contact -------------------------\n");

            int index = -1;
            Console.Write("Veuillez saisir l'id du contact à rechercher : ");
            while (!int.TryParse(Console.ReadLine(), out index) && index > 0)
                MyConsoleColor.OnRed("Veuillez saisir un entier positif");

            (bool response, Contact c) = GetContact(index);

            if (!response)
                MyConsoleColor.OnRed("\nAucun contact avec cet ID!\n");
            else
            {
                MyConsoleColor.OnCyan("\nVoici le contact trouvé dans l'annuaire : \n");
                Console.WriteLine(c);
            }
            WaitUser();
        }
        private string UserChoice()
        {
            Console.Write("\nVeuillez faire votre choix : ");
            return Console.ReadLine();
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

        public (bool,Contact) GetContact(int id)
        {
            return new ContactDAO().Find(id);
        }

        public void WaitUser()
        {
            MyConsoleColor.OnDarkCyan("\nAppuyez sur ENTER pour revenir au menu pricipal...");
            Console.ReadLine();
            Console.Clear();
        }

        public void Close()
        {
            Console.WriteLine("Appuyer sur enter pour fermer le programme...");
            Console.Read();
        }


    }
}
