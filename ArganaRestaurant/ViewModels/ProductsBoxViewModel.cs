using ArganaRestaurant.Models;
using ArganaRestaurant.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ArganaRestaurant.ViewModels
{
    class ProductsBoxViewModel : INotifyPropertyChanged
    {

        //private int productNr;
        //private string title;
        //private double price;
        //private Uri image;
        //private int quantity;

        private BindingList<Product> products;

        public BindingList<Product> Products
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


        public ProductsBoxViewModel()
        {
            Products = Product.LoadProducts();
        }




        public event PropertyChangedEventHandler? PropertyChanged;


        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));




        //public ProductsBoxViewModel(int ProductNr, string Title, double Price, Uri Image)
        //{
        //    productNr = ProductNr;
        //    title = Title;
        //    price = Price;
        //    image = Image;
        //    quantity = 0;
        //}

        //public int ProductNr
        //{
        //    get { return productNr; }
        //    set { productNr = value; }
        //}

        //public string Title
        //{
        //    get { return title; }
        //    set { title = value; }
        //}

        //public double Price
        //{
        //    get { return price; }
        //    set { price = value; }
        //}


        //public Uri Image
        //{
        //    get { return image; }
        //    set { image = value; }
        //}


        //public int Quantity
        //{
        //    get { return quantity; }
        //    set { quantity = value; }
        //}






    }
}
