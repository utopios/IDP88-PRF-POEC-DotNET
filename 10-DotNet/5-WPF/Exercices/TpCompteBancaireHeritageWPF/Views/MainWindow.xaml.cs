using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TpCompteBancaireHeritageWPF.Classes;
using TpCompteBancaireHeritageWPF.DAO;

namespace TpCompteBancaireHeritageWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Compte c;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RechercherCompte_Click(object sender, RoutedEventArgs e)
        {
            if (TbxIdCompte.Text != "")
                ActualiserCompte(Convert.ToInt32(TbxIdCompte.Text));
            else
                MessageBox.Show("Veuillez saisir un Id", "Erreur saisie", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void ActualiserCompte(int NumCompte)
        {
            c = new();
            c = new CompteDAO().Get(NumCompte);
            CalculInteret.IsEnabled = false;
            TbTypeCompte.Text = "Normal";
            if (c != null)
            {
                if (c.GetType() == typeof(CompteEpargne))
                {
                    CalculInteret.IsEnabled = true;
                    TbTypeCompte.Text = "Epargne";
                }
                else if (c.GetType() == typeof(ComptePayant))
                {
                    TbTypeCompte.Text = "Payant";
                }

                Nom.Text = c.Client.Nom;
                Prenom.Text = c.Client.Prenom;
                Telephone.Text = c.Client.Telephone;
                TbIdCompte.Text = c.Id.ToString();
                TbSoldeCompte.Text = c.Solde.ToString();
                ListeViewOperations.ItemsSource = c.Operations;
                c.ADecouvert += ActionNotificationDecouvert;
            }
            else
                MessageBox.Show("Aucun compte trouvé avec cet Id", "Erreur Compte non trouvé", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public static void ActionNotificationDecouvert(decimal solde, int numero)
        {
            MessageBox.Show($"Le compte n°{numero} est à découvert, voici le nouveau solde {solde}€", "Informations Compte à Découvert!", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void CalculInteret_Click(object sender, RoutedEventArgs e)
        {
            if (c != null && c is CompteEpargne compteEpargne)
            {
                MessageBoxResult response = MessageBox.Show("Etes-vous sur de vouloir Calculer les intérêts pour ce compte?", "Question...?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                switch (response)
                {
                    case MessageBoxResult.Yes:
                        Operation o = new Operation(compteEpargne.CalculerInteret());
                        compteEpargne.Depot(o);
                        bool result = new OperationDAO().Save(o, compteEpargne.Id);
                        if (result)
                        {
                            result = new CompteEpargneDAO().Update(compteEpargne);
                            if (result)
                                ActualiserCompte(compteEpargne.Id);
                            
                        }


                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Calcul intérêts annulé", "Information?", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                }
            }
        }

        private void FaireDepot_Click(object sender, RoutedEventArgs e)
        {
            if (TbxIdCompte.Text != "")
            {
                DepotOperationWindow d = new DepotOperationWindow(Convert.ToInt32(TbxIdCompte.Text), this);
                d.Show();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un compte...", "Erreur Compte non trouvé", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void FaireRetrait_Click(object sender, RoutedEventArgs e)
        {
            if (TbxIdCompte.Text != "")
            {
                RetraitOperationWindow d = new RetraitOperationWindow(Convert.ToInt32(TbxIdCompte.Text), this);
                d.Show();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un compte...", "Erreur Compte non trouvé", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void MenuNouveauCompte_Click(object sender, RoutedEventArgs e)
        {
            AjouterCompteWindow w = new AjouterCompteWindow();
            w.Show();
        }
    }
}
