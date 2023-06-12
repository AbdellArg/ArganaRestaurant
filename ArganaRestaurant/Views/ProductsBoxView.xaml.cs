using ArganaRestaurant.Commands;
using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArganaRestaurant.Views
{
    /// <summary>
    /// Interaction logic for ProductsBoxView.xaml
    /// </summary>
    public partial class ProductsBoxView : Page
    {

        ProductsBoxViewModel? CurrentViewModel;

        public ProductsBoxView()
        {
            InitializeComponent();

        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentViewModel = this.DataContext as ProductsBoxViewModel;
            //this.DataContext = CurrentViewModel;
            //var LoadCategories = new LoadCategories(CurrentViewModel);
            //LoadCategories.Execute(null);
            //var LoadProducts = new GetProductsCommand(CurrentViewModel, false);
            //LoadProducts.Execute(null);
        }



        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CategorieViewModel SelectedCategorie = ((RadioButton)sender).DataContext as CategorieViewModel;
            var CategorieCommand = new GetProductsByCategorieCommand(CurrentViewModel);
            CategorieCommand.Execute(SelectedCategorie);
        }

        private void Page_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //CurrentViewModel = this.DataContext as ProductsBoxViewModel;
            //var LoadCategories = new LoadCategories(CurrentViewModel);
            //LoadCategories.Execute(null);
            //var LoadProducts = new GetProductsCommand(CurrentViewModel, false);
            //LoadProducts.Execute(null);
        }
    }
}
