using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace XamarinUISample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabbed : Xamarin.Forms.TabbedPage
    {
        public Tabbed()
        {
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            InitializeComponent();
        }
        private void BestSeller_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Product());
        }
    }
}