using CoursEntityFrameWorkCore.ViewModels;
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

namespace CoursEntityFrameWorkCore.Views
{
    /// <summary>
    /// Logique d'interaction pour Cars.xaml
    /// </summary>
    public partial class Cars : Window
    {
        public Cars()
        {
            InitializeComponent();
            DataContext = new CarsViewModels();
        }
    }
}
