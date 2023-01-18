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
using System.Windows.Shapes;

namespace _01_DécouverteWPF
{
    /// <summary>
    /// Logique d'interaction pour GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
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
