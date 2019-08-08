﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinUISample.Models;

namespace XamarinUISample.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            MockData();
            OpenProductCommand = new Command<int>(OpenProduct);
        }

        public ICommand OpenProductCommand { get; set; }

        public void OpenProduct(int id)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Product(id));
        }

        private void MockData()
        {
            ProductModel product1 = new ProductModel();
            ProductModel product2 = new ProductModel();
            ProductModel product3 = new ProductModel();
            ProductModel product4 = new ProductModel();
            //Product List
            product1.ProductId = 1;
            product1.Name = "Headphone 1";
            product1.Price = 250.00m;
            product1.Path = "https://www.beatsbydre.com/content/dam/beats/web/product/headphones/solo3-wireless/pdp/solo3-pdp-p9-club_yellow.png.large.1x.png";
            product1.BackgroundColor = "Red";
            product1.Battery = "15";
            product1.Connection = "Bluetooth 5.0";
            product1.Description = "With Fast Fuel it only takes a few minutes of charging to get up to 3 hours of play, so you can be on your way quicker";
            ProductList.Add(product1);
            product2.ProductId = 2;
            product2.Name = "Headphone 2";
            product2.Price = 20.00m;
            product2.Path = "https://www.trzcacak.rs/myfile/full/518-5180419_beats-solo-2-wireless-silver.png";
            product2.BackgroundColor = "Green";
            ProductList.Add(product2);
            product3.ProductId = 3;
            product3.Name = "Headphone 3";
            product3.Price = 35.00m;
            product3.Path = "https://i.ya-webdesign.com/images/headphone-transparent-beats-solo-3.png";
            product3.BackgroundColor = "Red";
            ProductList.Add(product3);
            product4.ProductId = 4;
            product4.Name = "Headphone 4";
            product4.Price = 125.00m;
            product4.Path = "https://www.beatsbydre.com/content/dam/beats/web/product/headphones/solo3-wireless/pdp/solo3-pdp-p9-club_red.png.large.1x.png";
            product4.BackgroundColor = "Blue";
            ProductList.Add(product4);
            BestSeller = product1;
        }

        private ProductModel _bestSeller = new ProductModel();
        public ProductModel BestSeller
        {
            get {return _bestSeller; }
            set { _bestSeller = value; OnPropertyChanged(); }
        }

        private List<ProductModel> _productList = new List<ProductModel>();
        public List<ProductModel> ProductList
        {
            get { return _productList; }
            set { _productList = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
