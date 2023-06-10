using ArganaRestaurant.Models;
using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArganaRestaurant.Services
{
    public class DataService
    {

        private IEnumerable<ProductViewModel> AllProducts;

        public DataService() 
        {
            AllProducts = LoadProducts();
        }



        public IEnumerable<ProductViewModel> LoadProducts()
        {

            return new Collection<ProductViewModel>()
            {
                new ProductViewModel { Title = "Marokkanischers Couscous Veggie", Price = 23, Image = new Uri("../../Data/ProductsImages/Muster1.jpg", UriKind.Relative), ProductNr = 1, IsVegan = true, Categorie = new CategorieViewModel { Id = 1, Name = "Drinks" } },
                new ProductViewModel { Title = "Plate1 Chicken Wings", Price = 8, Image = new Uri("Data/ProductsImages/Muster2.jpg", UriKind.Relative), ProductNr = 2, IsVegan = true, Categorie = new CategorieViewModel { Id = 2, Name = "Vegies" }  },
                new ProductViewModel { Title = "Fish Fingers Mit Käse", Price = 15, Image = new Uri("../../Data/ProductsImages/Muster3.jpg", UriKind.Relative), ProductNr = 3, IsVegan = false, Categorie = new CategorieViewModel { Id = 1, Name = "Drinks" }  },
                new ProductViewModel { Title = "Plate2 Lahm Steacks Mit Salad", Price = 7.5, Image = new Uri("../Data/ProductsImages/Muster4.jpg", UriKind.Relative), ProductNr = 4, IsVegan = true, Categorie = new CategorieViewModel { Id = 3, Name = "Breakfasts" }  },
                new ProductViewModel { Title = "Tajine l7amm wl Bar9o9", Price = 15, Image = new Uri("../../Data/ProductsImages/Muster5.jpg", UriKind.Relative), ProductNr = 5, IsVegan = false, Categorie = new CategorieViewModel { Id = 3, Name = "Breakfasts" }  },
                new ProductViewModel { Title = "Tajine GemüsenMischung Veggie", Price = 12, Image = new Uri("../../Data/ProductsImages/Muster6.jpg", UriKind.Relative), ProductNr = 6, IsVegan = true, Categorie = new CategorieViewModel { Id = 2, Name = "Vegies" }  },
                new ProductViewModel { Title = "Marokkanischer MinzenTea", Price = 4.5, Image = new Uri("../../Data/ProductsImages/Muster7.jpg", UriKind.Relative), ProductNr = 7, IsVegan = false, Categorie = new CategorieViewModel { Id = 1, Name = "Drinks" }  }
            };
        }


        public IEnumerable<ProductViewModel> GetVeganProducts()
        {

            return from product in AllProducts
                   where product.IsVegan == true
                   select product;

        }

        public ObservableCollection<CategorieViewModel> LoadCategories()
        {
            return new ObservableCollection<CategorieViewModel>
            {
                new CategorieViewModel { Id = 1, Name = "Drinks" },
                new CategorieViewModel { Id = 2, Name = "Vegies" },
                new CategorieViewModel { Id = 3, Name = "Breakfasts" },
                new CategorieViewModel { Id = 4, Name = "Meals" }
            };
        }


        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            return AllProducts;
        }



        }
}
