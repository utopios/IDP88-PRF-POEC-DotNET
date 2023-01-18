using _01_DécouverteWPF.Models;
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

namespace _01_DécouverteWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MakeBtn();
        }

        void MakeBtn()
        {
            Button b = new Button()
            {
                Content = "Click Me!!!",
                Foreground = Brushes.Black,
                Background = Brushes.OrangeRed,
            };
            b.Click += Button1_Click;
            grid.Children.Add(b);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("Etes-vous sur?", "Question", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

            switch (Result)
            {
                case MessageBoxResult.Yes:
                    ResultatMessageBoxTbc.Text = "Vous avez répondu OUI !";
                    break;
                case MessageBoxResult.No:
                    ResultatMessageBoxTbc.Text = "Vous avez répondu NON !";
                    break;
                case MessageBoxResult.Cancel:
                    ResultatMessageBoxTbc.Text = "Vous avez annulé !";
                    break;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ca marche");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuItem_Click_Grid(object sender, RoutedEventArgs e)
        {
            GridWindow g = new GridWindow();
            g.Show();
            this.Close();
        }

        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Application développée par Anthony Di Persio @2023", "About this application...", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
        }

        private void Ajouter_Click_Btn(object sender, RoutedEventArgs e)
        {
            Personne p = null;
            string nom = NomTbx.Text;
            string prenom = PrenomTbx.Text;
            int age = Convert.ToInt32(AgeTbx.Text);
            if (nom != "" && prenom != "" && age != 0)
            {
                p = new(nom, prenom, age);
            }
            if (p != null)
            {
                ResultatTbc.Text = p.ToString();
            }
        }
    }
}
