using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XamarinUISample.Models;

namespace XamarinUISample.ViewModel
{
    class ProductViewModel : INotifyPropertyChanged
    {
        public ProductViewModel()
        {
            Mockup(1);
        }
        public ProductViewModel(int id)
        {
            Mockup(id);
        }

        private void Mockup(int id)
        {
            switch(id)
            {
                case 1: Product = Product1(); break; 
                case 2: Product = Product2(); break;
                case 3: Product = Product3(); break;
                case 4: Product = Product4(); break;
            }
        }

        private ProductModel Product1()
        {
            ProductModel product = new ProductModel();
            product.Name = "Headphone 1";
            product.Price = 250.00m;
            product.Path = "https://www.beatsbydre.com/content/dam/beats/web/product/headphones/solo3-wireless/pdp/solo3-pdp-p9-club_yellow.png.large.1x.png";
            product.BackgroundColor = "Red";
            product.Battery = "15";
            product.Connection = "Bluetooth 5.0";
            product.Description = "With Fast Fuel it only takes a few minutes of charging to get up to 3 hours of play, so you can be on your way quicker";
            return product;
        }

        private ProductModel Product2()
        {
            ProductModel product = new ProductModel();
            product.Name = "Headphone 2";
            product.Price = 20.00m;
            product.Path = "https://www.trzcacak.rs/myfile/full/518-5180419_beats-solo-2-wireless-silver.png";
            product.BackgroundColor = "Red";
            product.Battery = "2";
            product.Connection = "Bluetooth 2.0";
            product.Description = "The more affordable model";
            return product;
        }

        private ProductModel Product3()
        {
            ProductModel product = new ProductModel();
            product.Name = "Headphone 3";
            product.Price = 35.00m;
            product.Path = "https://i.ya-webdesign.com/images/headphone-transparent-beats-solo-3.png";
            product.BackgroundColor = "Red";
            product.Battery = "25";
            product.Connection = "Bluetooth 5.0";
            product.Description = "With Fast Fuel it only takes a few minutes of charging to get up to 3 hours of play, so you can be on your way quicker";
            return product;
        }

        private ProductModel Product4()
        {
            ProductModel product = new ProductModel();
            product.Name = "Headphone 4";
            product.Price = 125.00m;
            product.Path = "https://www.beatsbydre.com/content/dam/beats/web/product/headphones/solo3-wireless/pdp/solo3-pdp-p9-club_red.png.large.1x.png";
            product.BackgroundColor = "Red";
            product.Battery = "4";
            product.Connection = "Bluetooth 5.0";
            product.Description = "With Fast Fuel it only takes a few minutes of charging to get up to 3 hours of play, so you can be on your way quicker";
            return product;
        }


        private ProductModel _product = new ProductModel();

        public ProductModel Product
        {
            get { return _product; }
            set { _product = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
