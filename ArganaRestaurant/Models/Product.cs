using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArganaRestaurant.Models
{
    class Product
    {

        private int productNr;
        private string? title;
        private double price;
        private Uri? image;
        private int quantity;

        public int ProductNr
        {
            get { return productNr; }
            set { productNr = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public Uri Image
        {
            get { return image; }
            set { image = value; }
        }


        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }



        public Product()
        {
			Quantity = 0;
        }


        public static List<Product> LoadProducts()
        {
            return new List<Product>
            {
                new Product { Title = "Marokkanischers Couscous Veggie", Price = 23, Image = new Uri("../../Data/ProductsImages/Couscous1.png", UriKind.Relative),ProductNr = 1},
                new Product { Title = "Plate1 Chicken Wings", Price = 8, Image = new Uri("Data/ProductsImages/Plate1.png", UriKind.Relative),  ProductNr = 2},
                new Product { Title = "Fish Fingers Mit Käse", Price = 15, Image = new Uri("../../Data/ProductsImages/Dish.png", UriKind.Relative), ProductNr = 3},
                new Product { Title = "Plate2 Lahm Steacks Mit Salad",Price = 7.5, Image = new Uri("../Data/ProductsImages/Plate2.png", UriKind.Relative), ProductNr = 4},
                new Product { Title = "Tajine l7amm wl Bar9o9", Price = 15, Image = new Uri("../../Data/ProductsImages/Tajine.png", UriKind.Relative), ProductNr = 5 },
                new Product { Title = "Tajine GemüsenMischung Veggie", Price = 12, Image = new Uri("../../Data/ProductsImages/Tajine2.png", UriKind.Relative), ProductNr = 6 },
                new Product { Title = "Marokkanischer MinzenTea", Price = 4.5, Image = new Uri("../../Data/ProductsImages/Tea.jpg", UriKind.Relative), ProductNr = 7 }
            };

        }


    }
}
