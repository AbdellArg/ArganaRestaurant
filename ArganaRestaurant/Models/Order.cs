using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArganaRestaurant.Models
{
    public class Order
    {
        public int OrderNr { get; set; }
        public int TableNr { get; set; }
        public double Total { get; set; }
        public string? CustomerName { get; set; }
        public List<Product>? OrderItems { get; set; }

    }
}
