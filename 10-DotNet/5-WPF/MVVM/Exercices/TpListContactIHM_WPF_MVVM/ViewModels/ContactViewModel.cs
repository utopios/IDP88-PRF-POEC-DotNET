using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TpListContactBaseClass.Class;
using TpListContactBaseClass.DAO;

namespace TpListContactIHM_WPF_MVVM.ViewModels
{
    class ContactViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Contact> contacts;
        private Contact contact;
        private Contact selectedContact;
        private bool readOnly;
        private string buttonName;
        private string formName;
        private string searchString;

        public ObservableCollection<Contact> Contacts
        {
            get => contacts;
            set
            {
                contacts = value;
                RaisePropertyChanged("Contacts");
            }
        }
        public Contact Contact
        {
            get => contact;
            set
            {
                contact = value;
                RaisePropertyChanged("FirstName");
                RaisePropertyChanged("LastName");
                RaisePropertyChanged("DateBirth");
                RaisePropertyChanged("PhoneNumber");
                RaisePropertyChanged("EmailContact");
                RaisePropertyChanged("AddressContact");
            }
        }
        public Contact SelectedContact
        {
            get => selectedContact;
            set
            {
                selectedContact = value;
                RaisePropertyChanged("SelectedContact");
            }
        }

        public string FirstName
        {
            get => Contact.Firstname;
            set
            {
                if (!readOnly)
                    Contact.Firstname = value;
                RaisePropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get => Contact.Lastname;
            set
            {
                if (!readOnly)
                    Contact.Lastname = value;
                RaisePropertyChanged("LastName");
            }
        }
        public string PhoneNumber
        {
            get => Contact.Phone;
            set
            {
                if (!readOnly)
                    Contact.Phone = value;
                RaisePropertyChanged("PhoneNumber");
            }
        }
        public string EmailContact
        {
            get => Contact.Email;
            set
            {
                if (!readOnly)
                    Contact.Email = value;
                RaisePropertyChanged("EmailContact");
            }
        }

        public DateTime DateBirth
        {
            get => Contact.DateOfBirth;
            set
            {
                if (!readOnly)
                    Contact.DateOfBirth = value;
                RaisePropertyChanged("DateBirth");
            }
        }

        public Address AddressContact
        {
            get => Contact.ContactAddress;
            set
            {
                if (!readOnly)
                    Contact.ContactAddress = value;
                RaisePropertyChanged("AddressContact");
            }
        }
        public string ButtonName
        {
            get => buttonName;
            set
            {
                buttonName = value;
                RaisePropertyChanged("ButtonName");
            }
        }
        public string FormName
        {
            get => formName;
            set
            {
                formName = value;
                RaisePropertyChanged("FormName");
            }
        }

        public string SearchString
        {
            get => searchString;
            set
            {
                searchString = value;
                RaisePropertyChanged("SearchString");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        #region Constructeur

        public ContactViewModel()
        {
            FetchList();
            ResetForm();
            SearchCommand = new RelayCommand(SearchAction);
            ConfirmCommand = new RelayCommand(ConfirmAction);
            EditCommand = new RelayCommand(EditAction);
            DeleteCommand = new RelayCommand(DeleteAction);
            DetailsCommand = new RelayCommand(DetailsAction);
        }
        #endregion




        #region ICommand
        public ICommand SearchCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand DetailsCommand { get; set; }
        #endregion


        #region Méthodes

        private void FetchList()
        {
            Contacts = new ContactDAO().FindAll();
        }


        private void DetailsAction()
        {
            if (SelectedContact != null)
            {
                Contact = SelectedContact;
                FormName = $" Contact n°{Contact.ContactId} ";
                ButtonName = " Fermer ";
                readOnly = true;
            }
        }

        private void DeleteAction()
        {
            if (SelectedContact != null)
            {
                MessageBoxResult result = MessageBox.Show($"Etes-vous sûr de vouloir supprimer le contact N°{SelectedContact.ContactId}?", "Demmande de suppression", MessageBoxButton.YesNo, MessageBoxImage.Question);

                switch (result)
                {
                    case MessageBoxResult.Yes:
                        bool res = new ContactDAO().Delete(SelectedContact);
                        if (res)
                            Contacts.Remove(SelectedContact);
                        else
                            MessageBox.Show($"Erreur lors de la suppression du contact... veuillez ré-essayer", "Error...", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    case MessageBoxResult.No:

                        break;
                    default:
                        break;
                }
            }
        }

        private void EditAction()
        {
            if (SelectedContact != null)
            {
                Contact = SelectedContact;
                FormName = " Update Contact ";
                ButtonName = " Modifier ";
            }

        }

        private void ResetForm()
        {
            Contact = new Contact();
            FormName = " Add Contact ";
            ButtonName = " Ajouter ";
        }

        private void ConfirmAction()
        {
            if (Contact.ContactId == 0 && !readOnly)
            {
                Contact.ContactId = new ContactDAO().Create(Contact);
                if (Contact.ContactId > 0)
                {
                    MessageBox.Show($"Contact ajouté avec l'Id {Contact.ContactId}", "Succes...", MessageBoxButton.OK, MessageBoxImage.Information);

                    Contacts.Add(Contact);

                    ResetForm();
                }
                else
                {
                    MessageBox.Show($"Erreur lors de l'ajout du contact... veuillez ré-essayer", "Error...", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else if (readOnly)
            {
                readOnly = false;
                ResetForm();
            }
            else
            {
                if (new ContactDAO().Update(Contact))
                {
                    MessageBox.Show($"Contact modifié...", "Update Succes...", MessageBoxButton.OK, MessageBoxImage.Information);
                    FetchList();
                    ResetForm();
                }
                else
                    MessageBox.Show($"Erreur lors de l'update du contact... veuillez ré-essayer", "Error...", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void SearchAction()
        {
            if (searchString != "")
            {
                bool found = false;
                ObservableCollection<Contact> contactsTmp = new ObservableCollection<Contact>();
                foreach (Contact contact in Contacts)
                {
                    if (contact.Phone.Contains(SearchString) || contact.Firstname.Contains(SearchString) || contact.Lastname.Contains(SearchString))
                    {
                        contactsTmp.Add(contact);
                        found = true;
                    }
                }
                if (found)
                {
                    Contacts = contactsTmp;
                    SearchString = "";
                }
                else
                    MessageBox.Show($"Aucun contact trouvé avec ce nom, ce prénom ou ce numéro de téléphone", "Error...", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                FetchList();

        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}
