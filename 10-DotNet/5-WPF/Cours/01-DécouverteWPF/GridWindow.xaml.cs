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
    }
}
