using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LePendu.Models;
using LePendu.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LePendu.ViewModels
{
    class GameViewModel : ObservableObject
    {
        private DataDbContext _dataDbContext;
        private PenduUser _user;
        private Word wordToFound;
        public string UserChar { get; set; }
        public int Count { get; set; }
        public string Pseudo { get => _user.Pseudo; }
        public ObservableCollection<Word> UserWords { get; set; }
        
        public string WordMask { get; set; }
        
        public ICommand PlayCommand { get; set; }

        public GameViewModel(DataDbContext dataDbContext, PenduUser user)
        {
            _dataDbContext= dataDbContext;
            _user= user;
            UserWords = new ObservableCollection<Word>(_user.Words);
            Count = 10;
            RandomWord();
            PlayCommand = new RelayCommand(PlayCommandAction);
        }

        private void RandomWord()
        {
            //Random avec entityframework
            wordToFound = _dataDbContext.Words.Include(w => w.Users).Where(w => !w.Users.Contains(_user)).OrderBy(r => Guid.NewGuid()).Take(1).First();
            WordMask = "";
            for(int i=0; i < wordToFound.WordValue.Length; i++)
            {
                WordMask += "*";
            }
            OnPropertyChanged(nameof(WordMask));
        }

        private void PlayCommandAction()
        {
            if(Count > 0)
            {
                string tmpMask = "";
                for(int i=0; i < wordToFound.WordValue.Length; i++) {
                    if (wordToFound.WordValue[i] == Char.Parse(UserChar))
                    {
                        tmpMask+= wordToFound.WordValue[i];
                    }
                    else
                    {
                        tmpMask += WordMask[i];
                    }
                }
                if(WordMask == tmpMask)
                {
                    Count--;
                    OnPropertyChanged(nameof(Count));
                }
                WordMask= tmpMask;
                OnPropertyChanged(nameof(WordMask));
                if(WordMask == wordToFound.WordValue)
                {
                    MessageBox.Show("Bravo");
                    _user.Words.Add(wordToFound);
                    if(_dataDbContext.SaveChanges() > 0)
                    {
                        UserWords.Add(wordToFound);
                    }
                }
            }
        }
    }
}
