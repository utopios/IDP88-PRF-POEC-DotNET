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
using TpNbMystere.models;

namespace TpNbMystere
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NombreMystere _jeu;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            _jeu = new();
            Ligne1Tbc.Text = "";
            Ligne2Tbc.Text = "Veuillez saisir un chiffre/nombre :";
            UpdateNbCoups();
            UserNumTbx.Text = "";
            ValiderBtn.IsEnabled = true;
        }
        private void UpdateNbCoups()
        {
            NbCoupsTbc.Text = $"Nombre d'essais : {_jeu.NbCoups}";
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StartGame();
        }
        private void ValiderBtn_Click(object sender, RoutedEventArgs e)
        {
            // récupérer la saisie utilisateur
            int PickedNum;
            string picked = UserNumTbx.Text;
            // Casting de chaine en Entier
            bool isNumeric = int.TryParse(picked, out PickedNum);
            if (!isNumeric)
                Ligne1Tbc.Text = "Erreur de saisie";
            else
            {
                // Envoyer a la méthode TestNumber() qui nous retourne le résultat qui est loggué
                Ligne1Tbc.Text = _jeu.TestNumber(PickedNum);
                // Update Nb Coups
                UpdateNbCoups();
                if (_jeu.Gagne)                
                    YouWin();
                
            }

            UserNumTbx.Text = "";
            
        }

        private void YouWin()
        {
            Ligne2Tbc.Text = $"Le nombre mystère était {_jeu.NbMystere}";
            ValiderBtn.IsEnabled= false;
        }

        private void NouvellePartieBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nouvelle Partie");
        }

        private void UserNumTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            StartGame();
        }
    }
}
