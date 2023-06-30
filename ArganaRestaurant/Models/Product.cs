using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArganaRestaurant.Models
{
    public class Product
    {

        public int ProductNr {  get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Uri Image { get; set; }
        public bool IsVegan { get; set; }
        public Categorie Categorie { get; set; }


    }
}
