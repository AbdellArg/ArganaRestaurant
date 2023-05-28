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

namespace ArganaRestaurant.Styles.Components
{
    /// <summary>
    /// Interaction logic for ProductsCard.xaml
    /// </summary>
    public partial class ProductsCard : UserControl
    {


        public string Titel
        {
            get { return (string)GetValue(TitetProperty); }
            set { SetValue(TitetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titet.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitetProperty =
            DependencyProperty.Register("Titel", typeof(string), typeof(ProductsCard), new PropertyMetadata("N/A"));


        

        public Uri ImageURI
        {
            get { return (Uri)GetValue(ImageURIProperty); }
            set { SetValue(ImageURIProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageURI.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageURIProperty =
            DependencyProperty.Register("ImageURI", typeof(Uri), typeof(ProductsCard), new PropertyMetadata());





        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Price.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(string), typeof(ProductsCard), new PropertyMetadata(string.Empty));




        public ProductsCard()
        {
            InitializeComponent();
        }
    }
}
