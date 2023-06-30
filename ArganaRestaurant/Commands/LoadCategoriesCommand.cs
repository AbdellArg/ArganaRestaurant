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

namespace ArganaRestaurant.Commands
{
    public class LoadCategoriesCommand : CommandBase
    {

        private readonly DataService dataService;
        private readonly ProductsBoxViewModel ProductsViewModel;


        public LoadCategoriesCommand(ProductsBoxViewModel ProductsVM) 
        {
            dataService = new DataService();
            ProductsViewModel = ProductsVM;
        }


        public override void Execute(object? parameter)
        {

            ProductsViewModel.Categories = new ObservableCollection<Categorie>(dataService.LoadCategories());
        }
    }
}
