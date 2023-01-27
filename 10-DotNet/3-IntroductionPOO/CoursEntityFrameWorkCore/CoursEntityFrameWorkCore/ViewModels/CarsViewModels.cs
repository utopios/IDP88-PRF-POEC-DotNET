using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CoursEntityFrameWorkCore.Models;
using CoursEntityFrameWorkCore.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Car> Cars { get; set; }

        public Car SelectedCar { get; set; }

        public string Name { get => car.Name; set => car.Name = value; }

        public string Description { get => car.Description; set => car.Description = value; }

        public string Message { get; set; }

        public ICommand ValidCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public CarsViewModels()
        {
            dbContext = new DataDbContext();
            Cars= new ObservableCollection<Car>(dbContext.Cars);
            car  = new Car();
            ValidCommand = new RelayCommand(ValidCommandAction);
            DeleteCommand = new RelayCommand(DeleteCommandAction);  
        }

        private void ValidCommandAction()
        {
            dbContext.Cars.Add(car);
            if(dbContext.SaveChanges() > 0)
            {
                Message = "Voiture ajoutée avec l'id " + car.Id;
                //On ajoute dans la collection à afficher dans la listeview
                Cars.Add(car);
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

        private void DeleteCommandAction()
        {
            dbContext.Cars.Remove(SelectedCar);
            if(dbContext.SaveChanges() > 0)
            {
                Message = "Voiture supprimée";
                OnPropertyChanged(nameof(Message));
                Cars.Remove(SelectedCar);
                SelectedCar = null;
            }
        }
    }
}
