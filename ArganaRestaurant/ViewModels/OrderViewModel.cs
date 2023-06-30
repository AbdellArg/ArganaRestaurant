using ArganaRestaurant.Commands;
using ArganaRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArganaRestaurant.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {

        private ProductsBoxViewModel productsViewModel;
        private ObservableCollection<ProductViewModel> items; 
        public ICommand ClearItemsCommand { get; }

        private int orderNr;
        private string customerName;
        private int tableNr;
        private double total;


         public OrderViewModel(ProductsBoxViewModel productsBoxViewModel)
        {
            productsViewModel = productsBoxViewModel;
            Items = productsBoxViewModel.OrderProducts;
            ClearItemsCommand = new RelayCommand(a => ClearOrderItems());
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

        public ProductsBoxViewModel ProductsViewModel
        {
            get => productsViewModel;
            set
            {
                productsViewModel = value;
                OnPropertyChanged(); 
            }
        }

        public ObservableCollection<ProductViewModel> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }  


        public void ClearOrderItems()
        {
            foreach (var product in productsViewModel.Products)
            {
                product.Quantity = 0;
            }
            total = 0;
            items.Clear();
        }




    }
}
