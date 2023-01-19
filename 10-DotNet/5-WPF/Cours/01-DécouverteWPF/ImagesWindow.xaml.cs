using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Logique d'interaction pour ImagesWindow.xaml
    /// </summary>
    public partial class ImagesWindow : Window
    {
        public ImagesWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = -1;
            // Récupère l'ensemble des enfant de typ iamge présent dans le parent
            var images = ImagesDkp.Children.OfType<Image>();
            // Chercher celle dont la props visibility est à visible
            Image image = images.FirstOrDefault(img => img.Visibility == Visibility.Visible);
            // Effondrement de l'image
            image.Visibility = Visibility.Collapsed;
            // Mise sous table de la collection d'image presente dans le conteneneur d'image
            Image[] imgTmp = images.ToArray();
            // Recherche de l'index de la prochaine image dans la liste
            index = Array.IndexOf(imgTmp, image);
            string imgName;

            if (index < 2)
            {
                index++;
                imgName = "Img" + index;
            }
            else            
                imgName = "Img0";

            // Recherche l'image suivant à afficher
            Image tmp = images.FirstOrDefault(img => img.Name == imgName);
            // Affichage de l'image
            tmp.Visibility = Visibility.Visible;

        }
    }
}
