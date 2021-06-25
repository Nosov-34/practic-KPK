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

        private async void But_Back(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        private async void Corps1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Corps_One());
        }
        private async void Corps2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Corps_Two());
        }
        private async void Corps3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Corps_Three());
        }

    }
}