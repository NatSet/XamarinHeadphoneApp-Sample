using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinUISample.ViewModel;

namespace XamarinUISample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //BindingContext = new MainPageViewModel();
        }

        //private void BestSeller_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new Product());
        //}

        //private void Open_Product(int id)
        //{
        //    Navigation.PushAsync(new Product());
        //}
    }
}
