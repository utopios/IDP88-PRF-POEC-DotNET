using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonSerializeDeserialize.Classes
{
    class Shop
    {
        //private string PathFileProduits = "listeProduits.txt";
        //private string PathFileCart = "PanierClient.txt";
        private string PathFileProduits = "listeProduits.json";
        private string PathFileCart = "PanierClient.json";
        private List<Produit> produits;
        private Cart cart;

        public Shop()
        {
            Produits = FindProducts();
            Cart = GetCart();
        }

        public List<Produit> Produits { get => produits; set => produits = value; }
        
        public Cart Cart { get => cart; set => cart = value; }




        public (bool, string) AddProductToCart(Produit p, int quantity)
        {
            // Declaration d'un booleen result initialise a false
            bool result = false;

            // Création d'une instance de CartLine
            CartLine newCartLine = new CartLine(p, quantity);

            // Ajout du produit c passé en paramètre à la liste produits
            bool found = false;
            for (int i = 0; i < Cart.Content.Count; i++)
            {
                if (Cart.Content[i].Product.Nom == newCartLine.Product.Nom)
                {
                    found = true;
                    Cart.Content[i].Quantity += newCartLine.Quantity;
                    break;
                }
            }
            if (!found)
                Cart.Add(newCartLine);

            // Mise à jour du fichier PanierClient.txt pour persistance des données
            result = UpdateCartFile();

            // Rédaction du résultat de l'opération à l'utilisateur
            string message = result ? "Produit ajouté au panier !" : "Erreur lors de l'ajout du produit au panier";

            // Retour du résultat de l'opération à la méthode qui en à fait l'appel
            return (result, message);
        }
        public bool AddProductToShop(Produit p)
        {
            // Declaration d'un booleen result initialise a false
            bool result = false;

            // Ajout du produit p passé en paramètre à la liste produits
            Produits.Add(p);

            // Mise à jour du fichier listeProduits.txt pour persistance des données
            result = UpdateProductFile();

            // Affichage du résultat de l'opération à l'utilisateur
            Console.WriteLine(result ? "Produit ajouté au shop !" : "Erreur lors de l'ajout du produit au shop");

            // Retour du résultat de l'opération à la méthode qui en à fait l'appel
            return result;
        }

        public bool UpdateQuantity(int index, int quantite, double prixHt)
        {
            // Declaration d'un booleen result initialise a false
            bool result = false;

            try
            {
                // Récupération de la quantité deja en stock
                int quantiteInit = Produits[index].Quantite;

                // Calcul de la nouvelle quantité
                int quantiteFinale = quantiteInit + quantite;

                // Recuperation du prix HT initial
                double prixHtInit = Produits[index].PrixHt;

                // Recuperation du taux de TVA applicable au produit
                double tvaInit = Produits[index].Tva;

                // Update de la quantité de produits dans la liste produits
                Produits[index].Quantite += quantite;

                // Recalcul du PAMP (Prix Achat Moyen Pondéré)
                Produits[index].PrixHt = Math.Round((prixHtInit * quantiteInit + prixHt * quantite) / quantiteFinale);

                // Mise à jour du fichier listeProduits.txt pour persistance des données
                result = UpdateProductFile();

                // Retour du résultat de l'opération à la méthode qui en à fait l'appel
                return result;
            }
            catch (Exception e)
            {
                // Récupération de l'exception et affichage du message dans la console
                Console.WriteLine("Une erreur s'est produite : " + e.Message);

                // Retour du résultat de l'opération à la méthode qui en à fait l'appel
                return result;
            }
        }


        public List<Produit> FindProducts()
        {
            // Declaration d'une variable liste de type Produit
            List<Produit> liste;

            try
            {
                // Nouvelle instance de STREAMREADER avec le chemin du fichier en paramètre
                StreamReader reader = new StreamReader(PathFileProduits);

                // Déclaration d'une variable contentOrigine contenant les données du fichier .txt
                string contentOrigine = reader.ReadToEnd();

                // Désérialisation des données Json en Liste de Produits
                liste = (contentOrigine != "") ? JsonConvert.DeserializeObject<List<Produit>>(contentOrigine) : new List<Produit>();

                // Fermeture du reader
                reader.Close();
            }
            catch (Exception e)
            {
                // Initialisation de la valeur à null
                liste = null;

                // Récupération de l'exception et affichage du message dans la console
                Console.WriteLine("Une erreur s'est produite : " + e.Message);
            }
            return liste;
        }
        public bool UpdateProductFile()
        {
            try
            {
                // Nouvelle instance de STREAMWRITER avec le chemin du fichier en paramètre
                StreamWriter w = new StreamWriter(PathFileProduits);

                // Sérialisation en Json des données contenues dans la liste de Produits
                w.WriteLine(JsonConvert.SerializeObject(Produits,Formatting.Indented));

                // Fermeture du WRITER
                w.Close();

                // Retour du résultat de l'opération à la méthode qui en à fait l'appel
                return true;
            }

            catch (Exception e)
            {
                // Récupération de l'exception et affichage du message dans la console
                Console.WriteLine("Une erreur s'est produite : " + e.Message);

                // Retour du résultat de l'opération à la méthode qui en à fait l'appel
                return false;
            }
        }

        public bool UpdateCartFile()
        {
            try
            {
                // Nouvelle instance de STREAMWRITER avec le chemin du fichier en paramètre
                StreamWriter w = new StreamWriter(PathFileCart);

                // Sérialisation en Json des données contenues dans la liste de Produits
                w.WriteLine(JsonConvert.SerializeObject(Cart.Content, Formatting.Indented));

                // Fermeture du WRITER
                w.Close();

                // Retour du résultat de l'opération à la méthode qui en à fait l'appel
                return true;
            }

            catch (Exception e)
            {
                // Récupération de l'exception et affichage du message dans la console
                Console.WriteLine("Une erreur s'est produite : " + e.Message);

                // Retour du résultat de l'opération à la méthode qui en à fait l'appel
                return false;
            }
        }
        public Cart GetCart()
        {
            // Declaration d'une variable liste de type Produit
            Cart cart =new();

            try
            {
                // Nouvelle instance de STREAMREADER avec le chemin du fichier en paramètre
                StreamReader reader = new StreamReader(PathFileCart);

                // Déclaration d'une variable contentOrigine contenant les données du fichier .txt
                string contentOrigine = reader.ReadToEnd();
                
                // Désérialisation des données Json en Liste de Produits
                //cart.Content = (contentOrigine != "") ? JsonConvert.DeserializeObject<List<T>> (contentOrigine) : new List<CartLine>(); // sans méthode perso
                cart.Content = (contentOrigine != "") ? contentOrigine.Deserialize<CartLine>(): new List<CartLine>();

                // Fermeture du reader
                reader.Close();
            }
            catch (Exception e)
            {
                // Initialisation de la valeur à null
                cart = null;

                // Récupération de l'exception et affichage du message dans la console
                Console.WriteLine("Une erreur s'est produite : " + e.Message);
            }
            return cart;
        }
    }
}
