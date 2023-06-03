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
        public ProductsBoxView()
        {
            InitializeComponent();
            //ProductsList.ItemsSource = Product.LoadProducts();
            //ProductsBoxViewModel ProductsviewModel = new ProductsBoxViewModel();
            //ProductsList.ItemsSource = ProductsviewModel.Products;
        }
    }
}
