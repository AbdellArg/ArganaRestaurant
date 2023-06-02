using ArganaRestaurant.Models;
using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArganaRestaurant.Ressources.Styles.Components
{
    /// <summary>
    /// Interaction logic for ProductsCard.xaml
    /// </summary>
    public partial class ProductCard : UserControl
    {


        public string Titel
        {
            get { return (string)GetValue(TitetProperty); }
            set { SetValue(TitetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titet.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitetProperty =
            DependencyProperty.Register("Titel", typeof(string), typeof(ProductCard), new PropertyMetadata("N/A"));


        

        public Uri ImageURI
        {
            get { return (Uri)GetValue(ImageURIProperty); }
            set { SetValue(ImageURIProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageURI.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageURIProperty =
            DependencyProperty.Register("ImageURI", typeof(Uri), typeof(ProductCard), new PropertyMetadata());





        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Price.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(string), typeof(ProductCard), new PropertyMetadata(string.Empty));




        public int Totale
        {
            get { return (int)GetValue(TotaleProperty); }
            set { SetValue(TotaleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Totale.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotaleProperty =
            DependencyProperty.Register("Totale", typeof(int), typeof(ProductCard), new PropertyMetadata(0));


        public void Selected()
        {
            this.CardHolder.BorderBrush = new SolidColorBrush(Colors.Gold);
            this.CardHolder.BorderThickness = new Thickness(5);
        }


        public ProductCard()
        {
            InitializeComponent();
        }

        private void AddToOrders_Click(object sender, RoutedEventArgs e)
        {
            this.AddToOrders.Visibility = Visibility.Hidden;
            this.ItemCountity.Visibility = Visibility.Visible;
            this.ItemPrice.Visibility = Visibility.Hidden;
            this.Totale = 1;
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Totale > 1)
                this.Totale--;
            else
            {
                this.Totale = 0;
                this.AddToOrders.Visibility = Visibility.Visible;
                this.ItemCountity.Visibility = Visibility.Hidden;
                this.ItemPrice.Visibility = Visibility.Visible;
            }
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            this.Totale++;
            ((Product)this.DataContext).Title = "test";
            
        }


        //public event PropertyChangedEventHandler? PropertyChanged;

        //private static void OnQuantityChanged(
        //DependencyObject sender, DependencyPropertyChangedEventArgs e)
        //{
        //    CustomerDetailView c = sender as CustomerDetailView;
        //    if (c != null)
        //    {
        //        c.OnCustomerChanged();
        //    }
        //}
        //private static void OnQuantityChangedCallBack(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        //{
        //    ProductCard p = sender as ProductCard;
        //    if (p != null)
        //    {
        //        p.OnQuantityChanged();
        //    }
        //}

        //protected virtual void OnQuantityChanged()
        //{
        //    // Grab related data.
        //    // Raises INotifyPropertyChanged.PropertyChanged
        //    OnPropertyChanged();
        //}
    }
}
