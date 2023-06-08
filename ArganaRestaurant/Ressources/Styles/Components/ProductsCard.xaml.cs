using ArganaRestaurant.Models;
using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        // every ProductCard is bound with a Product from the ProductsList's Items in the ViewModel, or it's DataContext
        // that Item is stored in CurrentItem, so we can access to the Props and Methods from Here when we want

        ProductsViewModel CurrentItem;

        public ProductCard()
        {
            InitializeComponent();
        }




        private void AddToOrders_Click(object sender, RoutedEventArgs e)
        {
            CurrentItem.Quantity = 1;
            EffectsOnCountityChanged();
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentItem.Quantity--;
            EffectsOnCountityChanged();
        }


        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentItem.Quantity++;
            EffectsOnCountityChanged();
        }

        public void EffectsOnCountityChanged()
        {
            if(CurrentItem.Quantity == 0)
            {
                this.AddToOrders.Visibility = Visibility.Visible;
                this.ItemCountity.Visibility = Visibility.Hidden;
            }
            else
            {
                this.AddToOrders.Visibility = Visibility.Hidden;
                this.ItemCountity.Visibility = Visibility.Visible;
            }

            IsSelected();
            //Update();
        }


        // when a Item is Selected from the ProductsListBox, it will have a Border Style that's already defined in XAML
        public void IsSelected()
        {
            _ = CurrentItem.Quantity == 0 ? this.CardHolder.BorderThickness = new Thickness(0) : this.CardHolder.BorderThickness = new Thickness(3);
        }


        //public void Update()
        //{

        //    CurrentItem = (ProductsViewModel)this.DataContext;
        //    CurrentItem.Title = this.Titel;
        //    CurrentItem.Quantity = this.Totale;
        //    this.DataContext = CurrentItem;
            
        //}


        
        private void CardHolder_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentItem = (ProductsViewModel)this.DataContext;
            _ = CurrentItem.IsVegan ? this.VeganIcon.Visibility = Visibility.Visible : this.VeganIcon.Visibility = Visibility.Hidden;
        }
    }
}
