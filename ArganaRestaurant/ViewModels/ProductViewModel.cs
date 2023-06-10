using ArganaRestaurant.Commands;
using ArganaRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArganaRestaurant.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {

        public ProductViewModel()
        {
            this.quantity = 0;
            OneMoreProductCommande = new OrderItemQuantityCommand(this, "Plus");
            OneLessProductCommande = new OrderItemQuantityCommand(this, "Minus");
        }



        public ICommand OneMoreProductCommande { get; set; }
        public ICommand OneLessProductCommande { get; set; }

        private int productNr;
        private string title;
        private double price;
        private Uri image;
        private int quantity;
        private bool isVegan;
        private CategorieViewModel categorie;

        

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

        public CategorieViewModel Categorie
        {
            get => categorie;
            set { categorie = value; }
        }






    }
}
