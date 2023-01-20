using _01_DécouverteWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour ListViewWindow.xaml
    /// </summary>
    public partial class ListViewWindow : Window
    {

        private static ObservableCollection<Personne> _personnes;

        public ListViewWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _personnes = new();
            AddToList();
            DisplayPersonne();
        }

        private void AddToList()
        {
            Personne p1 = new("Di Persio", "Anthony", 25);
            Personne p2 = new("Abadi", "Ihab", 35);
            Personne p3 = new("Abadi", "Marine", 22);
            Personne p4 = new("Dark", "Jeanne", 125);

            _personnes.Add(p1);
            _personnes.Add(p2);
            _personnes.Add(p3);
            _personnes.Add(p4);
        }

        private void DisplayPersonne()
        {
            ListeBoxPersonne.ItemsSource = _personnes;
        }
    }
}
