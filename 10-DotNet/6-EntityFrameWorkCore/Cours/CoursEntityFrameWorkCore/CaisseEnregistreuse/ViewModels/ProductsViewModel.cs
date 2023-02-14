using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Tools;
using CaisseEnregistreuse.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
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
    public class ProductsViewModel : ObservableObject
    {
        private Product product;
        private DataDbContext dataDbContext;

        public string SearchText { get; set; }

        public string Title { get => product.Title; set => product.Title = value; }

        public decimal Price { get => product.Price; set => product.Price = value; }

        public int Stock { get => product.Stock; set => product.Stock = value;  }

        public string Description { get => product.Description; set => product.Description = value;  }

        public ICommand ValidCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public ICommand EditCommand { get; set; }

        public ICommand SearchCommand { get; set; }

        public ICommand AddCategoryCommand { get; set; }

        public Product SelectedProduct { get; set; }

        public Category SelectedCategory { get => product.Category; set => product.Category = value; }

        public ObservableCollection<Product> Products { get; set; }

        public ObservableCollection<Category> Categories { get; set; }

        public ProductsViewModel()
        {
            dataDbContext = new DataDbContext();
            product = new Product();
            Products = new ObservableCollection<Product>(dataDbContext.Products);

            Categories = new ObservableCollection<Category>(dataDbContext.Categories);

            ValidCommand = new RelayCommand(ValidCommandAction);
            DeleteCommand = new RelayCommand(DeleteCommandAction);
            EditCommand = new RelayCommand(EditCommandAction);
            SearchCommand = new RelayCommand(SearchCommandAction);
            AddCategoryCommand = new RelayCommand(AddCategoryCommandAction);
        }
        
        private void ValidCommandAction()
        {
            if(product.Id > 0)
            {
                if(dataDbContext.SaveChanges() > 0)
                {
                    product = new Product();
                    OnPropertyChanged(nameof(Title));
                    OnPropertyChanged(nameof(Stock));
                    OnPropertyChanged(nameof(Description));
                    OnPropertyChanged(nameof(Price));
                }
            }
            else
            {
                dataDbContext.Products.Add(product);
                if (dataDbContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Produit ajouté avec l'id " + product.Id);
                    Products.Add(product);
                    product = new Product();
                    OnPropertyChanged(nameof(Title));
                    OnPropertyChanged(nameof(Stock));
                    OnPropertyChanged(nameof(Description));
                    OnPropertyChanged(nameof(Price));
                }
                else
                {
                    MessageBox.Show("Erreur d'ajout dans la base de données");
                }
            }
            
        }

        private void DeleteCommandAction()
        {
            if(SelectedProduct!= null)
            {
                dataDbContext.Products.Remove(SelectedProduct);
                if(dataDbContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Produit supprimé");
                    Products.Remove(SelectedProduct);
                    SelectedProduct = null;
                    OnPropertyChanged(nameof(SelectedProduct));
                }
            }
            else
            {
                MessageBox.Show("Merci de choisir un produit");
            }
        }

        private void EditCommandAction()
        {
            if(SelectedProduct!= null)
            {
                product = SelectedProduct;
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Stock));
                OnPropertyChanged(nameof(Description));
            }
            else
            {
                MessageBox.Show("Merci de choisir un produit");
            }
        }

        private void SearchCommandAction()
        {
            if(SearchText !=null)
            {
                List<Product> searchProducts = dataDbContext.Products.Where(p => p.Title.Contains(SearchText)).ToList();
                Products = new ObservableCollection<Product>(searchProducts);
                
            }else
            {
                Products= new ObservableCollection<Product>(dataDbContext.Products);

            }
            OnPropertyChanged(nameof(Products));
        }

        private void AddCategoryCommandAction()
        {
            CategoryWindow window= new CategoryWindow(Categories, dataDbContext);
            window.Show();
        }
    }
}
