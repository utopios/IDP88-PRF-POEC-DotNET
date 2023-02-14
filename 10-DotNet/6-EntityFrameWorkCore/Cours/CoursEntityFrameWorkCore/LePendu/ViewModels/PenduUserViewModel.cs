using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LePendu.Models;
using LePendu.Tools;
using LePendu.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LePendu.ViewModels
{
    public class PenduUserViewModel : ObservableObject
    {
        private PenduUser user;
        private DataDbContext dataDbContext;
        public string Pseudo { get; set; }
        public string FirstName { get => user.FirstName; set => user.FirstName = value; }

        public string LastName { get => user.LastName; set=> user.LastName = value; }

        public Visibility UserNotExist { get => user == null ? Visibility.Visible : Visibility.Hidden;}

        public ICommand ConnectCommand { get; set; }

        public ICommand RegisterCommand { get; set;}

        public PenduUserViewModel()
        {
            user= new PenduUser();
            dataDbContext = new DataDbContext();
            ConnectCommand = new RelayCommand(ConnectCommandAction);
            RegisterCommand= new RelayCommand(RegisterCommandAction);
        }

        private void ConnectCommandAction()
        {
            user = dataDbContext.Users.Include( u => u.Words).FirstOrDefault(u => u.Pseudo == Pseudo);
            if(user != null)
            {

                //Redirection
                Redirect();
            }
            else
            {
                OnPropertyChanged(nameof(UserNotExist));
                user = new PenduUser();
            }

        }

        private void RegisterCommandAction()
        {
            user.Pseudo = Pseudo;
            dataDbContext.Users.Add(user);
            if(dataDbContext.SaveChanges() > 0)
            {
                //Redirection
                Redirect();
            }
            else
            {
                MessageBox.Show("Erreur ajout");
            }
        }

        private void Redirect()
        {
            GameWindow w = new GameWindow(dataDbContext, user);
            w.Show();
        }
    }
}
