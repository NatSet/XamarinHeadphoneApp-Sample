using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUISample.ViewModel;

namespace XamarinUISample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Product : ContentPage
    {
        public Product()
        {
            InitializeComponent();
        }

        public Product(int id)
        {
            InitializeComponent();
            BindingContext = new ProductViewModel(id);
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}