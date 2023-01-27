using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CoursEntityFrameWorkCore.Models;
using CoursEntityFrameWorkCore.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CoursEntityFrameWorkCore.ViewModels
{
    public class CarsViewModels : ObservableObject
    {
        private Car car;
        private DataDbContext dbContext;

        public string Name { get => car.Name; set => car.Name = value; }

        public string Description { get => car.Description; set => car.Description = value; }

        public string Message { get; set; }

        public ICommand ValidCommand { get; set; }

        public CarsViewModels()
        {
            dbContext = new DataDbContext();
            car  = new Car();
            ValidCommand = new RelayCommand(ValidCommandAction);
        }

        private void ValidCommandAction()
        {
            dbContext.Cars.Add(car);
            if(dbContext.SaveChanges() > 0)
            {
                Message = "Voiture ajoutée avec l'id " + car.Id;
                car = new Car();
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Description));
            }
            else
            {
                Message = "Erreur d'ajout dans la base de données";
            }
            OnPropertyChanged(nameof(Message));
        }
    }
}
