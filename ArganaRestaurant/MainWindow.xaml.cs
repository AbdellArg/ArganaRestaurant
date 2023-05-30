using ArganaRestaurant.Styles.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

            var Products = new List<ProductsCard>();

            ProductsCard p1 = new()
            {
                Titel = "Marokkanischers Couscous Veggie",
                Price = "23 €",
                ImageURI = new Uri("Data/ProductsImages/Couscous1.png", UriKind.Relative)
            };
            
            ProductsCard p2 = new()
            {
                Titel = "Fish Fingers Mit Käse",
                Price = "15 €",
                ImageURI = new Uri("Data/ProductsImages/Dish.png", UriKind.Relative)
            };
            ProductsCard p3 = new()
            {
                Titel = "Plate1 Chicken Wings",
                Price = "8 €",
                ImageURI = new Uri("Data/ProductsImages/Plate1.png", UriKind.Relative)
            };
            ProductsCard p4 = new()
            {
                Titel = "Plate2 Lahm Steacks Mit Salad",
                Price = "7.5 €",
                ImageURI = new Uri("Data/ProductsImages/Plate2.png", UriKind.Relative)
            };
            ProductsCard p5 = new()
            {
                Titel = "Tajine l7amm wl Bar9o9",
                Price = "15 €",
                ImageURI = new Uri("Data/ProductsImages/Tajine.png", UriKind.Relative)
            };
            ProductsCard p6 = new()
            {
                Titel = "Tajine GemüsenMischung Veggie",
                Price = "12 €",
                ImageURI = new Uri("Data/ProductsImages/Tajine2.png", UriKind.Relative)
            };
            ProductsCard p7 = new()
            {
                Titel = "Marokkanischer MinzenTea",
                Price = "4.5 €",
                ImageURI = new Uri("Data/ProductsImages/Tea.jpg", UriKind.Relative)
            };
            Products.Add(p1);
            Products.Add(p2);
            Products.Add(p3); 
            Products.Add(p4);
            Products.Add(p5);
            Products.Add(p6);
            Products.Add(p7);

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
