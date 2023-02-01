using LePendu.ViewModels;
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

namespace LePendu.Views
{
    /// <summary>
    /// Logique d'interaction pour UserPenduWindow.xaml
    /// </summary>
    public partial class UserPenduWindow : Window
    {
        public UserPenduWindow()
        {
            InitializeComponent();
            DataContext = new PenduUserViewModel();
        }
    }
}
