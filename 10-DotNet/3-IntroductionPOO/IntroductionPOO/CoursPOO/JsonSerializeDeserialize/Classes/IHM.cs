using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerializeDeserialize.Classes
{
    class IHM
    {
        Shop shop;

        public IHM()
        {
            Init();
        }

        public void Init()
        {
            shop = new Shop();
        }

        public void Start()
        {
            int result;
            do
            {

                MainMenu();
                do
                {
                    Console.Write("Veuillez faire votre choix : ");
                }
                while (!int.TryParse(Console.ReadLine(), out result));

                switch (result)
                {
                    case 1:
                        Console.Clear();
                        ClientMenu();
                        break;
                    case 2:
                        Console.Clear();
                        AdminMenu();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Erreur de choix");
                        break;
                }
            } while (result != 0);
        }

        public void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("________________________________________________________________________________________________________________\n");
            Console.WriteLine("------------------------                      Application CART                            ----------------------\n");
            Console.WriteLine("------------------------                       Menu Principal                             ----------------------");
            Console.WriteLine("________________________________________________________________________________________________________________\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t 1- Client");
            Console.WriteLine("\t 2- Administration\n");
            Console.WriteLine("\t 0--- Quitter\n");
        }

        public void MenuClient()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("________________________________________________________________________________________________________________\n");
            Console.WriteLine("------------------------                      Application CART                            ----------------------\n");
            Console.WriteLine("------------------------                         Menu Client                              ----------------------");
            Console.WriteLine("________________________________________________________________________________________________________________\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ClientChoice()
        {
            Console.WriteLine("\n------------------------------------------------- SOMMAIRE -----------------------------------------------------\n");
            Console.WriteLine("\t 1) Ajouter un produits au panier");
            Console.WriteLine("\t 2) Consulter panier");
            Console.WriteLine("\t 3) Payer\n");
            Console.WriteLine("\t 0) Menu principal\n");
        }
        public void MenuAdmin()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("________________________________________________________________________________________________________________\n");
            Console.WriteLine("------------------------                      Application CART                            ----------------------\n");
            Console.WriteLine("------------------------                     Menu Administrateur                          ----------------------");
            Console.WriteLine("________________________________________________________________________________________________________________\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t 1) Consulter les produits");
            Console.WriteLine("\t 2) Ajouter un nouveau produits");
            Console.WriteLine("\t 3) Ajouter des produits au Stock\n");
            Console.WriteLine("\t 0) Menu principal\n");
        }
        public void AdminMenu()
        {

            bool exit = false;
            int choix;
            do
            {
                Console.Clear();

                MenuAdmin();

                do
                {
                    Console.Write("\nVeuillez faire votre choix : ");
                }
                while (!int.TryParse(Console.ReadLine(), out choix));

                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        ActionAfficherListeProduits();
                        Console.WriteLine("\nAppuyer sur Enter pour revenir au menu principal...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        ActionAjouterProduits();
                        break;
                    case 3:
                        Console.Clear();
                        ActionModifierProduit();
                        break;
                    case 0:
                        Console.Clear();
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\t 1) Consulter les produits");
                        break;
                }

            } while (!exit);
        }

        public void ClientMenu()
        {

            bool exit = false;
            int choix;
            do
            {
                Console.Clear();

                MenuClient();

                ActionAfficherListeProduits();

                ClientChoice();

                do
                {
                    Console.Write("Veuillez faire votre choix : ");
                }
                while (!int.TryParse(Console.ReadLine(), out choix));

                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        ActionAjouterPanier();
                        Stop();
                        break;
                    case 2:
                        Console.Clear();
                        ActionConsulterPanier();
                        Stop();
                        break;
                    case 3:
                        Console.Clear();
                        ActionPayerPanier();
                        Stop();
                        break;
                    case 0:
                        Console.Clear();
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Erreur Choix...");
                        break;
                }

            } while (!exit);
        }

        public void ActionAfficherListeProduits()
        {
            Console.WriteLine("--------------------------------------------- Liste des produits -----------------------------------------------\n");

            // Itération de chaque produit contenu dans la liste produits
            for (int i = 0; i < shop.Produits.Count; i++)
            {
                // Affichage du produit ave la méthode ToString
                Console.WriteLine(" " + (i + 1) + " - " + shop.Produits[i].ToString());
            }
        }

        public void ActionAjouterProduits()
        {
            Console.Clear();

            Console.WriteLine("-------------------------------------------- Ajouter un Produit ----------------------------------------------\n");


            // Recuperation du nom du produit
            Console.Write("Veuillez saisir le nom du produit : ");
            string Nom = Console.ReadLine();

            // Récupération du prix HT du produit
            Console.Write("Veuillez saisir le prix H.T du produit : ");
            double PrixHt = Convert.ToDouble(Console.ReadLine());

            // Récupération du taux de TVA du produit
            Console.Write("Veuillez saisir le taux de T.V.A du produit : ");
            double Tva = Convert.ToDouble(Console.ReadLine());

            // Calcul du prix TTC du produit
            double PrixTtc = Math.Round(PrixHt * (1 + (Tva / 100)), 2);

            // Récupération de la quantité ajoutée au shop
            Console.Write("Veuillez saisir la quantité de produit : ");
            int Quantite = Convert.ToInt32(Console.ReadLine());

            // Récupération de l'unité           
            Console.WriteLine("Veuillez choisir l'unité : ");
            string[] unite = Enum.GetNames(typeof(Unite));
            for (int i = 0; i < unite.Length; i++)
            {
                Console.WriteLine("\t" + i + ") {0}", unite[i]);
            }

            Console.Write("\n Entrez votre choix : ");


            Unite uniteUser = (Unite)Convert.ToInt32(Console.ReadLine());

            // Creation d'une nouvelle instance de Produit avec les paramètres saisis
            Produit p = new Produit(Nom, PrixHt, Tva, PrixTtc, Quantite, uniteUser);

            // Ajout du nouveau produit au shop et affichage du résultat de l'opération
            Console.WriteLine(shop.AddProductToShop(p) ? "\nProduit Ajouté" : "\nErreur Ajout Produit");

            Console.WriteLine("\nAppuyer sur Enter pour revenir au menu...");
            Console.ReadLine();
        }

        public void ActionModifierProduit()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------- Modifier un Produit ----------------------------------------------\n");


            // Affichage de la liste des produits
            ActionAfficherListeProduits();

            // Recuperation de l'index du produit à update
            Console.Write("\nVeuillez saisir l'ID du produit à modifier ");
            int id = Convert.ToInt32(Console.ReadLine());

            // Récupération du prix HT du produit
            Console.Write("Veuillez saisir le prix H.T du produit : ");
            double PrixHt = Convert.ToDouble(Console.ReadLine());

            // Récupération de la quantité de produits ajoutés
            Console.Write("Veuillez saisir la quantité de produit(s) ajouté(s) : ");
            int Quantite = Convert.ToInt32(Console.ReadLine());

            // Modification du produit dans le shop et affichage du résultat de l'opération
            Console.WriteLine(shop.UpdateQuantity(id, Quantite, PrixHt) ? "\nProduit Modifié" : "\nErreur lors de la modidication du Produit");

            Console.WriteLine("\nAppuyer sur Enter pour revenir au menu...");
            Console.ReadLine();
        }

        public void ActionAjouterPanier()
        {
            int choix;
            int quantity;

            ActionAfficherListeProduits();

            Console.Write("Veuillez saisir l'id de l'objet à ajouter au panier : ");
            while (!int.TryParse(Console.ReadLine(), out choix))
                Console.WriteLine("Erreur,veuillez saisir un nombre");

            Console.Write("Veuillez saisir la quantité à ajouter au panier : ");
            while (!int.TryParse(Console.ReadLine(), out quantity))
                Console.WriteLine("Erreur, veuillez saisir un nombre ");

            if (shop.Produits[choix - 1].Quantite >= quantity)
            {
                try
                {
                    Console.WriteLine(shop.AddProductToCart(shop.Produits[choix - 1], quantity).Item2);
                    shop.Produits[choix - 1].Quantite -= quantity;
                    shop.UpdateCartFile();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Quantité en stock insuffisante!");
            }
        }
        public void ActionConsulterPanier()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------- Application CART -------------------------------------------------");
            Console.WriteLine("------------------------------------------------ Menu Client ---------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            if (shop.Cart.Content.Count > 0)
            {
                Console.WriteLine("------------------------------------------------ CART ----------------------------------------------------------\n");


                double total = 0.0;
                foreach (CartLine item in shop.Cart.Content)
                {
                    total += item.Product.PrixTtc * item.Quantity;
                    Console.WriteLine($"-{item.Product.Nom} - Prix H.T : {item.Product.PrixHt}€ - Prix T.T.C : {item.Product.PrixTtc}€ - Quantité : {item.Quantity} - Total : {item.Product.PrixTtc * item.Quantity}€ ");
                }
                Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t -");
                Console.Write($"\t\t\t\t\t\t\t\t\t -   Montant Total Panier : ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{Math.Round(total, 2)}€\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t ---------------------------------------");
            }
            else
                Console.WriteLine("Aucun article dans le panier...");

        }
        public void ActionPayerPanier()
        {
            Console.WriteLine(shop.Cart);
            if (shop.Cart.Content.Count > 0)
            {
                Console.WriteLine("------------------- CART -------------------\n");
                double total = 0.0;
                foreach (CartLine item in shop.Cart.Content)
                {
                    total += item.Product.PrixTtc * item.Quantity;
                    Console.WriteLine($"-{item.Product.Nom} - Prix H.T : {item.Product.PrixHt}€ - Prix T.T.C : {item.Product.PrixTtc}€ - Quantité : {item.Quantity} - Total : {item.Product.PrixTtc * item.Quantity}€ ");
                }
                Console.WriteLine("\n--------------------------------------------\n");
                Console.WriteLine($"\t\t\t\t\t Montant Total Panier : {total}€\n");
                Console.Write($"Choisissez le mode de paiement : \n\n\t1- CB\n\t2- Espèces\n\n\t0-- Menu Principal\n\nVeuillez saisir votre choix : ");
                int choix;
                while (!int.TryParse(Console.ReadLine(), out choix))
                    Console.WriteLine("Veuillez saisir un nombre...");
                bool confirm = false;
                switch (choix)
                {
                    case 1:
                        Console.Write("Etes-vous sur de vouloir solder le panier pas CB...(true/false)? : ");
                        while (!bool.TryParse(Console.ReadLine(), out confirm))
                            Console.WriteLine("Veuillez saisir  => true ou false...");
                        if (confirm)
                        {
                            Console.WriteLine("Vous avez réglé le solde par CB\n\t");
                            shop.Cart.Content.Clear();
                        }
                        else
                            Console.WriteLine("Opération annulée...");
                        break;
                    case 2:
                        Console.Write("Etes-vous sur de vouloir solder le panier en espèces...(true/false)? : ");
                        while (!bool.TryParse(Console.ReadLine().ToLower(), out confirm))
                            Console.WriteLine("Veuillez saisir => true ou false...");
                        if (confirm)
                        {
                            Console.WriteLine("Vous avez réglé le solde en espèces\n\t");
                            shop.Cart.Content.Clear();
                        }
                        else
                            Console.WriteLine("Opération annulée...");
                        break;
                    default:
                        Console.WriteLine("Il n'y à que deux choix : 1 => CB, 2 => Especes");
                        break;
                }
            }
            else
                Console.WriteLine("Aucun article dans le panier...");
        }

        public void Stop()
        {
            Console.WriteLine("\nAppuyer sur Enter pour revenir au menu principal...");
            Console.ReadLine();
        }
    }
}
