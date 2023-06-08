using ArganaRestaurant.Models;
using ArganaRestaurant.Ressources.Styles.Components;
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

namespace ArganaRestaurant.ViewModels
{
    class ProductsBoxViewModel : ViewModelBase
    {



        private BindingList<ProductsViewModel> products;

        private BindingList<CategoriesViewModel> categories;



        public BindingList<ProductsViewModel> Products
        {
            get => products;
            set
            {
                if (products != value)
                {
                    products = value;
                    OnPropertyChanged();
                }
            }
        }


        public BindingList<CategoriesViewModel> Categories
        {
            get { return categories; }
            set { categories = value; }
        }





        public ProductsBoxViewModel()
        {
            Products = LoadProducts();
            Products.ListChanged += Products_ListChanged;

            Categories = LoadCategories();
 
        }

        private void Products_ListChanged(object? sender, ListChangedEventArgs e)
        {
            BindingList<ProductsViewModel>? prods = sender as BindingList<ProductsViewModel>;
            //Products = prods;
            OnPropertyChanged(nameof(Products));
            //this.Products = Prods;
        }


        public BindingList<ProductsViewModel> FilterByIsVegan()
        {
            var FiltredList = (from product in Products where product.IsVegan == false  select product).ToList();

            return new BindingList<ProductsViewModel>(FiltredList);
        }


        public static BindingList<ProductsViewModel> LoadProducts()
        {
            return new BindingList<ProductsViewModel>
            {
                new ProductsViewModel { Title = "Marokkanischers Couscous Veggie", Price = 23, Image = new Uri("../../Data/ProductsImages/Muster1.jpg", UriKind.Relative),ProductNr = 1, IsVegan = true},
                new ProductsViewModel { Title = "Plate1 Chicken Wings", Price = 8, Image = new Uri("Data/ProductsImages/Muster2.jpg", UriKind.Relative),  ProductNr = 2, IsVegan = true},
                new ProductsViewModel { Title = "Fish Fingers Mit Käse", Price = 15, Image = new Uri("../../Data/ProductsImages/Muster3.jpg", UriKind.Relative), ProductNr = 3, IsVegan = false},
                new ProductsViewModel { Title = "Plate2 Lahm Steacks Mit Salad",Price = 7.5, Image = new Uri("../Data/ProductsImages/Muster4.jpg", UriKind.Relative), ProductNr = 4, IsVegan = true},
                new ProductsViewModel { Title = "Tajine l7amm wl Bar9o9", Price = 15, Image = new Uri("../../Data/ProductsImages/Muster5.jpg", UriKind.Relative), ProductNr = 5 , IsVegan = false},
                new ProductsViewModel { Title = "Tajine GemüsenMischung Veggie", Price = 12, Image = new Uri("../../Data/ProductsImages/Muster6.jpg", UriKind.Relative), ProductNr = 6, IsVegan = true },
                new ProductsViewModel { Title = "Marokkanischer MinzenTea", Price = 4.5, Image = new Uri("../../Data/ProductsImages/Muster7.jpg", UriKind.Relative), ProductNr = 7, IsVegan = false }
            };
        }

        public BindingList<CategoriesViewModel> LoadCategories()
        {
            return new BindingList<CategoriesViewModel>
            {
                new CategoriesViewModel { Id = 1, Name = "Drinks" },
                new CategoriesViewModel { Id = 2, Name = "Vegies" },
                new CategoriesViewModel { Id = 3, Name = "Breakfasts" },
                new CategoriesViewModel { Id = 4, Name = "Meals" }
            };
        }



    }
}
