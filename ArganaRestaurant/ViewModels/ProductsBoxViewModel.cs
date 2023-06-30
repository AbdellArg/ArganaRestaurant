using ArganaRestaurant.Commands;
using ArganaRestaurant.Models;
using ArganaRestaurant.Ressources.Styles.Components;
using ArganaRestaurant.Services;
using ArganaRestaurant.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace ArganaRestaurant.ViewModels
{
    public class ProductsBoxViewModel : ViewModelBase
    {
        
        private ObservableCollection<ProductViewModel> products;
        private ObservableCollection<Categorie> categories;
        private ObservableCollection<ProductViewModel> orderProducts;
        private readonly DataService dataService;

        public ICommand LoadCategories { get; set; }
        public ICommand LoadProducts { get; set; }
        public ICommand LoadVeganProducts { get; set; }
        public ICommand LoadByCategorie { get; set; }

        public ICollectionView ProductsView { get; set; }



        public ProductsBoxViewModel()
        {
            orderProducts = new();
            //var test = this;
            LoadCategories = new LoadCategoriesCommand(this);
            LoadProducts = new GetProductsCommand(this, false);
            LoadVeganProducts = new GetProductsCommand(this, true);
            LoadByCategorie = new GetProductsByCategorieCommand(this);
            LoadCategories.Execute(null);
            LoadProducts.Execute(null);

            ProductsView = CollectionViewSource.GetDefaultView(products);
            ProductsView.GroupDescriptions.Add(new PropertyGroupDescription("Categorie.Name"));

            //products.ListChanged += Products_ListChanged;
            ProductViewModel.OnQuantityChecked += ItemQuantityChanged;

        }



        

        public void ItemQuantityChanged(ProductViewModel product)
        {
            if (orderProducts.Any(p => p.ProductNr == product.ProductNr))
            {
                var a = orderProducts.Where(p => p.ProductNr == product.ProductNr).Single();

                if (product.Quantity == 0) orderProducts.Remove(a);
            }

            else orderProducts.Add(product);
        }


        private void Products_ListChanged(object? sender, ListChangedEventArgs e)
        {

            products.Where(p => p.Quantity > 0).ToList().ForEach(p => { orderProducts.Add(p); });
            OnPropertyChanged("orderProducts");

        }

        public ObservableCollection<ProductViewModel> Products
        {
            get => products;
            set
            {
                if (products != value)
                {
                    products = value;
                    //products.ListChanged += Products_ListChanged;
                    OnPropertyChanged();
                }
            }
        }


        public ObservableCollection<Categorie> Categories
        {
            get => categories; 
            set
            {
                categories = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<ProductViewModel> OrderProducts
        {
            get => orderProducts;
            set
            {
                if (orderProducts != value)
                {
                    orderProducts = value;
                    OnPropertyChanged();
                }
            }
        }


        //public ObservableCollection<CategorieViewModel> LoadCategories()
        //{
        //    return new ObservableCollection<CategorieViewModel>
        //    {
        //        new CategorieViewModel { Id = 1, Name = "Drinks" },
        //        new CategorieViewModel { Id = 2, Name = "Vegies" },
        //        new CategorieViewModel { Id = 3, Name = "Breakfasts" },
        //        new CategorieViewModel { Id = 4, Name = "Meals" }
        //    };
        //}



    }
}
