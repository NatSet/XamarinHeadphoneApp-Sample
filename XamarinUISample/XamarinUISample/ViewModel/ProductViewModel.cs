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
            Mockup();
        }

        private void Mockup()
        {

                ProductModel product = new ProductModel();
                product.Name = "Headphone 1";
                product.Price = 250.00m;
                product.Path = "https://www.beatsbydre.com/content/dam/beats/web/product/headphones/solo3-wireless/pdp/solo3-pdp-p9-club_yellow.png.large.1x.png";
                product.BackgroundColor = "Red";
                product.Battery = "15";
                product.Connection = "Bluetooth 5.0";
                product.Description = "With Fast Fuel it only takes a few minutes of charging to get up to 3 hours of play, so you can be on your way quicker";
                _product = product;
            

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
