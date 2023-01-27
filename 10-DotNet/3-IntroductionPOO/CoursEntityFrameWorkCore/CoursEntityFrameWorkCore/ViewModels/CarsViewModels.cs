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
    public class CarsViewModels
    {
        private Car car;
        private DataDbContext dbContext;

        public string Name { get => car.Name; set => car.Name = value; }

        public string Description { get => car.Description; set => car.Description = value; }

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
                MessageBox.Show(car.Id.ToString());
            }
        }
    }
}
