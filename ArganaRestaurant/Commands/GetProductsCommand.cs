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
using System.Windows.Data;

namespace ArganaRestaurant.Commands
{
    public class GetProductsCommand : CommandBase
    {

        private readonly ProductsBoxViewModel productsVM;
        private readonly bool isVegan;

        private readonly DataService dataService;

        public GetProductsCommand(ProductsBoxViewModel ProductsViewModel, bool IsVegan) 
        {
            productsVM = ProductsViewModel;
            isVegan = IsVegan;
            dataService = new DataService();
        }



    public override void Execute(object? parameter)
        {
            if (productsVM.Products == null)
            {
                // for the first, when the ProductsBoxViewModel loaded, we load all the Products 

                List<ProductViewModel> ProductsList = new();

                foreach (var product in dataService.GetAllProducts())
                {
                    ProductsList.Add(new ProductViewModel(product));
                }

                productsVM.Products = new ObservableCollection<ProductViewModel>(ProductsList);
            }

            else
            {
                productsVM.ProductsView.Filter += FilterByCat;
            }

        }

        private bool FilterByCat(object obj)
        {
            if (isVegan)
            {
                var product = (ProductViewModel)obj;
                return product.IsVegan;
            }
            else return true;

        }


    }
}
