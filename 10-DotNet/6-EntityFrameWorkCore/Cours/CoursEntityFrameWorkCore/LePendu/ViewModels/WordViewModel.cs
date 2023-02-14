using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LePendu.Models;
using LePendu.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LePendu.ViewModels
{
    public class WordViewModel : ObservableObject
    {
        private Word word;
        private DataDbContext dataDbContext;
        public string WordValue { get => word.WordValue; set => word.WordValue = value; }

        public ICommand AddCommand { get; set; }

        public WordViewModel() { 
            word = new Word();
            dataDbContext= new DataDbContext();
            AddCommand = new RelayCommand(AddCommandAction);
        }

        private void AddCommandAction()
        {
            if(WordValue != null)
            {
                dataDbContext.Words.Add(word);
                if(dataDbContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Mot ajouté");
                }
            }
        }


    }
}
