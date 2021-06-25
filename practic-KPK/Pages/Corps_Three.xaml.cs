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
public partial class Corps_Three : ContentPage
{
    public Corps_Three()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

        private void But_Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Corps());
        }
        private void Tap_Map3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com/maps/place/%D0%A4%D0%B8%D0%BB%D0%B8%D0%B0%D0%BB+%D0%9A%D0%BE%D0%BF%D0%B5%D0%B9%D1%81%D0%BA%D0%BE%D0%B3%D0%BE+%D0%BF%D0%BE%D0%BB%D0%B8%D1%82%D0%B5%D1%85%D0%BD%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%BE%D0%B3%D0%BE+%D0%BA%D0%BE%D0%BB%D0%BB%D0%B5%D0%B4%D0%B6%D0%B0+%D0%B3.%D0%9F%D0%BB%D0%B0%D1%81%D1%82/@54.382479,60.8170739,16z/data=!4m8!1m2!2m1!1z0KTQuNC70LjQsNC7LCDQsy4g0J_Qu9Cw0YHRgiwg0YPQuy4g0KPRh9C10LHQvdGL0Lkg0LPQvtGA0L7QtNC-0LosIDEyINC60LDRgNGC0LA!3m4!1s0x43cfc16822a11c65:0x582cb215df8d629f!8m2!3d54.3814185!4d60.8184088"));
        }
    }
}