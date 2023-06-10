using ArganaRestaurant.Services;
using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (isVegan)
            {
                productsVM.Products = new ObservableCollection<ProductViewModel>(dataService.GetVeganProducts().ToList());
            }
            else
            {
                productsVM.Products = new ObservableCollection<ProductViewModel>(dataService.GetAllProducts().ToList());
            }
        }



        
    }
}
