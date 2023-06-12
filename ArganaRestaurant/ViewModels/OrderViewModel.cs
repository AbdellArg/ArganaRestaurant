using ArganaRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArganaRestaurant.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {

        private ObservableCollection<ProductViewModel> items;
        private ProductsBoxViewModel productsViewModel;
        public ProductsBoxViewModel ProductsViewModel
        {
            get => productsViewModel;
            set
            {
                productsViewModel = value;
                OnPropertyChanged(); 
                //productsViewModel.OnPropertyChanged();
            }
        }
        
        private int orderNr;
        private string customerName;
        private int tableNr;
        private double total;


        public ObservableCollection<ProductViewModel> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }


        public int OrderNr
        {
            get => orderNr;
            set 
            { 
                orderNr = value;
                OnPropertyChanged();
            }
        }

        public string CustomerName
        {
            get => customerName;
            set 
            { 
                customerName = value;
                OnPropertyChanged();
            }
        }

        public int TableNr
        {
            get => tableNr;
            set
            {
                tableNr = value;
                OnPropertyChanged();
            }
        }

        public double Total
        {
            get => total;
            set
            {
                total = value;
                OnPropertyChanged();
            }
        }

        public OrderViewModel()
        {
            productsViewModel = new ProductsBoxViewModel();
            Items = new ObservableCollection<ProductViewModel>();
            ProductViewModel a = new ProductViewModel { Title = "Marokkanischers Couscous Veggie", Price = 23, Image = new Uri("../../Data/ProductsImages/Muster1.jpg", UriKind.Relative), ProductNr = 1, IsVegan = true, Categorie = new CategorieViewModel { Id = 1, Name = "Drinks" } };
            Items.Add(a);


            //ProductsViewModel.LoadProducts.Execute(null);
            //ProductsViewModel.LoadProducts.Execute(null);
        }

        //public ObservableCollection<ProductsViewModel> Items { get => items; set => items = value; }






    }
}
