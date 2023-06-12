using ArganaRestaurant.Commands;
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
using System.Windows.Input;

namespace ArganaRestaurant.ViewModels
{
    public class ProductsBoxViewModel : ViewModelBase
    {
        
        private ObservableCollection<ProductViewModel> products;
        private ObservableCollection<CategorieViewModel> categories;
        private ObservableCollection<ProductViewModel> orderProducts;

        public ICommand LoadCategories { get; set; }
        public ICommand LoadProducts { get; set; }
        public ICommand LoadVeganProducts { get; set; }
        public ICommand LoadByCategorie { get; set; }



        public ProductsBoxViewModel()
        {
            //orderProducts = SelectedProducts;
            //var test = this;
            LoadCategories = new LoadCategories(this);
            LoadProducts = new GetProductsCommand(this, false);
            LoadVeganProducts = new GetProductsCommand(this, true);
            LoadByCategorie = new GetProductsByCategorieCommand(this);
            LoadCategories.Execute(null);
            LoadProducts.Execute(null);
            //this.OnPropertyChanged();
        }


        



        public ObservableCollection<ProductViewModel> Products
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


        public ObservableCollection<CategorieViewModel> Categories
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
