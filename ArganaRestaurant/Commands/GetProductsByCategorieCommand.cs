using ArganaRestaurant.Services;
using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArganaRestaurant.Commands
{
    public class GetProductsByCategorieCommand : CommandBase
    {

        private readonly ProductsBoxViewModel productsVM;
        private readonly DataService dataService;

        public GetProductsByCategorieCommand(ProductsBoxViewModel productsBoxViewModel)
        {
            productsVM = productsBoxViewModel;
            dataService = new DataService();
        }


        public override void Execute(object? parameter)
        {
            if (parameter != null)
            {
                var categorie = parameter as CategorieViewModel;
                IEnumerable<ProductViewModel> products = from product in dataService.GetAllProducts()
                                                         where product.Categorie.Id == categorie.Id
                                                         select product;
                productsVM.Products = new ObservableCollection<ProductViewModel>(products);
            }
            
        }
    }
}
