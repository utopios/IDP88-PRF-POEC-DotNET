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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TpListContactBaseClass.Class;
using TpListContactBaseClass.DAO;

namespace TpListContactIhmWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contact> _contacts;
        public MainWindow()
        {
            InitializeComponent();
            DisplayContact();
            //Contact c = new Contact();
            //new ContactDAO().Create(c);
        }

        private void DisplayContact()
        {
            _contacts = new ContactDAO().FindAll();
            listeViewContacts.ItemsSource = _contacts;
        }

        private void ResetForm(object sender, RoutedEventArgs e)
        {
            BlockTitleForm.Header = "Add Contact";
            boxNom.Text = "";
            boxPrenom.Text = "";
            DpDateOfBirth.Text = "";
            boxTelephone.Text = "";
            boxMail.Text = "";
            boxNum.Text = "N°";
            boxRoad.Text = "road";
            boxPostalCode.Text = "PostalCode";
            boxTown.Text = "City";
            boxCountry.Text = "Country";
            BtnValider.Content = "Ajouter";
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {

        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            if (listeViewContacts.SelectedItem is Contact c)
            {
                BlockTitleForm.Header = "Update Contact";
                BlockId.Text = c.ContactId.ToString();
                PersonIdBlk.Text = c.PersonId.ToString();
                boxNom.Text = c.Lastname;
                boxPrenom.Text = c.Firstname;
                DpDateOfBirth.Text = c.DateOfBirth.ToShortDateString();
                boxTelephone.Text = c.Phone;
                boxMail.Text = c.Email;
                AddressIdBlk.Text = c.ContactAddress.AddressId.ToString();
                boxNum.Text = c.ContactAddress.Number.ToString();
                boxRoad.Text = c.ContactAddress.RoadName;
                boxPostalCode.Text = c.ContactAddress.ZipCode.ToString();
                boxTown.Text = c.ContactAddress.City;
                boxCountry.Text = c.ContactAddress.Country;
                BtnValider.Content = "Modifier";
                BtnValider.Click -= BtnValiderClick;
                BtnValider.Click += UpdateContact;
            }
        }

        private void UpdateContact(object sender, RoutedEventArgs e)
        {
            Contact tmp = new()
            {
                ContactId = int.Parse(BlockId.Text),
                PersonId = int.Parse(PersonIdBlk.Text),
                Firstname = boxPrenom.Text,
                Lastname = boxNom.Text,
                DateOfBirth = (DateTime)DpDateOfBirth.SelectedDate,
                Phone = boxTelephone.Text,
                Email = boxMail.Text,
                ContactAddress = new Address(int.Parse(AddressIdBlk.Text), int.Parse(boxNum.Text), boxRoad.Text, int.Parse(boxPostalCode.Text), boxTown.Text, boxCountry.Text)
            };
            if (new ContactDAO().Update(tmp))
            {
                DisplayContact();
                ResetForm(sender, e);
                BtnValider.Click -= UpdateContact;
                BtnValider.Click += BtnValiderClick;
            }

        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (listeViewContacts.SelectedItem is Contact c)
            {
                MessageBoxResult response = MessageBox.Show($"Etes-vous sur de vouloir supprimer le contact {c.ContactId}?", "Confirmation suppression", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                switch (response)
                {
                    case MessageBoxResult.Cancel:
                        MessageBox.Show("Supression annulée", "Annulation", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        DisplayContact();
                        break;
                    case MessageBoxResult.Yes:
                        if (new ContactDAO().Delete(c))
                        {
                            MessageBox.Show("Contact supprimé", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                            DisplayContact();
                        }
                        else
                            MessageBox.Show("Erreur lors de la suppression du contact", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Supression refusée", "Aborted Delete", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        DisplayContact();
                        break;
                    default:
                        break;
                }

            }
            else
                MessageBox.Show("Veuillez selectionner un contact au préalable!", "Information", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void DetailClick(object sender, RoutedEventArgs e)
        {
            if (listeViewContacts.SelectedItem is Contact c)
            {
                BlockTitleForm.Header = "Details Contact";
                BlockId.Text = c.ContactId.ToString();
                boxNom.Text = c.Lastname;
                boxPrenom.Text = c.Firstname;
                DpDateOfBirth.Text = c.DateOfBirth.ToShortDateString();
                boxTelephone.Text = c.Phone;
                boxMail.Text = c.Email;
                boxNum.Text = c.ContactAddress.Number.ToString();
                boxRoad.Text = c.ContactAddress.RoadName;
                boxPostalCode.Text = c.ContactAddress.ZipCode.ToString();
                boxTown.Text = c.ContactAddress.City;
                boxCountry.Text = c.ContactAddress.Country;
                BtnValider.Content = "Fermer";
                BtnValider.Click -= BtnValiderClick;
                BtnValider.Click += ResetForm;
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un contact au préalable!", "Information", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtnValiderClick(object sender, RoutedEventArgs e)
        {
            if (boxNom.Text != "" && boxPrenom.Text != "" && boxTelephone.Text != "" && boxMail.Text != "" && boxNum.Text != "" && boxRoad.Text != "" && boxPostalCode.Text != "" && boxTown.Text != "" && boxCountry.Text != "")
            {
                Contact tmp = new();
                try
                {
                    tmp.Firstname = boxPrenom.Text;
                    tmp.Lastname = boxNom.Text;
                    tmp.DateOfBirth = (DateTime)DpDateOfBirth.SelectedDate;
                    tmp.Phone = boxTelephone.Text;
                    tmp.Email = boxMail.Text;
                    tmp.ContactAddress = new(int.Parse(boxNum.Text), boxRoad.Text, int.Parse(boxPostalCode.Text), boxTown.Text, boxCountry.Text);
                    tmp.ContactId = new ContactDAO().Create(tmp);
                    if (tmp.ContactId > 0)
                    {
                        DisplayContact();
                        ResetForm(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout du contact...", "Erreur Serveur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Exception Levée", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Veuillez saisir l'integralité des champs", "Erreur ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
