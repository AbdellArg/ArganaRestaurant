using ArganaRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArganaRestaurant.Stores
{
    public class OrderListStore
    {

        public event Action<Product> ProductItemAdded;
        public event Action<Product> ProductRemoved;


        public void AddItem(Product product)
        {
            ProductItemAdded?.Invoke(product);
        }

        public void RemoveItem(Product product)
        {
            ProductRemoved?.Invoke(product);
        }


    }
}
