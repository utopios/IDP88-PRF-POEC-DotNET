using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Tools;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CaisseEnregistreuse.ViewModels
{
    public class CategoryViewModel
    {
        private ObservableCollection<Category> _categories;

        private DataDbContext _dataDbContext;
        private Category category;
        public string Name { get => category.Name; set => category.Name = value; }

        public ICommand AddCategoryCommand { get; set; }

        public CategoryViewModel(ObservableCollection<Category> categories, DataDbContext dataDbContext) {
            _categories = categories;
            category = new Category();
            _dataDbContext= new DataDbContext();
            AddCategoryCommand = new RelayCommand(AddCategoryCommandAction);
        }

        private void AddCategoryCommandAction()
        {
            _dataDbContext.Categories.Add(category);
            if(_dataDbContext.SaveChanges() > 0) { 
                _categories.Add(category);
                MessageBox.Show("catégorie ajoutée");
            }
        }
    }
}
