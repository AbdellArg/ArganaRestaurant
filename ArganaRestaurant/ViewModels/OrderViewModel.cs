using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArganaRestaurant.ViewModels
{
    public class OrderViewModel
    {

        public OrderViewModel()
        {

        }

        //public ObservableCollection<ProductsViewModel> Items { get => items; set => items = value; }



        private int orderId;
        private ObservableCollection<ProductViewModel> items;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }



    }
}
