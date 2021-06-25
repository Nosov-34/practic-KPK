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
public partial class Corps : ContentPage
{
    public Corps()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

        private void But_Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
        private void Corps1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Corps_One());
        }
        private void Corps2(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Corps_Two());
        }
        private void Corps3(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Corps_Three());
        }

    }
}