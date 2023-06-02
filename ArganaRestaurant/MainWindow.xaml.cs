using ArganaRestaurant.Models;
using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Windows;
using System.Windows.Input;

namespace ArganaRestaurant
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            //ProductsList.ItemsSource = Product.LoadProducts();
            //ProductsBoxViewModel ProductsviewModel = new ProductsBoxViewModel();
            //ProductsList.ItemsSource = ProductsviewModel.Products;
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
