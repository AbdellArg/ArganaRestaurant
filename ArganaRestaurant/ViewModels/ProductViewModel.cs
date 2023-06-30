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

        private readonly Product _product;


        public ProductViewModel(Product product)
        {
            _product = product;
            quantity = 0;
            OneMoreProductCommande = new OrderItemQuantityCommand(this, "Plus");
            OneLessProductCommande = new OrderItemQuantityCommand(this, "Minus");
        }



        public ICommand OneMoreProductCommande { get; set; }
        public ICommand OneLessProductCommande { get; set; }

        private int quantity;

        

        public int ProductNr => _product.ProductNr;

        public string Title => _product.Title;

        public double Price => _product.Price;

        public Uri Image => _product.Image;

        public bool IsVegan => _product.IsVegan;

        public Categorie Categorie => _product.Categorie;

        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                OnPropertyChanged();
                OnQuantityChecked?.Invoke(this);
            }
        }

        public static Action<ProductViewModel>? OnQuantityChecked;







    }
}
