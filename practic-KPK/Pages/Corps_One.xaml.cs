using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace practic_KPK.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Corps_One : ContentPage
{
    public Corps_One()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

        private void But_Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Corps());
        }

        private void Tap_Map1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com/maps/place/%D0%9A%D0%9E%D0%9F%D0%95%D0%99%D0%A1%D0%9A%D0%98%D0%99+%D0%9F%D0%9E%D0%9B%D0%98%D0%A2%D0%95%D0%A5%D0%9D%D0%98%D0%A7%D0%95%D0%A1%D0%9A%D0%98%D0%99+%D0%9A%D0%9E%D0%9B%D0%9B%D0%95%D0%94%D0%96+%D0%98%D0%9C.+%D0%A1.%D0%92.+%D0%A5%D0%9E%D0%A5%D0%A0%D0%AF%D0%9A%D0%9E%D0%92%D0%90/@55.1102147,61.6203926,17z/data=!4m9!1m2!2m1!1z0KPRh9C10LHQvdGL0Lkg0LrQvtGA0L_Rg9GBLCDQsy4g0JrQvtC_0LXQudGB0LosINGD0LsuINCb0LXQvdC40L3QsCwgNDA!3m5!1s0x43c5f3fc30a5dccd:0xbe852888d65bd0da!8m2!3d55.1102025!4d61.6226708!15sCkfQo9GH0LXQsdC90YvQuSDQutC-0YDQv9GD0YEsINCzLiDQmtC-0L_QtdC50YHQuiwg0YPQuy4g0JvQtdC90LjQvdCwLCA0MFpEIkLRg9GH0LXQsdC90YvQuSDQutC-0YDQv9GD0YEg0LMg0LrQvtC_0LXQudGB0Log0YPQuyDQu9C10L3QuNC90LAgNDCSAQdjb2xsZWdl"));
        }
    }
}