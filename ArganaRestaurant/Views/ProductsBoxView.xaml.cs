using ArganaRestaurant.Commands;
using ArganaRestaurant.Models;
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

        public ProductsBoxView(ProductsBoxViewModel productsBoxViewModel)
        {
            InitializeComponent();

            this.DataContext = productsBoxViewModel;
        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentViewModel = this.DataContext as ProductsBoxViewModel;
        }



        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Categorie? SelectedCategorie = ((RadioButton)sender).DataContext as Categorie;
            var CategorieCommand = new GetProductsByCategorieCommand(CurrentViewModel);
            CategorieCommand.Execute(SelectedCategorie);
        }

    }
}
