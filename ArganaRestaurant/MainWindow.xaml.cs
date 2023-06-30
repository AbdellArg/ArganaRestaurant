using ArganaRestaurant.Commands;
using ArganaRestaurant.Models;
using ArganaRestaurant.ViewModels;
using ArganaRestaurant.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ArganaRestaurant
{

    public partial class MainWindow : Window
    {

        public OrderViewModel orderViewModel;
        public ProductsBoxViewModel productsBoxViewModel;

        public MainWindow()
        {
            InitializeComponent();

            ProductsBoxViewModel productsBoxViewModel = new ProductsBoxViewModel();
            orderViewModel = new OrderViewModel(productsBoxViewModel);

            ProductsBoxView productsBoxView = new ProductsBoxView(productsBoxViewModel);

            this.DataContext = orderViewModel;
            ProductsView.Content = productsBoxView;

        }


        private void MainBackground_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left) 
            {
                this.DragMove();
            }
        }


        WindowState winState = WindowState.Normal;
        public void WindowMaxMin()
        {
            if (winState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                this.Width = 1080;
                this.Height = 720;
                winState = WindowState.Normal;
            }
            else if (winState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                winState = WindowState.Maximized;
            }

        }

        
        private void MainBackground_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
            {
                WindowMaxMin();
            }
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MaxButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowMaxMin();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void NavBarOpenClose(object sender, MouseButtonEventArgs e)
        {
            if (OpenNavBar.Visibility == Visibility.Visible) 
            {
                OpenNavBar.Visibility = Visibility.Hidden;
                CloseNavBar.Visibility = Visibility.Visible;
            }
            else
            {
                OpenNavBar.Visibility = Visibility.Visible;
                CloseNavBar.Visibility = Visibility.Hidden;
            }

        }

    }
}
