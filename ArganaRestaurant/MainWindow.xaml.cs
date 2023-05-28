using ArganaRestaurant.Styles.Components;
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

namespace ArganaRestaurant
{

    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            List<ProductsCard> Products = new List<ProductsCard>();
            ProductsCard p1 = new ProductsCard();
            p1.Titel = "Product1";
            p1.Price = "6 €";
            p1.ImageURI = new Uri("Data/ProductsImages/Dish.png", UriKind.Relative);
            ProductsCard p2 = new ProductsCard();
            p1.Titel = "Product3";
            p1.Price = "13 €";
            p1.ImageURI = new Uri("Data/ProductsImages/Dish.png", UriKind.Relative);
            ProductsCard p3 = new ProductsCard();
            p1.Titel = "Product3";
            p1.Price = "9.5 €";
            p1.ImageURI = new Uri("Data/ProductsImages/Dish.png", UriKind.Relative);
            Products.Add(p1);
            Products.Add(p2);
            Products.Add(p3);

            ProductsList.ItemsSource = Products;

        }


        private void MainBackground_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left) 
            {
                this.DragMove();
            }
        }

        bool IsMaximized = false;
        private void MainBackground_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
            {
                if (IsMaximized) 
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    IsMaximized = false;
                }
                else 
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = true;
                }
                
            }
        }

     }
}
