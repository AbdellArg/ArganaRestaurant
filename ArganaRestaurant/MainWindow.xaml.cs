﻿using ArganaRestaurant.Commands;
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

namespace ArganaRestaurant
{

    public partial class MainWindow : Window
    {
        OrderViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            //ProductsBoxViewModel productsBoxViewModel = new ProductsBoxViewModel();
            viewModel = new OrderViewModel();

            this.DataContext = viewModel;
            //ProductsView.DataContext = viewModel.ProductsViewModel;
            //this.DataContext = viewModel;
            //LV.ItemsSource = viewModel.Products;

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



        private void ProductsView_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            //// We will pass the DataContext
            //var content = ProductsView.Content as FrameworkElement;
            //if (content == null)
            //    return;
            //content.DataContext = ProductsView.DataContext;
            //var a = content.DataContext as ProductsBoxViewModel;
            //var items = ProductsView.Content as ProductsBoxView;

            ////items.ProductsList.ItemsSource = a.Products;
            ///

            //ProductsBoxViewModel CurrentViewModel = (this.DataContext as OrderViewModel).ProductsViewModel;
                
            //var LoadCategories = new LoadCategories(CurrentViewModel);
            //LoadCategories.Execute(null);
            //var LoadProducts = new GetProductsCommand(CurrentViewModel, false);
            //LoadProducts.Execute(null);
        }

        private void ProductsView_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //ProductsView.Refresh();

        }



        //ICollectionView view = CollectionViewSource.GetDefaultView(ItemsSource);
        //view.Refresh();

    }
}
