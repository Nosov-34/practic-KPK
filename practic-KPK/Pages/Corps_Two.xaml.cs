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
public partial class Corps_Two : ContentPage
{
    public Corps_Two()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
     }

        private async void But_Back(object sender, EventArgs e)
        {
            DisabledButtons.UnLockButtons();
            await Navigation.PopModalAsync();
        }
        private void Tap_Map2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com/maps/place/%D0%9A%D0%BE%D0%BF%D0%B5%D0%B9%D1%81%D0%BA%D0%B8%D0%B9+%D0%BF%D0%BE%D0%BB%D0%B8%D1%82%D0%B5%D1%85%D0%BD%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B8%D0%B9+%D0%BA%D0%BE%D0%BB%D0%BB%D0%B5%D0%B4%D0%B6/@55.1100372,61.6094323,15z/data=!4m9!1m2!2m1!1z0KPRh9C10LHQvdGL0Lkg0LrQvtGA0L_Rg9GBLCDQsy4g0JrQvtC_0LXQudGB0LosINC_0YAuINCY0LvRjNC40YfQsCwgMTQ!3m5!1s0x43c5f3fa3ab61075:0x1a6e6ae74b47624d!8m2!3d55.108738!4d61.614267!15sCkfQo9GH0LXQsdC90YvQuSDQutC-0YDQv9GD0YEsINCzLiDQmtC-0L_QtdC50YHQuiwg0L_RgC4g0JjQu9GM0LjRh9CwLCAxNFpEIkLRg9GH0LXQsdC90YvQuSDQutC-0YDQv9GD0YEg0LMg0LrQvtC_0LXQudGB0Log0L_RgCDQuNC70YzQuNGH0LAgMTSSAQdjb2xsZWdl"));
        }
    }
}