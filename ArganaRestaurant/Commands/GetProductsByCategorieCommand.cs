using ArganaRestaurant.Models;
using ArganaRestaurant.Services;
using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArganaRestaurant.Commands
{
    public class GetProductsByCategorieCommand : CommandBase
    {

        private readonly ProductsBoxViewModel productsVM;
        //private readonly DataService dataService;
        private Categorie? categorie;

        public GetProductsByCategorieCommand(ProductsBoxViewModel productsBoxViewModel)
        {
            productsVM = productsBoxViewModel;
            //dataService = new DataService();
        }

        public override void Execute(object? parameter)
        {
            //List<ProductViewModel> ProductsList = new();


            //if (parameter != null)
            //{
            //    var categorie = parameter as Categorie;
            //    List<Product> AllProducts = dataService.GetAllProducts().ToList();

            //    IEnumerable<Product> products = (from product in AllProducts
            //                                    where product.Categorie.Id == categorie.Id
            //                                    select product).ToList();


            //    foreach (var product in products)
            //    {
            //        ProductsList.Add(new ProductViewModel(product));
            //    }

            //    productsVM.Products = new ObservableCollection<ProductViewModel>(ProductsList);
            //}

            categorie = parameter as Categorie;

            productsVM.ProductsView.Filter += FilterByCat;

        }

        private bool FilterByCat(object obj)
        {
            var product = (ProductViewModel)obj;
            return product.Categorie.Id == categorie.Id;
            
        }

    }
}
