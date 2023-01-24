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
using TpCompteBancaireHeritageWPF.Classes;
using TpCompteBancaireHeritageWPF.DAO;

namespace TpCompteBancaireHeritageWPF
{
    /// <summary>
    /// Logique d'interaction pour RetraitOperationWindow.xaml
    /// </summary>
    public partial class RetraitOperationWindow : Window
    {
        Compte cTmp = new();
        MainWindow w;
        public RetraitOperationWindow(int numCompte, MainWindow window)
        {
            InitializeComponent();
            cTmp = new CompteDAO().Get(numCompte);
            w = window;
            cTmp.ADecouvert += MainWindow.ActionNotificationDecouvert;
            TbIdCompte.Text = numCompte.ToString();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            decimal montant;
            if (decimal.TryParse(TbxMontant.Text, out montant))
            {
                Operation o = new Operation(montant * -1);
                bool result = new OperationDAO().Save(o, cTmp.Id);
                cTmp.Retrait(o);
                if (cTmp.GetType() == typeof(ComptePayant))
                {
                    ComptePayant cp = (ComptePayant)cTmp;
                    o = new Operation(cp.CoutOperation * -1);
                    result = new OperationDAO().Save(o, cp.Id);
                    cp.Retrait(o);
                    result = new ComptePayantDAO().Update(cp);
                }
                else if(cTmp.GetType() == typeof(CompteEpargne))
                {
                    CompteEpargne ce = (CompteEpargne)cTmp;
                    result = new CompteEpargneDAO().Update(ce);
                }
                else
                    result = new CompteDAO().Update(cTmp);



                MessageBox.Show($"Le retrait de {montant} € a été effectué", "Retrait effectué", MessageBoxButton.OK, MessageBoxImage.Information);
                if (result)
                    w.ActualiserCompte(cTmp.Id);
                Close();
            }
            else
                MessageBox.Show("Erreur de saisie du montant", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
