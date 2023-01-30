using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Tools;
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

        public string Title { get => product.Title; set => product.Title = value; }

        public decimal Price { get => product.Price; set => product.Price = value; }

        public int Stock { get => product.Stock; set => product.Stock = value;  }

        public string Description { get => product.Description; set => product.Description = value;  }

        public ICommand ValidCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public ICommand EditCommand { get; set; }

        public Product SelectedProduct { get; set; }

        public ObservableCollection<Product> Products { get; set; }

        public ProductsViewModel()
        {
            dataDbContext = new DataDbContext();
            product = new Product();
            Products = new ObservableCollection<Product>(dataDbContext.Products);
            ValidCommand = new RelayCommand(ValidCommandAction);
            DeleteCommand = new RelayCommand(DeleteCommandAction);
            EditCommand = new RelayCommand(EditCommandAction);
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
    }
}
