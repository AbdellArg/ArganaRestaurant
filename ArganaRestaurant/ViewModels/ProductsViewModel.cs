using ArganaRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArganaRestaurant.ViewModels
{
    internal class ProductsViewModel : ViewModelBase
    {



        private int productNr;
        private string? title;
        private double price;
        private Uri? image;
        private int quantity;
        private bool isVegan;

        public ProductsViewModel()
        {
            this.quantity = 0;
        }

        public int ProductNr
        {
            get => productNr;
            set { productNr = value; }
        }

        public string Title
        {
            get => title;
            set { title = value; }
        }

        public double Price
        {
            get => price;
            set { price = value; }
        }


        public Uri Image
        {
            get => image;
            set { image = value; }
        }


        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                OnPropertyChanged();
            }
        }

        public bool IsVegan
        {
            get => isVegan;
            set { isVegan = value; }
        }


    }
}
